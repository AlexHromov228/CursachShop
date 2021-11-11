﻿using AkiraShop2.Controllers;
using AkiraShop2.Data;
using AkiraShop2.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AkiraShop2.Areas.Orders.Controllers
{
    [Area("Shop")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public CartController(ILogger<HomeController> logger, ApplicationDbContext context, IWebHostEnvironment ihost)
        {
            _context = context;
            _hostingEnvironment = ihost;
            _logger = logger;
        }
        
        //GET
        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                Order cart = await _context.Order.Include(o => o.OrderItems).FirstOrDefaultAsync(i => i.UserOrderId == userId && i.Status == "CART");
                Order wait_list = await _context.Order.Include(o => o.OrderItems).FirstOrDefaultAsync(i => i.UserOrderId == userId && i.Status == "WISH_LIST");

                if (cart != null)
                {
                    await cart.InitOrder(_context);
                    
                }
                else
                {
                    return NotFound();
                }
                if (wait_list != null)
                {
                    await wait_list.InitOrder(_context);
                }
                else
                {
                    return NotFound();
                }

                List<Item> notAvalibleItems = cart.order_checkForAvalibleAmount(cart.items_with_amounts);

                if (notAvalibleItems.Count != 0)
                {
                    foreach (var NOitem in notAvalibleItems)
                    {
                        if (!wait_list.ItemsForOrder.Any(i => i == NOitem)) 
                        {
                            _context.OrderItem.Add(new OrderItem { OrderItem_ItemId = NOitem.Id, OrderItem_OrderId = wait_list.Id });
                            
                            wait_list.ItemsForOrder.Add(NOitem);

                            
                        }
                        cart.ItemsForOrder.RemoveAll(i => i.Id == NOitem.Id);
                        cart.items_with_amounts = cart.itemToBuy_amount(cart.ItemsForOrder);

                        OrderItem toRemove = await _context.OrderItem.FirstOrDefaultAsync(i => i.OrderItem_ItemId == NOitem.Id && i.OrderItem_OrderId == cart.Id);
                        _context.OrderItem.Remove(toRemove);
                    }
                    await _context.SaveChangesAsync();

                }

                List<Order> result = new List<Order> { cart, wait_list };
                return View(result);

            }
            else
            {
                return NotFound();
            }
            

        }

        public async Task<IActionResult> DeleteItem(int? itemId, string? status)
        {
            if (itemId == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FindAsync(itemId);

            Order order = await _context.Order.FirstOrDefaultAsync(i => i.UserOrderId == User.FindFirstValue(ClaimTypes.NameIdentifier) && i.Status == status);


            OrderItem orderItem = await _context.OrderItem.FirstOrDefaultAsync(i => i.OrderItem_ItemId == itemId.Value && i.OrderItem_OrderId == order.Id);

            _context.OrderItem.Remove(orderItem);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> CreateOrder(int? orderId)
        {
            if (orderId == null)
            {
                return NotFound();
            }

            Order cart = await _context.Order.Include(o => o.OrderItems).FirstOrDefaultAsync(i => i.Id == orderId);
            await cart.order_Create(_context);

            return RedirectToAction(nameof(Index));
        }
    }
}

#pragma checksum "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "388763a42896e2bea6070533f79c835789d141b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Shop_Views_Cart_Index), @"mvc.1.0.view", @"/Areas/Shop/Views/Cart/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\_ViewImports.cshtml"
using AkiraShop2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\_ViewImports.cshtml"
using AkiraShop2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\_ViewImports.cshtml"
using AkiraShop2.Entities.HelperEntities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"388763a42896e2bea6070533f79c835789d141b1", @"/Areas/Shop/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"514f104b802799cf63540c91549c9507be53ad7d", @"/Areas/Shop/Views/_ViewImports.cshtml")]
    public class Areas_Shop_Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AkiraShop2.Entities.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("130"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("130"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image not found ;("), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn del_button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "CART", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn buy_button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "WISH_LIST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Корзина";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n\r\n\r\n    <div class=\"col-8 item_list\">\r\n\r\n        <h1>Корзина</h1>\r\n");
#nullable restore
#line 14 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
         if (Model.First().items_with_amounts.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item_DIV_error\">\r\n\r\n                <h3>Корзина пуста!</h3>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
             foreach (var item in Model.First().items_with_amounts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("onclick", " onclick=\"", 497, "\"", 552, 5);
            WriteAttributeValue("", 507, "location.href", 507, 13, true);
            WriteAttributeValue(" ", 520, "=", 521, 2, true);
            WriteAttributeValue(" ", 522, "\'/Shop/Product/", 523, 16, true);
#nullable restore
#line 25 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 538, item.Key.Id, 538, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 550, "\';", 550, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer;\">\r\n                    <div class=\"cart_item_DIV\">\r\n                        <div class=\"cart_item_image\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "388763a42896e2bea6070533f79c835789d141b18653", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 723, "~/uploads/Item/", 723, 15, true);
#nullable restore
#line 28 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 738, item.Key.Image, 738, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"cart_item_title_desc\">\r\n                            <h2>");
#nullable restore
#line 31 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
                           Write(item.Key.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>Количество в корзине: ");
#nullable restore
#line 32 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
                                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"cart_item_price\">\r\n                            <h3>");
#nullable restore
#line 35 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
                           Write(item.Key.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₽</h3>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "388763a42896e2bea6070533f79c835789d141b111550", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
                                                                                    WriteLiteral(item.Key.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 41 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 item_DIV_error\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "388763a42896e2bea6070533f79c835789d141b114763", async() => {
                WriteLiteral("Оформить заказ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
                                                                          WriteLiteral(Model.First().Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 46 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n    <div class=\"col-4 item_list\">\r\n        <h1>Избраноое</h1>\r\n");
#nullable restore
#line 53 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
         if (Model.Last().ItemsForOrder.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item_DIV_error\">\r\n\r\n                <h3>Список избранного пуст!</h3>\r\n            </div>\r\n");
#nullable restore
#line 59 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
             foreach (var item in Model.Last().ItemsForOrder)
            {
                string opacit = "1";
                string curs = "pointer";
                if (item.Amount == 0)
                {
                    opacit = "0.5";
                    curs = "auto";
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("onclick", " onclick=\"", 2248, "\"", 2299, 5);
            WriteAttributeValue("", 2258, "location.href", 2258, 13, true);
            WriteAttributeValue(" ", 2271, "=", 2272, 2, true);
            WriteAttributeValue(" ", 2273, "\'/Shop/Product/", 2274, 16, true);
#nullable restore
#line 72 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2289, item.Id, 2289, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2297, "\';", 2297, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 2300, "\"", 2339, 5);
            WriteAttributeValue("", 2308, "cursor:", 2308, 7, true);
#nullable restore
#line 72 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 2315, curs, 2316, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2321, ";", 2321, 1, true);
            WriteAttributeValue(" ", 2322, "opacity:", 2323, 9, true);
#nullable restore
#line 72 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 2331, opacit, 2332, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"cart_item_DIV\">\r\n\r\n                        <div class=\"cart_item_image\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "388763a42896e2bea6070533f79c835789d141b120156", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2487, "~/uploads/Item/", 2487, 15, true);
#nullable restore
#line 76 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 2502, item.Image, 2502, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"cart_item_title_desc\">\r\n                            <h2>");
#nullable restore
#line 79 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>Количество на складе ");
#nullable restore
#line 80 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
                                               Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"cart_item_price\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "388763a42896e2bea6070533f79c835789d141b122750", async() => {
                WriteLiteral("-");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 88 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
                
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
             


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n    \r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 103 "C:\Users\Alexandr\source\repos\AkiraShop2TEST2\AkiraShop2\Areas\Shop\Views\Cart\Index.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
        await Html.RenderPartialAsync("_AuthScriptsPartial");
    

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AkiraShop2.Entities.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591

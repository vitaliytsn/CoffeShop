#pragma checksum "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b600fe9ad324ba5be8359665e48ea9d4a8c4c1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MainOrder), @"mvc.1.0.view", @"/Views/User/MainOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/MainOrder.cshtml", typeof(AspNetCore.Views_User_MainOrder))]
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
#line 1 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\_ViewImports.cshtml"
using CoffeShop;

#line default
#line hidden
#line 2 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\_ViewImports.cshtml"
using CoffeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b600fe9ad324ba5be8359665e48ea9d4a8c4c1b", @"/Views/User/MainOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed2208080f960c2c9f610815cf672d175db3928", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MainOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
  
    ViewData["Title"] = "MainOrder";

#line default
#line hidden
#line 5 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
  
    Layout = (string)ViewData["Layout"] ?? "_Layout";

#line default
#line hidden
            BeginContext(133, 52, true);
            WriteLiteral("\r\n<h2>Замовлення</h2>\r\n<html style=\"height: 100%\">\r\n");
            EndContext();
            BeginContext(185, 15, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97e5c93774e452ea969ed29f8bed4ae", async() => {
                BeginContext(191, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(202, 1618, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8b9731cf15f4658892ffc28e0276eb1", async() => {
                BeginContext(229, 163, true);
                WriteLiteral("\r\n<table class=\"table\" style=\"background-color: #CF9979; \">\r\n    <thead>\r\n    <tr style=\"color: #87cefa\">\r\n        <th>\r\n        </th>\r\n        <th >\r\n            ");
                EndContext();
                BeginContext(393, 40, false);
#line 20 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(433, 43, true);
                WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
                EndContext();
                BeginContext(477, 47, false);
#line 23 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(524, 43, true);
                WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
                EndContext();
                BeginContext(568, 41, false);
#line 26 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(609, 74, true);
                WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 32 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
                BeginContext(724, 69, true);
                WriteLiteral("        <tr style=\"color: azure\">\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(794, 153, false);
#line 36 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
           Write(Html.Partial("Item_ImagePartial", new ViewDataDictionary(ViewData) { { "ImageId", item.Images[0].Id }, { "X", ViewBag.Width }, { "Y", ViewBag.Height } }));

#line default
#line hidden
                EndContext();
                BeginContext(947, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1003, 39, false);
#line 39 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1042, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1098, 46, false);
#line 42 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1144, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1200, 40, false);
#line 45 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1240, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1296, 201, false);
#line 48 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
           Write(Html.ActionLink(
                    "Усунути З Замовлення",
                    "Item_RemoveFromOrder",
                    "User",
                    new {items = ViewBag.arr, ItemId = item.Id}));

#line default
#line hidden
                EndContext();
                BeginContext(1497, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 55 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
    }

#line default
#line hidden
                BeginContext(1540, 35, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(1576, 116, false);
#line 59 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
Write(Html.ActionLink(
        "Замовити",
        "Order_Accept",
        "User",
        new { items = ViewBag.arr}));

#line default
#line hidden
                EndContext();
                BeginContext(1692, 121, true);
                WriteLiteral("\r\n</div>\r\n\r\n<hr/>\r\n<hr/>\r\n<div id=\"ItemGroupPartial\" style=\"height: 5%; width: auto; overflow: auto;\"/>\r\n<hr/>\r\n<hr/>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1820, 189, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n    window.onload=function () {\r\n        var x = window.innerHeight;\r\n        var y = window.innerWidth;\r\n        var link =\r\n            \"");
            EndContext();
            BeginContext(2010, 125, false);
#line 82 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\MainOrder.cshtml"
        Write(Html.Raw(Url.Action("ItemGroup_ListPartial", "User", new { X= "widthToReplace", Y = "heightToReplace", items =@ViewBag.arr})));

#line default
#line hidden
            EndContext();
            BeginContext(2135, 170, true);
            WriteLiteral("\";\r\n        link = link.replace(\"heightToReplace\", x);\r\n        link = link.replace(\"widthToReplace\", y);\r\n        $(\"#ItemGroupPartial\").load(link);\r\n    };\r\n</script>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f438a8766b7410e94126491e8c8d3c1500d3605"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Item_ListPartial), @"mvc.1.0.view", @"/Views/User/Item_ListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Item_ListPartial.cshtml", typeof(AspNetCore.Views_User_Item_ListPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f438a8766b7410e94126491e8c8d3c1500d3605", @"/Views/User/Item_ListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed2208080f960c2c9f610815cf672d175db3928", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Item_ListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
  
    ViewData["Title"] = "Item_ListPartial";

#line default
#line hidden
            BeginContext(80, 103, true);
            WriteLiteral("\r\n<h2>Товари в групі</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(184, 40, false);
#line 14 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(224, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(268, 47, false);
#line 17 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(315, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(359, 41, false);
#line 20 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(400, 74, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(510, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(559, 39, false);
#line 29 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(598, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(654, 46, false);
#line 32 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(700, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(756, 40, false);
#line 35 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(796, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(852, 167, false);
#line 38 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
           Write(Html.ActionLink(
                    "Вибрати товар",
                    "Item_Delete",
                    "Admin",
                    new { itemId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 37, true);
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
    }

#line default
#line hidden
            BeginContext(1063, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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

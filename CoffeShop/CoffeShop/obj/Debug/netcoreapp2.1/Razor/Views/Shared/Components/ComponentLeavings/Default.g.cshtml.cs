#pragma checksum "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "326b708508dba3cb96471183075ad96c35601acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ComponentLeavings_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ComponentLeavings/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ComponentLeavings/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ComponentLeavings_Default))]
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
#line 1 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\_ViewImports.cshtml"
using CoffeShop;

#line default
#line hidden
#line 2 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\_ViewImports.cshtml"
using CoffeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"326b708508dba3cb96471183075ad96c35601acf", @"/Views/Shared/Components/ComponentLeavings/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed2208080f960c2c9f610815cf672d175db3928", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ComponentLeavings_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ComponentLeavingVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml"
  
    ViewData["Title"] = "ItemComponentList";

#line default
#line hidden
            BeginContext(95, 118, true);
            WriteLiteral("\r\n<h2>Залишок Компонентів</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(214, 50, false);
#line 13 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Name));

#line default
#line hidden
            EndContext();
            BeginContext(264, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(320, 42, false);
#line 16 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(362, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(418, 40, false);
#line 19 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(458, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(593, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(654, 49, false);
#line 29 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Component.Name));

#line default
#line hidden
            EndContext();
            BeginContext(703, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(771, 41, false);
#line 32 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(812, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(880, 39, false);
#line 35 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(919, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\Shared\Components\ComponentLeavings\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(974, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ComponentLeavingVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

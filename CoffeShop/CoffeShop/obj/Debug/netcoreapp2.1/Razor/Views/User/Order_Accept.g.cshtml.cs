#pragma checksum "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf176c2b63c2c8d60e4a4a534b66b0fa68287dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Order_Accept), @"mvc.1.0.view", @"/Views/User/Order_Accept.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Order_Accept.cshtml", typeof(AspNetCore.Views_User_Order_Accept))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf176c2b63c2c8d60e4a4a534b66b0fa68287dd8", @"/Views/User/Order_Accept.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed2208080f960c2c9f610815cf672d175db3928", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Order_Accept : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<global::CoffeShop.Models.ViewModels.OrderVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MainOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(84, 153, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<h2>Чек</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            <p>Обслуговуючий Персонал:</p>\r\n            ");
            EndContext();
            BeginContext(238, 45, false);
#line 15 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Name));

#line default
#line hidden
            EndContext();
            BeginContext(283, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(298, 48, false);
#line 16 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(346, 74, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            <p>До Сплати:</p>\r\n            ");
            EndContext();
            BeginContext(421, 42, false);
#line 20 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml"
       Write(Html.DisplayFor(model => model.FinalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(463, 110, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n    <hr />\r\n    <hr />\r\n    <hr />\r\n");
            EndContext();
#line 29 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml"
     foreach (var item in Model.OrderItems)
    {

#line default
#line hidden
            BeginContext(625, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(674, 39, false);
#line 33 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(713, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(769, 46, false);
#line 36 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(815, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(871, 40, false);
#line 39 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(911, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 42 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Order_Accept.cshtml"
    }

#line default
#line hidden
            BeginContext(954, 30, true);
            WriteLiteral("    \r\n    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(984, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e2ad7e1fd34ed4836c7205b1df53c7", async() => {
                BeginContext(1010, 15, true);
                WriteLiteral("Нове Замовлення");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1029, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<global::CoffeShop.Models.ViewModels.OrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

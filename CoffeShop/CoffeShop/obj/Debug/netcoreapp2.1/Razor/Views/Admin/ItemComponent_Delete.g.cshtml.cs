#pragma checksum "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Admin\ItemComponent_Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8918f1cd4a6a24fd8459f3c0840cce7d88c4e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ItemComponent_Delete), @"mvc.1.0.view", @"/Views/Admin/ItemComponent_Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ItemComponent_Delete.cshtml", typeof(AspNetCore.Views_Admin_ItemComponent_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8918f1cd4a6a24fd8459f3c0840cce7d88c4e2b", @"/Views/Admin/ItemComponent_Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed2208080f960c2c9f610815cf672d175db3928", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ItemComponent_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemComponent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ItemComponent_Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Admin\ItemComponent_Delete.cshtml"
  
    ViewData["Title"] = "ItemComponent_Delete";

#line default
#line hidden
            BeginContext(80, 135, true);
            WriteLiteral("\r\n<h3>Ви напевно хочете видалити цей складник?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n   \r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(216, 57, false);
#line 13 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Admin\ItemComponent_Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentComponent.Name));

#line default
#line hidden
            EndContext();
            BeginContext(273, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(317, 53, false);
#line 16 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Admin\ItemComponent_Delete.cshtml"
       Write(Html.DisplayFor(model => model.CurrentComponent.Name));

#line default
#line hidden
            EndContext();
            BeginContext(370, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(414, 42, false);
#line 19 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Admin\ItemComponent_Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(456, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(500, 38, false);
#line 22 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Admin\ItemComponent_Delete.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(538, 40, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n\r\n    ");
            EndContext();
            BeginContext(578, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b84696f9f654d54b9a4a2badd7bfa86", async() => {
                BeginContext(618, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(629, 33, false);
#line 28 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Admin\ItemComponent_Delete.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(662, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(673, 47, false);
#line 29 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Admin\ItemComponent_Delete.cshtml"
   Write(Html.HiddenFor(model => model.ComponentItem.Id));

#line default
#line hidden
                EndContext();
                BeginContext(720, 77, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(804, 33, true);
            WriteLiteral("\r\n    <hr />\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(838, 185, false);
#line 34 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Admin\ItemComponent_Delete.cshtml"
   Write(Html.ActionLink(
            "назад",
            "Item_Edit",            // controller action
            "Admin",        // controller
            new { itemId = ViewBag.itemId }));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 24, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemComponent> Html { get; private set; }
    }
}
#pragma warning restore 1591

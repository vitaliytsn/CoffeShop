#pragma checksum "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26f3dbd45da919a113c46f0af90bda26626bba79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ItemGroup_Partial), @"mvc.1.0.view", @"/Views/User/ItemGroup_Partial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ItemGroup_Partial.cshtml", typeof(AspNetCore.Views_User_ItemGroup_Partial))]
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
#line 1 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml"
using CoffeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f3dbd45da919a113c46f0af90bda26626bba79", @"/Views/User/ItemGroup_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed2208080f960c2c9f610815cf672d175db3928", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ItemGroup_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ItemGroup>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ItemGroup_Components", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 100, true);
            WriteLiteral("\r\n<h2>Групи товарів</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(202, 40, false);
#line 14 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(242, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(286, 47, false);
#line 17 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(333, 74, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(443, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(492, 39, false);
#line 26 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(531, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(587, 46, false);
#line 29 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(633, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(688, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b07d692d23814078b0cfba501d83b8d3", async() => {
                BeginContext(777, 7, true);
                WriteLiteral("Вибрати");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemGroupId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemGroupId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemGroupId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemGroupId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(788, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\ItemGroup_Partial.cshtml"
    }

#line default
#line hidden
            BeginContext(831, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ItemGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591

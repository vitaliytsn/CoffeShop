#pragma checksum "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dcea05d1ad871cd8113beb978d929bbe693a1d2"
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
#line 1 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\_ViewImports.cshtml"
using CoffeShop;

#line default
#line hidden
#line 2 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\_ViewImports.cshtml"
using CoffeShop.Models;

#line default
#line hidden
#line 1 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
using CoffeShop.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dcea05d1ad871cd8113beb978d929bbe693a1d2", @"/Views/User/Item_ListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed2208080f960c2c9f610815cf672d175db3928", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Item_ListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderedItemVm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
      
    ViewData["Title"] = "Item_ListPartial";
    

#line default
#line hidden
            BeginContext(134, 37, true);
            WriteLiteral("\r\n    <h2>Товари в групі</h2>\r\n\r\n\r\n\r\n");
            EndContext();
#line 12 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
     using (Html.BeginForm())
    {
    

#line default
#line hidden
            BeginContext(214, 23, false);
#line 14 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(239, 292, true);
            WriteLiteral(@"    <div>
        <input  class=""btnSub btn btn-default"" type=""button"" value=""Додати до замовлення"" class=""btn btn-default"" />
    </div>
    <table class=""table"">
        <thead>
            <tr>
                <th>

                </th>
                <th>
                    ");
            EndContext();
            BeginContext(532, 45, false);
#line 25 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
               Write(Html.DisplayNameFor(model => model.Item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(577, 114, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(692, 52, false);
#line 31 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
               Write(Html.DisplayNameFor(model => model.Item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(744, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(812, 46, false);
#line 34 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
               Write(Html.DisplayNameFor(model => model.Item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(858, 112, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(971, 42, false);
#line 39 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
               Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 108, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
            EndContext();
#line 46 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1178, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1239, 158, false);
#line 50 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
               Write(Html.Partial("Item_ImagePartial", new ViewDataDictionary(ViewData) { { "ImageId", item.Item.Images[0].Id }, { "X", ViewBag.Width }, { "Y", ViewBag.Height } }));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1467, 44, false);
#line 54 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1579, 382, false);
#line 57 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
               Write(Html.ActionLink(
                    "Склад",
                    "ItemInfo", // controller action
                    "User", // controller
                    new
                    {
                    items = @ViewBag.arr,
                    itemId = item.Item.Id,
                    X = ViewBag.Width,
                    Y = ViewBag.Height
                    }));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2029, 51, false);
#line 70 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2148, 45, false);
#line 73 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 136, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input class=\"btnSubtraction btn btn-default\" type=\"button\" data-id=\"");
            EndContext();
            BeginContext(2330, 12, false);
#line 76 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
                                                                                    Write(item.Item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2342, 138, true);
            WriteLiteral("\" value=\"minus\" />\r\n                </td>\r\n                <td style=\"width:7%\">\r\n                    <input style=\"width:50%\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2480, "\"", 2500, 1);
#line 79 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
WriteAttributeValue("", 2488, item.Amount, 2488, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2501, "\"", 2519, 1);
#line 79 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
WriteAttributeValue("", 2506, item.Item.Id, 2506, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2520, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(2718, 128, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input class=\"btnAdd btn btn-default\" type=\"button\" data-id=\"");
            EndContext();
            BeginContext(2847, 12, false);
#line 85 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
                                                                            Write(item.Item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2859, 63, true);
            WriteLiteral("\" value=\"plus\" />\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 89 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"

            }

#line default
#line hidden
            BeginContext(2939, 334, true);
            WriteLiteral(@"
        </tbody>
        <tfoot>
            <tr>
                <td>
                    <input class=""btnSub btn btn-default"" type=""button"" value=""Додати до замовлення"" class=""btn btn-default"" />
                </td>
                <td></td>
                <td></td>
            </tr>
        </tfoot>
    </table>
");
            EndContext();
#line 103 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
    }

#line default
#line hidden
            BeginContext(3280, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(3288, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17b108fe79a6465da1477f788fe5637e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3339, 1780, true);
            WriteLiteral(@"

    <script type=""text/javascript"">

    var orders = [];
    $(function () {
        $('.btnAdd').click(function () {
            var btn = $(this);
            var $itemId = btn.data('id');
            var elem = document.getElementById($itemId);
            document.getElementById($itemId).value = parseInt($(""#"" + $itemId).val(), 10) + 1;
            if (orders.length == 0) {
                orders.push({ ItemId: $itemId, Amount: 1 });
            } else {
                var inOrder = false;
                for (var i = 0; i < orders.length; i++) {
                    if (orders[i].ItemId == $itemId) {
                        orders[i].Amount += 1;
                        inOrder = true;
                    }
                }
                if (!inOrder) {
                    orders.push({ ItemId: $itemId, Amount: 1 });
                }
            }
        });
    });
    $(function () {
        $('.btnSubtraction').click(function () {
            var btn = $(this);
  ");
            WriteLiteral(@"          var $itemId = btn.data('id');
            var elem = document.getElementById($itemId);

            var inOrder = false;
            for (var i = 0; i < orders.length; i++) {
                if (orders[i].ItemId == $itemId && orders[i].Amount > 0) {
                    orders[i].Amount -= 1;
                    inOrder = true;
                }
            }
            if (inOrder) {
                document.getElementById($itemId).value = parseInt($(""#"" + $itemId).val(), 10) - 1;
            }
        });
    });

        $('.btnSub').click(function () {

        
        var itemsArr = JSON.stringify(orders);
        var x = window.innerHeight;
        var y = window.innerWidth;
        var link =
            """);
            EndContext();
            BeginContext(5120, 148, false);
#line 159 "C:\Projects\CoffeShopRepo\CoffeShop\CoffeShop\Views\User\Item_ListPartial.cshtml"
        Write(Html.Raw(Url.Action("MainOrder", "User", new { selected = "selectedToReplace", Y = "heightToReplace", X = "widthToReplace", items = @ViewBag.arr })));

#line default
#line hidden
            EndContext();
            BeginContext(5268, 235, true);
            WriteLiteral("\";\r\n        link = link.replace(\"heightToReplace\", x);\r\n        link = link.replace(\"selectedToReplace\", itemsArr);\r\n        link = link.replace(\"widthToReplace\",y);\r\n        window.location.href = link;\r\n\r\n    });\r\n    </script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderedItemVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591

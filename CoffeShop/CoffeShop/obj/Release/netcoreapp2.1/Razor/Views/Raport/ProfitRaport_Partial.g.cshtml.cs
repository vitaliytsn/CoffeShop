#pragma checksum "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596f23c7958a718809979413a7613f718bf77e6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Raport_ProfitRaport_Partial), @"mvc.1.0.view", @"/Views/Raport/ProfitRaport_Partial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Raport/ProfitRaport_Partial.cshtml", typeof(AspNetCore.Views_Raport_ProfitRaport_Partial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596f23c7958a718809979413a7613f718bf77e6b", @"/Views/Raport/ProfitRaport_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed2208080f960c2c9f610815cf672d175db3928", @"/Views/_ViewImports.cshtml")]
    public class Views_Raport_ProfitRaport_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
  
    ViewData["Title"] = "Order_ListOfUser";

#line default
#line hidden
            BeginContext(81, 14, true);
            WriteLiteral("\r\n<p>Виручка: ");
            EndContext();
            BeginContext(96, 19, false);
#line 7 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
       Write(ViewBag.MoneyIncome);

#line default
#line hidden
            EndContext();
            BeginContext(115, 17, true);
            WriteLiteral("<p>\r\n<p>Затрати: ");
            EndContext();
            BeginContext(133, 19, false);
#line 8 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
       Write(ViewBag.MoneyProfit);

#line default
#line hidden
            EndContext();
            BeginContext(152, 109, true);
            WriteLiteral("<p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(262, 49, false);
#line 13 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(311, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(379, 46, false);
#line 16 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
               Write(Html.DisplayNameFor(model => model.FinalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(425, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(493, 45, false);
#line 19 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderCost));

#line default
#line hidden
            EndContext();
            BeginContext(538, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(701, 62, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(764, 48, false);
#line 30 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(812, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(880, 45, false);
#line 33 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
               Write(Html.DisplayFor(modelItem => item.FinalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(925, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(993, 44, false);
#line 36 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderCost));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 39 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
                     if (!item.Active)
                    {
                        

#line default
#line hidden
            BeginContext(1172, 155, false);
#line 41 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
                   Write(Html.ActionLink(
                            "Усунений",
                            "","",
                            new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
#line 44 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
                                                            
                    }

#line default
#line hidden
            BeginContext(1352, 69, true);
            WriteLiteral("                </td>\r\n                <td></td>\r\n            </tr>\r\n");
            EndContext();
#line 49 "C:\Users\Vital\source\repos\CoffeShopRepo\CoffeShop\CoffeShop\Views\Raport\ProfitRaport_Partial.cshtml"
            }

#line default
#line hidden
            BeginContext(1436, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4082995ae612035a27c543b686a0308d1cc8852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_StartOrder), @"mvc.1.0.view", @"/Views/Orders/StartOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/StartOrder.cshtml", typeof(AspNetCore.Views_Orders_StartOrder))]
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
#line 1 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\_ViewImports.cshtml"
using TaxiStation_Core2_EFCore;

#line default
#line hidden
#line 2 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\_ViewImports.cshtml"
using TaxiStation_Core2_EFCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4082995ae612035a27c543b686a0308d1cc8852", @"/Views/Orders/StartOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d2d6596708268f266776e4faece84fcb83c282", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_StartOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestExample.DB.Orders>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
  
    ViewData["Title"] = "StartOrder";

#line default
#line hidden
            BeginContext(78, 204, true);
            WriteLiteral("\r\n<h1>StartOrder</h1>\r\n\r\n<div>\r\n    <h4>Orders</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Номер заказа:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(283, 34, false);
#line 17 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(317, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(378, 45, false);
#line 20 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.id_client));

#line default
#line hidden
            EndContext();
            BeginContext(423, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(485, 41, false);
#line 23 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.id_client));

#line default
#line hidden
            EndContext();
            BeginContext(526, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(587, 52, false);
#line 26 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.date_start_order));

#line default
#line hidden
            EndContext();
            BeginContext(639, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(701, 48, false);
#line 29 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.date_start_order));

#line default
#line hidden
            EndContext();
            BeginContext(749, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(810, 49, false);
#line 32 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.id_order_type));

#line default
#line hidden
            EndContext();
            BeginContext(859, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(921, 45, false);
#line 35 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.id_order_type));

#line default
#line hidden
            EndContext();
            BeginContext(966, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1027, 51, false);
#line 38 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.start_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1140, 47, false);
#line 41 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.start_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1248, 52, false);
#line 44 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.start_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1362, 48, false);
#line 47 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.start_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1471, 49, false);
#line 50 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.end_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1582, 45, false);
#line 53 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.end_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(1627, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1688, 50, false);
#line 56 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.end_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1800, 46, false);
#line 59 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.end_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(1846, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1907, 40, false);
#line 62 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.pets));

#line default
#line hidden
            EndContext();
            BeginContext(1947, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2009, 36, false);
#line 65 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.pets));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2106, 41, false);
#line 68 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.child));

#line default
#line hidden
            EndContext();
            BeginContext(2147, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2209, 37, false);
#line 71 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
       Write(Html.DisplayFor(model => model.child));

#line default
#line hidden
            EndContext();
            BeginContext(2246, 130, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <input type=\"button\" class=\"btn-block\" asp-action=\"EndOrder\" asp-controller=\"Order\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2376, "\"", 2400, 1);
#line 76 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\StartOrder.cshtml"
WriteAttributeValue("", 2391, Model.id, 2391, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2401, 38, true);
            WriteLiteral(" value=\"Завершить поезку\" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestExample.DB.Orders> Html { get; private set; }
    }
}
#pragma warning restore 1591
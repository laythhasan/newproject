#pragma checksum "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f79e81dd0ce3d5045af9ddcc329b1102eb726f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminB_Invistor), @"mvc.1.0.view", @"/Views/AdminB/Invistor.cshtml")]
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
#line 2 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\_ViewImports.cshtml"
using Bisnicity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f79e81dd0ce3d5045af9ddcc329b1102eb726f1", @"/Views/AdminB/Invistor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867b26f07787ce3ed897daa89fe895608c099590", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminB_Invistor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BisnicityApp.Entites.Invistor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
  
    ViewData["Title"] = "Invistor";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Invistor</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
           Write(Html.DisplayNameFor(model => model.Flag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
           Write(Html.DisplayNameFor(model => model.Targetsector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Targetsector.namesector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\Invistor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BisnicityApp.Entites.Invistor>> Html { get; private set; }
    }
}
#pragma warning restore 1591

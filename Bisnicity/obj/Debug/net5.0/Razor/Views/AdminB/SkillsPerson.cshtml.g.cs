#pragma checksum "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd5a6c2ad690bd26deef59a70bfeaeee45c8cef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminB_SkillsPerson), @"mvc.1.0.view", @"/Views/AdminB/SkillsPerson.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
using Infrastrucer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd5a6c2ad690bd26deef59a70bfeaeee45c8cef6", @"/Views/AdminB/SkillsPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867b26f07787ce3ed897daa89fe895608c099590", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminB_SkillsPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bisnicity.Models.InfoDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
  
    ViewData["Title"] = "SkillsPerson";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SkillsPerson</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                #\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayNameFor(model => model.SkillsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayNameFor(model => model.Courses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayNameFor(model => model.sFirstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayNameFor(model => model.sLastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayFor(modelItem => item.SkillsPersonID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayFor(modelItem => item.SkillsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayFor(modelItem => item.Courses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayFor(modelItem => item.sFirstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayFor(modelItem => item.sLastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 58 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
             if (sigin.IsSignedIn(User) && User.IsInRole(BisnicityKey.Admin))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=", 1769, "", 1850, 1);
#nullable restore
#line 61 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
WriteAttributeValue("", 1775, Url.Action("EditSkillsPerson", "AdminB", new { id = item.SkillsPersonID }), 1775, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge bg-success edithover\">Edit</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=", 1918, "", 1982, 1);
#nullable restore
#line 62 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
WriteAttributeValue("", 1924, Url.Action("", "AdminB",new { id = item.SkillsPersonID }), 1924, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge bg-danger deletehover\">Delete</a>\r\n                </td>\r\n");
#nullable restore
#line 64 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\AdminB\SkillsPerson.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> sigin { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bisnicity.Models.InfoDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "254519447951b726a30dc46a1af5a9ef45cc7ec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"254519447951b726a30dc46a1af5a9ef45cc7ec1", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867b26f07787ce3ed897daa89fe895608c099590", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!-- Start Footer  -->\r\n    <section class=\"container-fluid text-center mt-5\" style=\"background: #108D85\">\r\n        <br>\r\n        <a");
            BeginWriteAttribute("href", " href=", 140, "", 174, 1);
#nullable restore
#line 5 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 146, Url.Action("Index1","Home"), 146, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white !important; padding: 6px;\"><i class=\"fas fa-home\"></i> Home </a>\r\n        <a");
            BeginWriteAttribute("href", " href=", 271, "", 308, 1);
#nullable restore
#line 6 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 277, Url.Action("ContactUs","Home"), 277, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white !important; padding: 6px;\"><i class=\"fas fa-envelope-open\"></i> Contact </a>\r\n        <a");
            BeginWriteAttribute("href", " href=", 417, "", 452, 1);
#nullable restore
#line 7 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 423, Url.Action("AboutUs","Home"), 423, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""color: white !important; padding: 6px;""><i class=""fas fa-info-circle""></i> About Us </a>
        <hr id=""line"">
        <div class=""row"">
            <div class=""col-md-6"" id=""copyright"">© 2021 I  Busincity</div>
            <div class=""col-md-6"">
                <a");
            BeginWriteAttribute("href", " href=\"", 731, "\"", 738, 0);
            EndWriteAttribute();
            WriteLiteral("> <i id=\"links\" class=\"fab fa-facebook-f\"></i></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 809, "\"", 816, 0);
            EndWriteAttribute();
            WriteLiteral("><i id=\"links\" class=\"fab fa-twitter\"></i></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 883, "\"", 890, 0);
            EndWriteAttribute();
            WriteLiteral("><i id=\"links\" class=\"fab fa-youtube\"></i></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 957, "\"", 964, 0);
            EndWriteAttribute();
            WriteLiteral("><i id=\"links\" class=\"fab fa-linkedin-in\"></i></a>\r\n            </div>\r\n        </div>\r\n        <br>\r\n    </section>\r\n    <!-- End Footer -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
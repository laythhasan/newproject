#pragma checksum "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c818cdbe0485c34d8b20571b071f064bdfee8fcd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c818cdbe0485c34d8b20571b071f064bdfee8fcd", @"/Views/Shared/_Footer.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <footer class=\"bg-dark p-4 text-white text-center\" style=\"background-image: url(../assets/images/footer.png);\">\r\n        <div style=\"margin-bottom: 1%;\">\r\n            <a class=\"text-white\" style=\"text-decoration: none; padding: 1%;\"");
            BeginWriteAttribute("href", " href=", 240, "", 274, 1);
#nullable restore
#line 4 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 246, Url.Action("Index1","Home"), 246, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i class=\"fas fa-home\"></i>\r\n                Home\r\n            </a>\r\n            <a class=\"text-white\" style=\"text-decoration: none; padding: 1%;\"");
            BeginWriteAttribute("href", " href=", 439, "", 474, 1);
#nullable restore
#line 8 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 445, Url.Action("AboutUs","Home"), 445, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i class=\"fab fa-angular\"></i>\r\n                About\r\n            </a>\r\n            <a class=\"text-white\" style=\"text-decoration: none; padding: 1%;\"");
            BeginWriteAttribute("href", " href=", 643, "", 680, 1);
#nullable restore
#line 12 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 649, Url.Action("ContactUs","Home"), 649, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <i class=""far fa-address-book""></i> Contact
            </a>
        </div>
        <small>(c) 2021-2022 Written by BusinessCity</small>
        <div class=""icons"">
            <a href=""#"" target=""_blank"">
                <i class=""fab fa-whatsapp""></i>
            </a>
            <a href=""#"" target=""_blank"">
                <i class=""fab fa-instagram""></i>
            </a>
            <a href=""#"" target=""_blank"">
                <i class=""fab fa-facebook""></i>
            </a>
            <a href=""#"" target=""_blank"">
                <i class=""fab fa-linkedin""></i>
            </a>
        </div>
    </footer>
");
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

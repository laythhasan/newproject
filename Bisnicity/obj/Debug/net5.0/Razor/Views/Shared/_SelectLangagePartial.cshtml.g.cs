#pragma checksum "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a357dd21b9eaffb0d25bede83553855fba98c2bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SelectLangagePartial), @"mvc.1.0.view", @"/Views/Shared/_SelectLangagePartial.cshtml")]
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
#line 1 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a357dd21b9eaffb0d25bede83553855fba98c2bb", @"/Views/Shared/_SelectLangagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867b26f07787ce3ed897daa89fe895608c099590", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SelectLangagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetLanguage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 8 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
  
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();
    var returnurl = string.IsNullOrEmpty(Context.Request.Path) ? "~/" : $"~{Context.Request.Path.Value}{Context.Request.QueryString}";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("title", " title=\"", 517, "\"", 605, 2);
#nullable restore
#line 12 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
WriteAttributeValue("", 525, localizer["Request culture provider:"], 525, 39, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
WriteAttributeValue("", 564, requestCulture?.Provider?.GetType().Name, 564, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
      
        string sLang = requestCulture.RequestCulture.UICulture.Name;
        if (!string.IsNullOrEmpty(sLang))
        {
            string sSwtichLang = sLang == "en" ? "ar" : "en";

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a357dd21b9eaffb0d25bede83553855fba98c2bb7050", async() => {
                WriteLiteral("\r\n            <button class=\"btn btn-block\" type=\"submit\" style=\"color:black\">");
#nullable restore
#line 20 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
                                                                       Write(sSwtichLang);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span style=\"color: green;\">|</span></button>\r\n             \r\n\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-culture", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
                                                                                  WriteLiteral(sSwtichLang);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["culture"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-culture", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["culture"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
                                                                                                                     WriteLiteral(returnurl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\Elite\Desktop\New folder (18)\Bisnicitynew1\Bisnicity\Views\Shared\_SelectLangagePartial.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> locOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
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
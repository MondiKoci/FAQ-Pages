#pragma checksum "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3535e688e430e8ad03215b9844575ae5038a7744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\_ViewImports.cshtml"
using FAQPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\_ViewImports.cshtml"
using FAQPages.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3535e688e430e8ad03215b9844575ae5038a7744", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3f8a0033ce2a87a3dd867cdee920744282adf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FAQ>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
  
    ViewBag.Title = "FAQs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n");
#nullable restore
#line 8 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
         foreach (Topic t in ViewBag.Topics) 
        {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3535e688e430e8ad03215b9844575ae5038a77444201", async() => {
#nullable restore
#line 11 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
                                                          Write(t.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-topic", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
                                       WriteLiteral(t.TopicId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["topic"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-topic", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["topic"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n<div class=\"row\">\r\n\r\n    <div class=\"col\">\r\n        <ul>\r\n");
#nullable restore
#line 20 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
             foreach (Category c in ViewBag.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3535e688e430e8ad03215b9844575ae5038a77447419", async() => {
#nullable restore
#line 25 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
                                                           Write(c.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
                               WriteLiteral(c.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
                            WriteLiteral(ViewBag.SelectedTopic);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["topic"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-topic", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["topic"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>    \r\n");
#nullable restore
#line 27 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n\r\n    </div>\r\n\r\n    <div class=\"col\">\r\n        <ul>\r\n");
#nullable restore
#line 34 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
             foreach (FAQ faq in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        <b>");
#nullable restore
#line 39 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
                      Write(faq.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> ");
#nullable restore
#line 39 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
                                        Write(faq.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col\">Topic: ");
#nullable restore
#line 44 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
                                       Write(faq.Topic.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col\">Category: ");
#nullable restore
#line 45 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
                                          Write(faq.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n\r\n            </li>\r\n");
#nullable restore
#line 49 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\FAQPages\FAQPages\FAQPages\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        \r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FAQ>> Html { get; private set; }
    }
}
#pragma warning restore 1591

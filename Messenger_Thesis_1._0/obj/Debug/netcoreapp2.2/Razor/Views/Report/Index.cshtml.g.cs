#pragma checksum "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Report\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48ea3c036867a5e6a6ee8024be181c7ebac9438b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_Index), @"mvc.1.0.view", @"/Views/Report/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/Index.cshtml", typeof(AspNetCore.Views_Report_Index))]
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
#line 1 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\_ViewImports.cshtml"
using Messenger_Thesis_1._0;

#line default
#line hidden
#line 2 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\_ViewImports.cshtml"
using Messenger_Thesis_1._0.Data;

#line default
#line hidden
#line 3 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\_ViewImports.cshtml"
using Messenger_Thesis_1._0.Models;

#line default
#line hidden
#line 4 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\_ViewImports.cshtml"
using Messenger_Thesis_1._0.Data.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48ea3c036867a5e6a6ee8024be181c7ebac9438b", @"/Views/Report/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1613ad8cef49c5d71bf9b40e5516928b4fbff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Report\Index.cshtml"
  
    ViewData["Title"] = "Project";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(91, 239, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\nEnter your Name\r\n<input type=\"text\" id=\"txtName\" />\r\n<div>\r\n    <input type=\"checkbox\" id=\"check1\" checked=\"checked\" /> Open Document inside Browser\r\n</div>\r\n<input type=\"submit\" value=\"Generate PDF\" class=\"Button\" id=\"btn1\" />\r\n");
            EndContext();
            BeginContext(330, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ea3c036867a5e6a6ee8024be181c7ebac9438b4584", async() => {
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
            BeginContext(399, 995, true);
            WriteLiteral(@"
<script type=""text/javascript"">

    $('#btn1').click(function () {
        var checkbox1 = document.getElementById('check1');
        $.ajax({
            url: '/Report/ExportToPDF',
            type: ""POST"",
            data: {
                name : $(""#txtName"").val()
            },
            datatype: ""json"",
            success: function (data) {
                var fileName = JSON.parse(data);
                var fileUrl = ""/Output/"" + fileName['file'];
                if (checkbox1.checked) {
                    window.open(fileUrl);
                }
                else {
                    var a = document.createElement('a');
                    a.href = fileUrl;
                    a.download = fileName['file'];
                    document.body.appendChild(a);
                    a.click();
                    window.URL.revokeObjectURL(url);
                    a.remove();
                }
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "019f21c94a0711452c6d4c1eccf28f10cd41cbe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_Client), @"mvc.1.0.view", @"/Views/Feedback/Client.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedback/Client.cshtml", typeof(AspNetCore.Views_Feedback_Client))]
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
#line 1 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\_ViewImports.cshtml"
using Messenger_Thesis_1._0;

#line default
#line hidden
#line 2 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\_ViewImports.cshtml"
using Messenger_Thesis_1._0.Data;

#line default
#line hidden
#line 3 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\_ViewImports.cshtml"
using Messenger_Thesis_1._0.Models;

#line default
#line hidden
#line 4 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\_ViewImports.cshtml"
using Messenger_Thesis_1._0.Data.Model;

#line default
#line hidden
#line 2 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 4 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
using Messenger_Thesis_1._0.Data.Model.Interface;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"019f21c94a0711452c6d4c1eccf28f10cd41cbe4", @"/Views/Feedback/Client.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1613ad8cef49c5d71bf9b40e5516928b4fbff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_Client : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feedback>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("feedback_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/rate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
  

    Layout = "~/Views/Shared/_Admin.cshtml";
    ViewData["Title"] = "Feedbacks";

#line default
#line hidden
            BeginContext(298, 1114, true);
            WriteLiteral(@"

<style>
    .jq-stars {
        display: inline-block;
    }

    .jq-rating-label {
        font-size: 22px;
        display: inline-block;
        position: relative;
        vertical-align: top;
        font-family: helvetica, arial, verdana;
    }

    .jq-star {
        width: 100px;
        height: 100px;
        display: inline-block;
        cursor: pointer;
    }

    .jq-star-svg {
        padding-left: 3px;
        width: 100%;
        height: 100%;
    }

    .jq-star:hover .fs-star-svg path {
    }

    .jq-star-svg path {
        /* stroke: #000; */
        stroke-linejoin: round;
    }

    /* un-used */
    .jq-shadow {
        -webkit-filter: drop-shadow( -2px -2px 2px #888 );
        filter: drop-shadow( -2px -2px 2px #888 );
    }
</style>
<div class=""container-fluid mt--7"">
    <div class=""row"">
        <div class=""col"">
            <div style=""padding:1%;"" class=""card shadow"">
                <div class=""card-header border-0"">
             ");
            WriteLiteral("       <h3 class=\"mb-0\">Send a new feedback</h3>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(1412, 2717, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019f21c94a0711452c6d4c1eccf28f10cd41cbe46541", async() => {
                BeginContext(1437, 311, true);
                WriteLiteral(@"

                    <div id=""validation""></div>
                    <div class=""row"">
                     

                        <div class=""form-group mb-4 col-md-7"">
                            <label>Project ID </label>
                            <select class=""form-control"" id=""projectID"">
");
                EndContext();
#line 69 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                  
                                    var email = HttpContextAccessor.HttpContext.Session.GetString("Email").ToString();
                                    foreach (var m in ProjectRepository.GetAll().Where(a => a.Email == email).ToList())
                                    {
                                        string v = String.Format("{0:D6}", m.ProjectID);

#line default
#line hidden
                BeginContext(2154, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(2194, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019f21c94a0711452c6d4c1eccf28f10cd41cbe47946", async() => {
                    BeginContext(2224, 1, false);
#line 74 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                Write(v);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 74 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                           WriteLiteral(m.ProjectID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2234, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 75 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                    }
                                

#line default
#line hidden
                BeginContext(2310, 1812, true);
                WriteLiteral(@"                            </select>
                        </div>

                    

                        <div class=""form-group mb-4 col-md-6"">

                            <input placeholder=""Subject"" type=""text"" id=""subject"" class=""form-control"" />
                        </div>
                        <div class=""form-group mb-4 col-md-7"">


                            <textarea placeholder=""Message"" id=""message"" cols=""20"" rows=""15"" class=""form-control""></textarea>
                        </div>



                        <div class=""form-group col-md-12"">
                            <label>Quality of Service</label>
                            <br />
                            <span class=""first""></span>
                            <span class=""first-rating""></span>
                        </div>

                        <div class=""form-group col-md-12"">
                            <label>Promptness</label> <br />
                            <span class=""second""></sp");
                WriteLiteral(@"an>
                            <span class=""second-rating""></span>
                        </div>

                        <div class=""form-group col-md-12"">
                            <label>Employee Behavior</label> <br />
                            <span class=""third""></span>
                            <span class=""third-rating""></span>
                        </div>
                        <div class=""form-group col-md-12"">
                            <label>Responsiveness</label> <br />
                            <span class=""fourth""></span>
                            <span class=""fourth-rating""></span>
                        </div>



                    </div>

                    <input class=""btn btn-primary"" type=""submit"" />
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4129, 1030, true);
            WriteLiteral(@"


            </div>
        </div>
    </div>
</div>

<br />
<br />
<br />
<br />
<br />
<br />

<div class=""container-fluid mt--7"">
    <div class=""row"">
        <div class=""col"">
            <div style=""padding:1%;"" class=""card shadow"">
                <div class=""card-header border-0"">
                    <h3 class=""mb-0"">My Feedbacks</h3>
                </div>
                <div class=""table-responsive"">
                    <table id=""myTable"" class=""table align-items-center table-flush"">
                        <thead class=""thead-light"">
                            <tr>

                                <th scope=""col"">Subject</th>
                                <th scope=""col"">Message</th>
                                <th scope=""col"">Rate</th>
                                <th scope=""col"">Answer</th>
                                <th scope=""col"">Transaction #</th>
                            </tr>
                        </thead>
                        <tb");
            WriteLiteral("ody>\r\n");
            EndContext();
#line 158 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                              
                                foreach (var m in Model)
                                {

#line default
#line hidden
            BeginContext(5284, 128, true);
            WriteLiteral("                                                        <tr>\r\n\r\n                                                            <td>");
            EndContext();
            BeginContext(5413, 9, false);
#line 163 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                           Write(m.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(5422, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5494, 9, false);
#line 164 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                           Write(m.Message);

#line default
#line hidden
            EndContext();
            BeginContext(5503, 73, true);
            WriteLiteral("</td>\r\n                                                            <td>\r\n");
            EndContext();
#line 166 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                  
                                                                    if (MathF.Round(m.Overall) == 5)
                                                                    {

#line default
#line hidden
            BeginContext(5817, 85, true);
            WriteLiteral("                                                                        <span>⭐⭐⭐⭐⭐ (");
            EndContext();
            BeginContext(5903, 9, false);
#line 169 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                                Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(5912, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 170 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                    }
                                                                    else if (MathF.Round(m.Overall) == 4)
                                                                    {

#line default
#line hidden
            BeginContext(6171, 84, true);
            WriteLiteral("                                                                        <span>⭐⭐⭐⭐ (");
            EndContext();
            BeginContext(6256, 9, false);
#line 173 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                               Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(6265, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 174 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                    }
                                                                    else if (MathF.Round(m.Overall) == 3)
                                                                    {

#line default
#line hidden
            BeginContext(6524, 83, true);
            WriteLiteral("                                                                        <span>⭐⭐⭐ (");
            EndContext();
            BeginContext(6608, 9, false);
#line 177 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                              Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(6617, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 178 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                    }
                                                                    else if (MathF.Round(m.Overall) == 2)
                                                                    {

#line default
#line hidden
            BeginContext(6876, 82, true);
            WriteLiteral("                                                                        <span>⭐⭐ (");
            EndContext();
            BeginContext(6959, 9, false);
#line 181 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                             Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(6968, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 182 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                    }
                                                                    else if (MathF.Round(m.Overall) == 1)
                                                                    {

#line default
#line hidden
            BeginContext(7227, 80, true);
            WriteLiteral("                                                                        <span>⭐(");
            EndContext();
            BeginContext(7308, 9, false);
#line 185 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                           Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(7317, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 186 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                                    }
                                                                

#line default
#line hidden
            BeginContext(7465, 137, true);
            WriteLiteral("\r\n\r\n                                                            </td>\r\n\r\n                                                            <td>");
            EndContext();
            BeginContext(7603, 9, false);
#line 192 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                           Write(m.Respond);

#line default
#line hidden
            EndContext();
            BeginContext(7612, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 193 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                              string v = String.Format("{0:D6}", m.ProjectID); 
                                                            

#line default
#line hidden
            BeginContext(7795, 64, true);
            WriteLiteral("                                                            <td>");
            EndContext();
            BeginContext(7860, 1, false);
#line 195 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                                           Write(v);

#line default
#line hidden
            EndContext();
            BeginContext(7861, 70, true);
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 197 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Feedback\Client.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(7997, 3268, true);
            WriteLiteral(@"



                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>


<script>



    $(document).ready(function () {



        var table = $('#myTable').DataTable({

            ""columnDefs"": [
                { ""width"": ""15%"", ""targets"": 0 },
                { ""width"": ""30%"", ""targets"": 3 },
                { ""width"": ""15%"", ""targets"": 2 }
            ],
            responsive: true,
            dom: 'lBfrtip',
            buttons: [
                {
                    extend: 'print',

                    customize: function (win) {
                        $(win.document.body)
                            .css({ 'font-size': '10pt' })
                            .prepend(
                                '<img style= src=""~/logo.png""  style=""position:absolute; height:500px; z-index:5000; width:500px; top:0; left:0;"" />'
                            );
                    }
                }
  ");
            WriteLiteral(@"          ],
            drawCallback: function () {

                var next = $(""#myTable_next > a"");
                next.text('>');

                var ss = $(""#myTable_previous > a"");
                ss.text('<');
            }

        });
        $('.custom-select').removeClass(""custom-select"");
    });



</script>














<script>

    $(""#feedback_form"").submit(function (e) {

        e.preventDefault();

        var rating = 2;
        var subject = $('#subject').val();
        var message = $('#message').val();
         var projectID = $('#projectID').val();
        if (rating == undefined || subject == """" || message == """") {
            $('#validation').html('<div class=""alert alert-warning""><strong>Warning!</strong> Please complete the fields below</div>');
            return false;
        } else {
            $('#validation').html("""");
        }



        var feedbackModel = new FormData();

        feedbackModel.append(""Rating"", rat");
            WriteLiteral(@"ing);
        feedbackModel.append(""Subject"", subject);
        feedbackModel.append(""Message"", message);
         feedbackModel.append(""ProjectID"", projectID);
        feedbackModel.append(""Behaviour"", $('.third-rating').text());
        feedbackModel.append(""Promptness"", $('.second-rating').text());
        feedbackModel.append(""Quality"", $('.first-rating').text());
        feedbackModel.append(""Responsiveness"", $('.fourth-rating').text());

        var sender = new XMLHttpRequest();
        sender.open(""POST"", ""/Feedback/MemberFeedback"");
        sender.send(feedbackModel);
        sender.onreadystatechange = function () {
            if (sender.readyState == 4 && sender.status == 200) {
                $("".first"").starRating('setRating', 0);
                $("".second"").starRating('setRating', 0);
                $("".third"").starRating('setRating', 0);
                $("".fourth"").starRating('setRating', 0);

                $('#subject').val("""");
                $('#message').val("""");");
            WriteLiteral("\r\n                $(\'#validation\').html(\'<div class=\"alert alert-success\"><strong>Success</strong> Your feedback has been submitted</div>\');\r\n            }\r\n        }\r\n\r\n\r\n\r\n    });\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(11265, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019f21c94a0711452c6d4c1eccf28f10cd41cbe426601", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11298, 1465, true);
            WriteLiteral(@"
<script>

    $("".first"").starRating({
        initialRating: 0,
        disableAfterRate: false,
        onHover: function (currentIndex, currentRating, $el) {
            $('.first-rating').text(currentIndex);
        },
        onLeave: function (currentIndex, currentRating, $el) {
            $('.first-rating').text(currentRating);
        }
    });

    $("".second"").starRating({
        initialRating: 0,
        disableAfterRate: false,
        onHover: function (currentIndex, currentRating, $el) {
            $('.second-rating').text(currentIndex);
        },
        onLeave: function (currentIndex, currentRating, $el) {
            $('.second-rating').text(currentRating);
        }
    });

    $("".third"").starRating({
        initialRating: 0,
        disableAfterRate: false,
        onHover: function (currentIndex, currentRating, $el) {
            $('.third-rating').text(currentIndex);
        },
        onLeave: function (currentIndex, currentRating, $el) {
        ");
            WriteLiteral(@"    $('.third-rating').text(currentRating);
        }
    });

    $("".fourth"").starRating({
        initialRating: 0,
        disableAfterRate: false,
        onHover: function (currentIndex, currentRating, $el) {
            $('.fourth-rating').text(currentIndex);
        },
        onLeave: function (currentIndex, currentRating, $el) {
            $('.fourth-rating').text(currentRating);
        }
    });

</script>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProjectRepository ProjectRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de62d7652fb566893c5865bfbb1058057b555b30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_Admin), @"mvc.1.0.view", @"/Views/Feedback/Admin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedback/Admin.cshtml", typeof(AspNetCore.Views_Feedback_Admin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de62d7652fb566893c5865bfbb1058057b555b30", @"/Views/Feedback/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1613ad8cef49c5d71bf9b40e5516928b4fbff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feedback>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
  
ViewData["Title"] = "Admin";
Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(102, 2196, true);
            WriteLiteral(@"
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Response to client</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">

                    <input id=""feedbackID"" type=""hidden""/>
                  <textarea id=""adminResponse"" class=""form-control""></textarea>
                    
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" id=""adminSendResponse""");
            WriteLiteral(@" class=""btn btn-primary"">Send</button>
                </div>
            </div>
        </div>
    </div>
    

    <div class=""container-fluid mt--7"">
        <div class=""row"">
            <div class=""col"">
                <div style=""padding:1%;"" class=""card shadow"">
                    <div class=""card-header border-0"">
                        <h3 class=""mb-0"">Feedbacks</h3>
                    </div>
                    <div class=""table-responsive"">
                        <table id=""myTable"" class=""table align-items-center table-flush"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th scope=""col"">Email</th>
                                    <th scope=""col"">Subject</th>
                                    <th scope=""col"">Message</th>
                                    <th scope=""col"">Rate</th>
                                    <th scope=""col"">Action</th>
                                    <th");
            WriteLiteral(" scope=\"col\">Transaction # </th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                  
                                foreach(var m in Model){

#line default
#line hidden
            BeginContext(2392, 142, true);
            WriteLiteral("                                                                <tr>\r\n                                                                    <td>");
            EndContext();
            BeginContext(2535, 6, false);
#line 54 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                   Write(m.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2541, 79, true);
            WriteLiteral("</td>\r\n                                                                    <td>");
            EndContext();
            BeginContext(2621, 9, false);
#line 55 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                   Write(m.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(2630, 79, true);
            WriteLiteral("</td>\r\n                                                                    <td>");
            EndContext();
            BeginContext(2710, 9, false);
#line 56 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                   Write(m.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2719, 81, true);
            WriteLiteral("</td>\r\n                                                                    <td>\r\n");
            EndContext();
#line 58 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                          
                                                                            if (MathF.Round(m.Overall) == 5)
                                                                            {

#line default
#line hidden
            BeginContext(3065, 93, true);
            WriteLiteral("                                                                                <span>⭐⭐⭐⭐⭐ (");
            EndContext();
            BeginContext(3159, 9, false);
#line 61 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                                        Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(3168, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 62 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                            }
                                                                            else if (MathF.Round(m.Overall) == 4)
                                                                            {

#line default
#line hidden
            BeginContext(3451, 92, true);
            WriteLiteral("                                                                                <span>⭐⭐⭐⭐ (");
            EndContext();
            BeginContext(3544, 9, false);
#line 65 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                                       Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(3553, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 66 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                            }
                                                                            else if (MathF.Round(m.Overall) == 3)
                                                                            {

#line default
#line hidden
            BeginContext(3836, 91, true);
            WriteLiteral("                                                                                <span>⭐⭐⭐ (");
            EndContext();
            BeginContext(3928, 9, false);
#line 69 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                                      Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(3937, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 70 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                            }
                                                                            else if (MathF.Round(m.Overall) == 2)
                                                                            {

#line default
#line hidden
            BeginContext(4220, 90, true);
            WriteLiteral("                                                                                <span>⭐⭐ (");
            EndContext();
            BeginContext(4311, 9, false);
#line 73 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                                     Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(4320, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 74 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                            }
                                                                            else if (MathF.Round(m.Overall) == 1)
                                                                            {

#line default
#line hidden
            BeginContext(4603, 88, true);
            WriteLiteral("                                                                                <span>⭐(");
            EndContext();
            BeginContext(4692, 9, false);
#line 77 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                                   Write(m.Overall);

#line default
#line hidden
            EndContext();
            BeginContext(4701, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 78 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                            }
                                                                        

#line default
#line hidden
            BeginContext(4865, 155, true);
            WriteLiteral("\r\n\r\n                                                                    </td>\r\n\r\n                                                                    <td>\r\n");
            EndContext();
#line 85 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                          
                                                                            if (m.Respond == null)
                                                                            {

#line default
#line hidden
            BeginContext(5275, 87, true);
            WriteLiteral("                                                                                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5362, "\"", 5394, 3);
            WriteAttributeValue("", 5372, "Respond(", 5372, 8, true);
#line 88 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
WriteAttributeValue("", 5380, m.FeedbackID, 5380, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5393, ")", 5393, 1, true);
            EndWriteAttribute();
            BeginContext(5395, 273, true);
            WriteLiteral(@" type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                                                                                    Respond
                                                                                </button>
");
            EndContext();
#line 91 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                            }

                                                                        

#line default
#line hidden
            BeginContext(5824, 144, true);
            WriteLiteral("\r\n                                                                    </td>\r\n                                                                 \r\n");
            EndContext();
#line 97 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                      string v = String.Format("{0:D6}", m.ProjectID);
                                                                    

#line default
#line hidden
            BeginContext(6159, 72, true);
            WriteLiteral("                                                                    <td>");
            EndContext();
            BeginContext(6232, 1, false);
#line 99 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                                                   Write(v);

#line default
#line hidden
            EndContext();
            BeginContext(6233, 78, true);
            WriteLiteral("</td>\r\n                                                                </tr>\r\n");
            EndContext();
#line 101 "C:\Users\Adrian Radores\Desktop\messenger2\Messenger_Thesis_1._0\Views\Feedback\Admin.cshtml"
                                }
                                

#line default
#line hidden
            BeginContext(6381, 2154, true);
            WriteLiteral(@"
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <script>

        $('#adminSendResponse').click(function () {

            var id = $('#feedbackID').val();
            var message = $('#adminResponse').val();
           
            $.ajax({

                url: '../Feedback/AdminResponse',
                type: 'POST',
                data: {id:id,message:message},
                success: function (e) {

                    alert(""Success"");
                    window.open(""../Feedback/Admin"",""_self"");
                }

            });
            return false;
        });

        function Respond(feedID) {
            $('#feedbackID').val(feedID);
        }

        $(document).ready(function () {



            var table = $('#myTable').DataTable({
          ""columnDefs"": [
                    { ""width"": ""15%"", ""targets"": 0 },
           ");
            WriteLiteral(@"         { ""width"": ""7%"", ""targets"": 3 },
                     { ""width"": ""7%"", ""targets"": 4 },
                  { ""width"": ""15%"", ""targets"": 1 }
  ],
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
                ],
                drawCallback: function () {

                    var next = $(""#myTable_next > a"");
                    next.text('>');

                    var ss = $(""#myTable_previous > a"");
                    ss.text('<');
                }

            })");
            WriteLiteral(";\r\n            $(\'.custom-select\').removeClass(\"custom-select\");\r\n        });\r\n\r\n\r\n\r\n    </script>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591
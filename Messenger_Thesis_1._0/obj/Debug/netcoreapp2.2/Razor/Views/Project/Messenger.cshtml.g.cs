#pragma checksum "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e6aa9cef00f4dc80bd7e046645813f6329a5725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Messenger), @"mvc.1.0.view", @"/Views/Project/Messenger.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Messenger.cshtml", typeof(AspNetCore.Views_Project_Messenger))]
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
#line 3 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
using Messenger_Thesis_1._0.Data.Model.Interface;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6aa9cef00f4dc80bd7e046645813f6329a5725", @"/Views/Project/Messenger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1613ad8cef49c5d71bf9b40e5516928b4fbff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Messenger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReadExcelFileAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
  
    ViewData["Title"] = "Project";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(252, 709, true);
            WriteLiteral(@"


    <div class=""modal fade"" id=""modal-form"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modal-form"" aria-hidden=""true"">
        <div class=""modal-dialog modal- modal-dialog-centered modal-lg"" role=""document"">


            <div class=""modal-content"">
                <div id=""RegistrationForm"">
                    <div class=""modal-body p-0"">


                        <div class=""card bg-secondary shadow border-0"">
                            <div class=""card-header bg-white pb-3"">

                                <div class=""btn-wrapper text-center"">
                                    <h3>List Of SOA</h3>

                                </div>
                                ");
            EndContext();
            BeginContext(961, 284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e6aa9cef00f4dc80bd7e046645813f6329a57256993", async() => {
                BeginContext(1012, 226, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\" id=\"projectId\" name=\"id\" />\r\n                                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Show Invoice\" />\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1245, 141, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"card-body px-lg-5 py-lg-3\">\r\n\r\n                                ");
            EndContext();
            BeginContext(1386, 1054, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e6aa9cef00f4dc80bd7e046645813f6329a57259238", async() => {
                BeginContext(1490, 943, true);
                WriteLiteral(@"



                                    <div class=""table-responsive"">
                                        <table id=""soaTable"" class=""table align-items-center table-flush"">
                                            <thead class=""thead-light"">
                                                <tr>
                                                    <th scope=""col"">Receiver Name</th>
                                                    <th scope=""col"">Location</th>
                                                </tr>
                                            </thead>
                                            <tbody class=""letterData"">
                                            </tbody>
                                        </table>
                                    </div>




                                    <br />
                                    <br />


                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2440, 1412, true);
            WriteLiteral(@"
                            </div>
                        </div>



                    </div>

                </div>



            </div>
        </div>
    </div>



<div class=""container-fluid mt--7"">
    <!-- Table -->
    <div class=""row"">
        <div class=""col"">
            <div class=""card shadow"">
                <br />
                <div class=""col-md-3"">

                </div>
                <div class=""card-header border-0"">
                    <h3 class=""mb-0"">Projects</h3>
                </div>
                <div style=""padding:2%;"" class=""table-responsive"">
                    <table id=""projectTable"" class=""table align-items-center table-flush"">
                        <thead class=""thead-light"">
                            <tr>
                                <th scope=""col"">Project ID</th>
                                <th scope=""col"">ProjectName</th>

                                <th scope=""col"">Quantity</th>
                           ");
            WriteLiteral(@"     <th scope=""col"">Type  </th>
                                <th scope=""col"">Status  </th>

                                <th scope=""col"">Date  </th>
                                <th scope=""col"">Action  </th>
                                <th scope=""col"">View  </th>
                            </tr>
                        </thead>
                        <tbody>

");
            EndContext();
#line 108 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                              
                                foreach (var project in Model)
                                {

#line default
#line hidden
            BeginContext(3983, 192, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>\r\n                                                                ");
            EndContext();
            BeginContext(4176, 17, false);
#line 113 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                           Write(project.ProjectID);

#line default
#line hidden
            EndContext();
            BeginContext(4193, 199, true);
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
            EndContext();
            BeginContext(4393, 19, false);
#line 116 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                           Write(project.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(4412, 201, true);
            WriteLiteral("\r\n                                                            </td>\r\n\r\n                                                            <td>\r\n                                                                ");
            EndContext();
            BeginContext(4614, 16, false);
#line 120 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                           Write(project.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(4630, 201, true);
            WriteLiteral("\r\n                                                            </td>\r\n\r\n                                                            <td>\r\n                                                                ");
            EndContext();
            BeginContext(4832, 18, false);
#line 124 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                           Write(project.TypeOfTask);

#line default
#line hidden
            EndContext();
            BeginContext(4850, 201, true);
            WriteLiteral("\r\n                                                            </td>\r\n\r\n                                                            <td>\r\n                                                                ");
            EndContext();
            BeginContext(5052, 14, false);
#line 128 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                           Write(project.Status);

#line default
#line hidden
            EndContext();
            BeginContext(5066, 199, true);
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
            EndContext();
            BeginContext(5266, 44, false);
#line 131 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                           Write(project.CurrentDateStart.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(5310, 135, true);
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n");
            EndContext();
#line 134 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                                  
                                                                    if (project.Status == "On-going" && project.TypeOfTask == "Pick-up")
                                                                    {

#line default
#line hidden
            BeginContext(5722, 93, true);
            WriteLiteral("                                                                        <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5815, "\"", 5849, 3);
            WriteAttributeValue("", 5825, "Done(", 5825, 5, true);
#line 137 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
WriteAttributeValue("", 5830, project.ProjectID, 5830, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 5848, ")", 5848, 1, true);
            EndWriteAttribute();
            BeginContext(5850, 38, true);
            WriteLiteral(" class=\"btn btn-block\">Done</button>\r\n");
            EndContext();
#line 138 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                                    }

                                                                    if (project.Status == "On-going" && project.TypeOfTask == "Delivery")
                                                                    {

#line default
#line hidden
            BeginContext(6171, 93, true);
            WriteLiteral("                                                                        <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6264, "\"", 6306, 3);
            WriteAttributeValue("", 6274, "DoneDelivery(", 6274, 13, true);
#line 142 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
WriteAttributeValue("", 6287, project.ProjectID, 6287, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 6305, ")", 6305, 1, true);
            EndWriteAttribute();
            BeginContext(6307, 38, true);
            WriteLiteral(" class=\"btn btn-block\">Done</button>\r\n");
            EndContext();
#line 143 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                                    }

                                                                

#line default
#line hidden
            BeginContext(6485, 141, true);
            WriteLiteral("\r\n\r\n                                                            </td>\r\n\r\n                                                            <td>\r\n\r\n");
            EndContext();
#line 152 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                                  

                                                                    if (project.TypeOfTask == "Delivery")
                                                                    {

#line default
#line hidden
            BeginContext(6874, 125, true);
            WriteLiteral("                                                                        <button data-toggle=\"modal\" data-target=\"#modal-form\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6999, "\"", 7046, 3);
            WriteAttributeValue("", 7009, "GetLetterDelivery(", 7009, 18, true);
#line 156 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
WriteAttributeValue("", 7027, project.ProjectID, 7027, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 7045, ")", 7045, 1, true);
            EndWriteAttribute();
            BeginContext(7047, 40, true);
            WriteLiteral(" class=\"btn btn-primary\">View</button>\r\n");
            EndContext();
#line 157 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                                    }
                                                                    else
                                                                    {

#line default
#line hidden
            BeginContext(7303, 125, true);
            WriteLiteral("                                                                        <button data-toggle=\"modal\" data-target=\"#modal-form\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 7428, "\"", 7467, 3);
            WriteAttributeValue("", 7438, "GetClient(", 7438, 10, true);
#line 160 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
WriteAttributeValue("", 7448, project.ProjectID, 7448, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 7466, ")", 7466, 1, true);
            EndWriteAttribute();
            BeginContext(7468, 40, true);
            WriteLiteral(" class=\"btn btn-primary\">View</button>\r\n");
            EndContext();
#line 161 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"
                                                                    }
                                                                

#line default
#line hidden
            BeginContext(7646, 134, true);
            WriteLiteral("\r\n                                                            </td>\r\n\r\n                                                        </tr>\r\n");
            EndContext();
#line 167 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Project\Messenger.cshtml"

                                }

                            

#line default
#line hidden
            BeginContext(7850, 3474, true);
            WriteLiteral(@"


                        </tbody>
                    </table>
                </div>

            </div>
        </div>
    </div>
    <!-- Dark table -->


</div>



<script>

    

    function GetClient(id) {
        var table = $('#soaTable').DataTable();
     
        $('#projectId').val(id);
        $('.letterData').html('');

           table.clear().draw();
        $.ajax({

            url: '/Project/GetLetterProject',
            type: 'GET',
            data: { id: id },
            success: function (e) {

                for (var key of Object.keys(e)) {

                    table.row.add([ 

                        e[key].receiverName, e[key].locationOfDelivery
                        ]
                    ).draw();


                }


            }

        });
    }



     function GetLetterDelivery(id) {
        var table = $('#soaTable').DataTable();
        
        $('#projectId').val(id);
         $('.letterData').html('');
");
            WriteLiteral(@"            table.clear().draw();
        $.ajax({

            url: '/Project/GetLetterDelivery',
            type: 'GET',
            data: { id: id },
            success: function (e) {

                for (var key of Object.keys(e)) {

                    table.row.add([ 

                        e[key].receiverName, e[key].locationOfDelivery
                        ]
                    ).draw();

                }


            }

        });
    }






    $(document).ready(function () {
        var table = $('#projectTable').DataTable({

            order: [[0, ""desc""]],
            dom: 'lBfrtip',
            buttons: [
                {
                    extend: 'print',

                    customize: function (win) {
                        $(win.document.body)
                            .css({ 'font-size': '10pt' })
                            .prepend('<img style= src=""~/logo.png"" style=""position:absolute; height:500px; z-index:5000; width:500px; to");
            WriteLiteral(@"p:0; left:0;"" />'
                            );
                    }
                }
            ],
            drawCallback: function () {

                var next = $(""#projectTable_next > a"");
                next.text('>');

                var ss = $(""#projectTable_previous > a"");
                ss.text('<');
            }

        });
        $('.custom-select').removeClass(""custom-select"");
    });



    function Done(id) {

        var conf = confirm(""are you sure?"");

        if (conf) {

        $.ajax({

            url: '../Project/FinishedPickup',
            type: 'POST',
            data: {id : id},
            success: function (e) {
               Swal.fire(
                        'Good job!',
                        'Pickup Completed!',
                        'success'
                    );
            }

        });
            }
    }

     function DoneDelivery(id) {

        var conf = confirm(""are you sure?"");

        if (conf) {");
            WriteLiteral(@"

        $.ajax({

            url: '../Project/FinishedDelivery',
            type: 'POST',
            data: {id : id},
            success: function (e) {
               Swal.fire(
                        'Good job!',
                        'Delivery Completed!',
                        'success'
                    );
            }

        });
            }
    }

</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserRepository UserRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IContractRepository ContractRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591

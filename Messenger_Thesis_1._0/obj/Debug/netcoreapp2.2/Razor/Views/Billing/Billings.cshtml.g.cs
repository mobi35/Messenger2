#pragma checksum "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77e26f6f4245c578f69854d4bcfcb47bfde8f7be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Billing_Billings), @"mvc.1.0.view", @"/Views/Billing/Billings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Billing/Billings.cshtml", typeof(AspNetCore.Views_Billing_Billings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e26f6f4245c578f69854d4bcfcb47bfde8f7be", @"/Views/Billing/Billings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1613ad8cef49c5d71bf9b40e5516928b4fbff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Billing_Billings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("billingForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
  
    ViewData["Title"] = "Billings";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(112, 1310, true);
            WriteLiteral(@"



<div class=""container-fluid mt--7"">




    <!-- Table -->
    <div class=""row"">
        <div class=""col"">

            <div class=""card shadow"">
                <div class=""card-header border-0"">
                    <div class=""col-md-3"">

                        <div class=""modal fade"" id=""modal-form"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modal-form"" aria-hidden=""true"">
                            <div class=""modal-dialog modal- modal-dialog-centered modal-sm"" role=""document"">

                                <div class=""modal-content"">

                                    <div>
                                        <div class=""modal-body p-0"">

                                            <div class=""card bg-secondary shadow border-0"">
                                                <div class=""card-header bg-white pb-3"">

                                                    <div class=""btn-wrapper text-center"">
                                                       ");
            WriteLiteral(@" <h3>Confirm Billing</h3>
                                                    </div>
                                                </div>
                                                <div class=""card-body px-lg-5 py-lg-3"">

                                                    ");
            EndContext();
            BeginContext(1422, 1576, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77e26f6f4245c578f69854d4bcfcb47bfde8f7be6640", async() => {
                BeginContext(1457, 1534, true);
                WriteLiteral(@"

                                                        <input type=""hidden"" id=""project-id"" />


                                                        <div class=""text-center text-muted mb-4"">
                                                            <small>Deposit Slip</small>
                                                        </div>



                                                        <div id=""deposit-image"" class=""text-center"">

                                                        </div>
                                                        <br />

                                                        <div style=""margin-left:3%;"" class=""form-group mb-6"">
                                                            <div class=""input-group input-group-alternative"">

                                                                <input id=""price"" class=""form-control"" disabled type=""text"">

                                                            </div>

     ");
                WriteLiteral(@"                                                   </div>

                                                        <div class=""text-center"">
                                                            <a href=""#"" data-dismiss=""modal"" onclick=""Accept()"">Accept</a>
                                                            <a href=""#"" data-dismiss=""modal"" onclick=""Decline()"">Decline</a>
                                                        </div>
                                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2998, 1153, true);
            WriteLiteral(@"
                                                </div>
                                            </div>



                                        </div>

                                    </div>



                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            
                <div style=""padding:1%;"" class=""table-responsive"">
                    <h3>Billings</h3>
                    <table id=""billingTable"" class=""table align-items-center table-flush"">
                        <thead class=""thead-light"">
                            <tr>
                                <th scope=""col"">ID</th>
                                <th scope=""col"">Company Name</th>
                                <th scope=""col"">Quantity</th>
                                <th scope=""col"">Price</th>
                                <th scope=""col"">Status</th>

                                <th ");
            WriteLiteral("scope=\"col\">Action</th>\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 104 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
                              
                                foreach (var m in Model)
                                {

#line default
#line hidden
            BeginContext(4276, 126, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
            EndContext();
            BeginContext(4403, 11, false);
#line 108 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
                                                           Write(m.ProjectID);

#line default
#line hidden
            EndContext();
            BeginContext(4414, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(4486, 13, false);
#line 109 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
                                                           Write(m.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(4499, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(4571, 10, false);
#line 110 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
                                                           Write(m.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(4581, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(4653, 7, false);
#line 111 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
                                                           Write(m.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4660, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(4732, 8, false);
#line 112 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
                                                           Write(m.Status);

#line default
#line hidden
            EndContext();
            BeginContext(4740, 73, true);
            WriteLiteral("</td>\r\n                                                            <td>\r\n");
            EndContext();
#line 114 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
                                                                  
                                                                    if (m.ImageName != null)
                                                                    {

#line default
#line hidden
            BeginContext(5046, 161, true);
            WriteLiteral("                                                                        <button type=\"button\" class=\"btn btn-block\" data-toggle=\"modal\" data-target=\"#modal-form\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5207, "\"", 5284, 9);
            WriteAttributeValue("", 5217, "AddUserClick();", 5217, 15, true);
            WriteAttributeValue(" ", 5232, "GetBilling(", 5233, 12, true);
#line 117 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
WriteAttributeValue("", 5244, m.ProjectID, 5244, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 5256, ",\'", 5256, 2, true);
#line 117 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
WriteAttributeValue("", 5258, m.ImageName, 5258, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 5270, "\'", 5270, 1, true);
            WriteAttributeValue(" ", 5271, ",\'", 5272, 3, true);
#line 117 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
WriteAttributeValue("", 5274, m.Price, 5274, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 5282, "\')", 5282, 2, true);
            EndWriteAttribute();
            BeginContext(5285, 24, true);
            WriteLiteral(">Show Deposit</button>\r\n");
            EndContext();
#line 118 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"

                                                                    }
                                                                

#line default
#line hidden
            BeginContext(5449, 134, true);
            WriteLiteral("\r\n                                                            </td>\r\n\r\n                                                        </tr>\r\n");
            EndContext();
#line 125 "C:\Users\Adrian Radores\Desktop\fking\messenger2\Messenger_Thesis_1._0\Views\Billing\Billings.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(5649, 146, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(5795, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77e26f6f4245c578f69854d4bcfcb47bfde8f7be16850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5864, 8971, true);
            WriteLiteral(@"





<script>
    $(document).ready(function () {
        var table = $('#billingTable').DataTable({

      order : [[ 0, ""desc"" ]],
            dom: 'lBfrtip',
            buttons: [
                {
                    extend: 'print',

                    customize: function (win) {
                        $(win.document.body)
                            .css({ 'font-size': '10pt' })
                            .prepend('<img style= src=""~/logo.png"" style=""position:absolute; height:500px; z-index:5000; width:500px; top:0; left:0;"" />'
                            );
                    }
                }
            ],
            drawCallback: function () {

                var next = $(""#billingTable_next > a"");
                next.text('>');

                var ss = $(""#billingTable_previous > a"");
                ss.text('<');
            }

        });
        $('.custom-select').removeClass(""custom-select"");
    });


</script>






<script>




");
            WriteLiteral(@"
    document.getElementById('billingForm').onsubmit = function () {



        var formdata = new FormData();

        var projectName = $('#project-name').val();
        var projectQuantity = $('#project-quantity').val();




        formdata.append(""ProjectName"", projectName);
        formdata.append(""Quantity"", projectQuantity);


        $('#submit').disabled = true;
        var xhr = new XMLHttpRequest();
        xhr.open('POST', '/Project/SendNewDelivery');
        xhr.send(formdata);



        xhr.onreadystatechange = function () {


            if (xhr.readyState == 4 && xhr.status == 200) {

                if (xhr.responseText.split(',').includes(""no_zero_quantity"")) {
                    $('#parent-project-quantity').addClass('has-danger');
                    $('.project-quantity-validation').html(""Please input quantity"");
                } else if (xhr.responseText.split(',').includes(""invalid_quantity"")) {
                    $('#parent-project-quantity').addCl");
            WriteLiteral(@"ass('has-danger');
                    $('.project-quantity-validation').html(""Number only."");
                } else {
                    $('#parent-project-quantity').addClass(""has-success"");
                    $('#parent-project-quantity').removeClass(""has-danger"");
                    $('.project-quantity-validation').html("""");
                }

                if (xhr.responseText.split(',').includes(""project_name_required"")) {
                    $('#parent-project-name').addClass('has-danger');
                    $('.project-name-validation').html(""Please write your first name"");
                } else {
                    $('#parent-project-name').removeClass(""has-danger"");
                    $('#parent-project-name').addClass(""has-success"");
                    $('.project-name-validation').html("""");
                }



                if (xhr.responseText == """") {
                    $('#RegistrationForm').hide();
                    Swal.fire(
                        'G");
            WriteLiteral(@"ood job!',
                        'You clicked the button!',
                        'success'
                    );
                    $('#submit').disabled = false;
                    GetAllUser();
                }

            }
        }

        return false;
    }

    function AddUserClick() {
        $('#RegistrationForm').show();
    }


    

    function GetUser(id) {

        $.ajax({

            url: '/User/GetUserDetails',
            type: 'POST',
            data: { id: id },
            success: function (e) {


                $('#update_first-name').val(e.firstName);
                $('#update_last-name').val(e.lastName);
                $('#userId').val(id);
                $('#update_role').val(e.role);


            }

        });
    }


    $('#update-submit-admin').click(function () {

        var fileInput = document.getElementById('update_fileInput_admin').file;

        var password = $('#update_password_admin').val();
        v");
            WriteLiteral(@"ar cpassword = $('#update_cpassword_admin').val();
        var firstName = $('#update_first-name_admin').val();
        var lastName = $('#update_last-name_admin').val();
        var role = $('#update_role_admin').val();
        var userId = $('#userId_admin').val();
        $.ajax({

            url: '/User/UpdateData',
            type: 'POST',
            data: { userId: userId, password: password, cpassword: cpassword, firstName: firstName, lastName: lastName, role: role, fileInput: fileInput },
            success: function (e) {
                if (e == ""password_not_match"") {
                    $('#update_parentPassword_admin').addClass('has-danger');
                    $('#update_parentCPassword_admin').addClass('has-danger');
                    $('.update_passwordValidation_admin').html(""Please input your password"");
                }

                if (e == ""firstname_required"") {
                    $('#update_parentFirstName_admin').addClass('has-danger');
                 ");
            WriteLiteral(@"   $('.update_firstNameValidation_admin').html(""Please write your first name"");
                } else if (e == ""firstname_not_letter"") {
                    $('#update_parentFirstName_admin').addClass('has-danger');
                    $('.update_firstNameValidation_admin').html(""Invalid character"");
                } else if (e == ""firstname_max_letter"") {
                    $('#update_parentFirstName_admin').addClass('has-danger');
                    $('.update_firstNameValidation_admin').html(""Maximum of 50 characters only"");
                } else {
                    $('#update_parentFirstName_admin').removeClass(""has-danger"");
                    $('#update_parentFirstName_admin').addClass(""has-success"");
                    $('.update_firstNameValidation_admin').html("""");
                }

                if (e == ""lastname_required"") {
                    $('#update_parentLastName_admin').addClass('has-danger');
                    $('.update_lastNameValidation_admin').html(""Please");
            WriteLiteral(@" write your last name"");
                } else if (e == ""lastname_not_letter"") {
                    $('#update_parentLastName_admin').addClass('has-danger');
                    $('.update_lastNameValidation_admin').html(""Invalid character"");
                } else if (e == ""lastname_max_letter"") {
                    $('#update_parentLastName_admin').addClass('has-danger');
                    $('.update_lastNameValidation_admin').html(""Maximum of 50 characters only"");
                } else {
                    $('#update_parentLastName_admin').removeClass(""has-danger"");
                    $('#update_parentLastName_admin').addClass(""has-success"");
                    $('.update_lastNameValidation_admin').html("""");
                }


                GetAllUser();
            }

        });

        return false;
    });






    function GetBilling(projectID, ImageName, price) {
        $('#project-id').val(projectID);
        $('#price').val('P' + price);
        $('#depo");
            WriteLiteral(@"sit-image').html('<img src = ""../Images/' + ImageName + ' ""  width=""300""/> ');
        
    }


    function Accept() {

        var id = $('#project-id').val();

        $.ajax({
            url: '/Billing/Deposit',
            type: 'POST',
            data: { id: id, action: true },
            success: function () {
               $('#modal-form').hide();
           $('#modal-backdrop').hide();
                 Swal.fire({
                     title: 'Success!',
                     text: ""Deposit Accepted"",
                     icon: 'success',
                     confirmButtonText: 'Okay'
                 }).then((result) => {
                     if (result.value) {
                        
                            window.open(""../Billing/Billings"", ""_self"");


                     }
                 });

            }


        });

        return false;

    }

    function Decline() {

        var id = $('#project-id').val();

        $.ajax({
        ");
            WriteLiteral(@"    url: '/Billing/Deposit',
            type: 'POST',
            data: { id: id, action: false },
            success: function () {
             
                $('#modal-form').hide();
                  $('#modal-backdrop').hide();
                    Swal.fire({
                     title: 'Success!',
                     text: ""Deposit Declined"",
                     icon: 'success',
                     confirmButtonText: 'Okay'
                 }).then((result) => {
                     if (result.value) {
                        
                         window.open(""../Billing/Billings"", ""_self"");


                     }
                 });
              

            }


        });
        return false;


    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591

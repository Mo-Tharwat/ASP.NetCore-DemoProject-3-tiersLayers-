#pragma checksum "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cdb351aad54ba6e1066145abd410d104aefba71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\_ViewImports.cshtml"
using Demo.BLL.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cdb351aad54ba6e1066145abd410d104aefba71", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4b034d0d161c58e9c037537dc8d3fdd50cd01f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row col-8 offset-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "All Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>All Employees</h1>\r\n    <br />\r\n    <br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdb351aad54ba6e1066145abd410d104aefba717903", async() => {
                WriteLiteral("\r\n    Create a new Employee\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row justify-content-center align-items-center mt-5\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdb351aad54ba6e1066145abd410d104aefba719456", async() => {
                WriteLiteral(@"

        <div class=""col-8"">
            <input type=""text"" class=""form-control"" placeholder=""Search By Name"" name=""SearchValue""/>
        </div>
        <div class=""col-4"" >
            <input type=""submit"" value=""Search"" class=""btn btn-success""/>
        </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
#nullable restore
#line 31 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
 if(Model.Count() > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped table-hover mt-4\">\r\n        <thead>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.EmpName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.EmpAge));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.FKDepartment));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.EmpAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.EmpSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.EmpIsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.EmpEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.EmpPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.EmpHireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>Details</td>\r\n                <td>Update</td>\r\n                <td>Delete</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
             foreach(var employee in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.EmpName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.EmpAge));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.EmpAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9cdb351aad54ba6e1066145abd410d104aefba7117358", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2262, "~/files/images/", 2262, 15, true);
#nullable restore
#line 60 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
AddHtmlAttributeValue("", 2277, employee.ImageName, 2277, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.EmpSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.EmpIsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.EmpEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.EmpPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.EmpHireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E => employee.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9cdb351aad54ba6e1066145abd410d104aefba7121354", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 71 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = employee.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </tr>\r\n");
#nullable restore
#line 74 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 77 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"

} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-4 alert alert-warning\">\r\n        <h3>There Is No Employees !! </h3>\r\n    </div>\r\n");
#nullable restore
#line 82 "C:\Users\mth_g\Videos\Web Full Stack - Route\Back-End Courses\ASP.NetCore-DemoProject(3-tiersLayers)\Demo.PL\Views\Employee\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

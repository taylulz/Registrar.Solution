#pragma checksum "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea7626b66bc74d07dcf352056a9d739f3c41461"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Create), @"mvc.1.0.view", @"/Views/Students/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Create.cshtml", typeof(AspNetCore.Views_Students_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea7626b66bc74d07dcf352056a9d739f3c41461", @"/Views/Students/Create.cshtml")]
    public class Views_Students_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 36, true);
            WriteLiteral("\n<h2> Add a new Student </h2>\n<hr/>\n");
            EndContext();
#line 9 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(127, 28, false);
#line 11 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
Write(Html.Label("Student Name: "));

#line default
#line hidden
            EndContext();
            BeginContext(159, 43, false);
#line 12 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
Write(Html.TextBoxFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(207, 27, false);
#line 14 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
Write(Html.Label("Enroll Date: "));

#line default
#line hidden
            EndContext();
            BeginContext(238, 42, false);
#line 15 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
Write(Html.TextBoxFor(model => model.EnrollDate));

#line default
#line hidden
            EndContext();
            BeginContext(285, 27, false);
#line 17 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
Write(Html.Label("Select Course"));

#line default
#line hidden
            EndContext();
            BeginContext(316, 29, false);
#line 18 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
Write(Html.DropDownList("CourseId"));

#line default
#line hidden
            EndContext();
            BeginContext(347, 78, true);
            WriteLiteral("  <input type = \"submit\" value =\"Add new Student\" class =\"btn btn-default\" />\n");
            EndContext();
#line 21 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
}

#line default
#line hidden
            BeginContext(427, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(431, 48, false);
#line 22 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
Write(Html.ActionLink("Back to Student List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(479, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(488, 40, false);
#line 23 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Create.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(528, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591

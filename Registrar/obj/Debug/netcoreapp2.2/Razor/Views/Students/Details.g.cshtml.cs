#pragma checksum "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2bad1170f60cc88f69c488d5ef189030e3f4f3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2bad1170f60cc88f69c488d5ef189030e3f4f3b", @"/Views/Students/Details.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 49, true);
            WriteLiteral("<h2>Student Details</h2>\n<hr/>\n<h2>Student Name: ");
            EndContext();
            BeginContext(110, 43, false);
#line 8 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
             Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(153, 30, true);
            WriteLiteral("</h2>\n<h2>Date of Enrollment: ");
            EndContext();
            BeginContext(184, 42, false);
#line 9 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
                   Write(Html.DisplayFor(model => model.EnrollDate));

#line default
#line hidden
            EndContext();
            BeginContext(226, 6, true);
            WriteLiteral("</h2>\n");
            EndContext();
#line 10 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
 if(@Model.Courses.Count == 0)
{

#line default
#line hidden
            BeginContext(265, 64, true);
            WriteLiteral("  <p>This student is not currently enrolled in any courses.</p>\n");
            EndContext();
#line 13 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(338, 69, true);
            WriteLiteral("  <h2>This student is enrolled in the following courses:</h2>\n  <ul>\n");
            EndContext();
#line 18 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
   foreach(var join in Model.Courses)
  {

#line default
#line hidden
            BeginContext(449, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(458, 22, false);
#line 20 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
   Write(join.Course.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(480, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 21 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(490, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 23 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
}

#line default
#line hidden
            BeginContext(500, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(505, 69, false);
#line 25 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Edit Student", "Edit", new { id = Model.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(574, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(583, 73, false);
#line 26 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Delete Student", "Delete", new { id = Model.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(656, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(665, 80, false);
#line 27 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Enroll in a Course", "AddCourse", new { id = Model.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(745, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(754, 48, false);
#line 28 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Back to Student List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(802, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(811, 40, false);
#line 29 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(851, 5, true);
            WriteLiteral("</p>\n");
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

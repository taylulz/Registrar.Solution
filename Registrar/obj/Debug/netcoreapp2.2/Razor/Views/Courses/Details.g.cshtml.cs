#pragma checksum "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01bfaa8dcd92def74a2d64f99649cebdf6444757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Details), @"mvc.1.0.view", @"/Views/Courses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Details.cshtml", typeof(AspNetCore.Views_Courses_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01bfaa8dcd92def74a2d64f99649cebdf6444757", @"/Views/Courses/Details.cshtml")]
    public class Views_Courses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 48, true);
            WriteLiteral("\n<h2>Course Details</h2>\n<hr/>\n<h2>Course Name: ");
            EndContext();
            BeginContext(108, 42, false);
#line 9 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
            Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(150, 25, true);
            WriteLiteral("</h2>\n<h2>Course Number: ");
            EndContext();
            BeginContext(176, 44, false);
#line 10 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
              Write(Html.DisplayFor(model => model.CourseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(220, 13, true);
            WriteLiteral("</h2>\n\n\n<ul>\n");
            EndContext();
#line 14 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
 if (@Model.Students.Count == 0)
{

#line default
#line hidden
            BeginContext(268, 27, true);
            WriteLiteral("  <p>no students found</p>\n");
            EndContext();
#line 17 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(304, 52, true);
            WriteLiteral("  <h2>Students enrolled in this course:</h2>\n  <ul>\n");
            EndContext();
#line 22 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
   foreach(var join in Model.Students)
  {

#line default
#line hidden
            BeginContext(399, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(408, 24, false);
#line 24 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
   Write(join.Student.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(432, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 25 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(442, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 27 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
}

#line default
#line hidden
            BeginContext(452, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(457, 66, false);
#line 29 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Edit Course", "Edit", new { id = Model.CourseId}));

#line default
#line hidden
            EndContext();
            BeginContext(523, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(532, 71, false);
#line 30 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Delete Course", "Delete", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(603, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(613, 47, false);
#line 32 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Back to Course List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(660, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(669, 40, false);
#line 33 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(709, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591

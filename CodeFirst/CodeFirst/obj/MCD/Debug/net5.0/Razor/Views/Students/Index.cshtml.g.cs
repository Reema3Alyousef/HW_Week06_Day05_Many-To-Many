#pragma checksum "C:\Users\Reema\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1748562a79243663c1374a8d88fea4e6d5b04ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "C:\Users\Reema\source\repos\CodeFirst\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Reema\source\repos\CodeFirst\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1748562a79243663c1374a8d88fea4e6d5b04ad", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2893f32809c6984f1f4f51fb32c8f7d676103953", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Reema\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
  
    var students = (List<StudentModel>)ViewBag.Students;
    string mail = (string)ViewBag.mail;
    string firstname = (string)ViewBag.firstname;
    var ides = (List<StudentModel>)ViewBag.ids;
    var dt = (StudentModel)ViewData["detail"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "C:\Users\Reema\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
Write(mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 10 "C:\Users\Reema\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
Write(firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3>Details of student:</h3>\r\n<p>Hi my name is ");
#nullable restore
#line 12 "C:\Users\Reema\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
            Write(dt.fn);

#line default
#line hidden
#nullable disable
            WriteLiteral(", and my last name is ");
#nullable restore
#line 12 "C:\Users\Reema\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
                                        Write(dt.ln);

#line default
#line hidden
#nullable disable
            WriteLiteral(" .My email is ");
#nullable restore
#line 12 "C:\Users\Reema\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
                                                            Write(dt.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n");
            WriteLiteral("\r\n");
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

#pragma checksum "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\Home\GetTypeBResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e0dd107dd5026fbd2e0297522550d4bf940ddfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetTypeBResult), @"mvc.1.0.view", @"/Views/Home/GetTypeBResult.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\_ViewImports.cshtml"
using ZenithPensionsQuestionier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\_ViewImports.cshtml"
using ZenithPensionsQuestionier.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e0dd107dd5026fbd2e0297522550d4bf940ddfd", @"/Views/Home/GetTypeBResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0a883157d2f73cf1752147abdc472dddfc6a0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetTypeBResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZenithPensionsQuestionier.Models.QuestionAnswerCountVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\Home\GetTypeBResult.cshtml"
  
    ViewData["Title"] = "GetResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>TYPE A</h3>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\Home\GetTypeBResult.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\Home\GetTypeBResult.cshtml"
             if (item.Type == "B")
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"> ");
#nullable restore
#line 18 "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\Home\GetTypeBResult.cshtml"
                                                              Write(item.Text.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <br />\r\n                        <hr />\r\n                        <p>");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\Home\GetTypeBResult.cshtml"
                      Write(item.OptionA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            \r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <br />\r\n");
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\Home\GetTypeBResult.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\Questionier\ZenithPensionsQuestionier\Views\Home\GetTypeBResult.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZenithPensionsQuestionier.Models.QuestionAnswerCountVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591

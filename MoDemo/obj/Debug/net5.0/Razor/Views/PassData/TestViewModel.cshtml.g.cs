#pragma checksum "F:\projects net2\MoDemo\MoDemo\Views\PassData\TestViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7eb17e875a5a025545e6d4306aefa562941c9a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PassData_TestViewModel), @"mvc.1.0.view", @"/Views/PassData/TestViewModel.cshtml")]
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
#line 1 "F:\projects net2\MoDemo\MoDemo\Views\_ViewImports.cshtml"
using MoDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\projects net2\MoDemo\MoDemo\Views\_ViewImports.cshtml"
using MoDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7eb17e875a5a025545e6d4306aefa562941c9a4", @"/Views/PassData/TestViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c75b45aab3e4ff443e74c5ff6de2acba50c7ac34", @"/Views/_ViewImports.cshtml")]
    public class Views_PassData_TestViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoDemo.ViewModel.EmployeeWithMessageAndBranchlistVM>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\projects net2\MoDemo\MoDemo\Views\PassData\TestViewModel.cshtml"
  
    ViewData["Title"] = "TestViewModel";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>TestViewModel</h1>\r\n\r\n<h2>");
#nullable restore
#line 8 "F:\projects net2\MoDemo\MoDemo\Views\PassData\TestViewModel.cshtml"
Write(Model.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br />\r\n\r\n");
            WriteLiteral("\r\n<h3>message : ");
#nullable restore
#line 13 "F:\projects net2\MoDemo\MoDemo\Views\PassData\TestViewModel.cshtml"
         Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n<h4>temp :");
#nullable restore
#line 15 "F:\projects net2\MoDemo\MoDemo\Views\PassData\TestViewModel.cshtml"
     Write(Model.temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<br />\r\n<select class=\"form-control\">\r\n");
#nullable restore
#line 18 "F:\projects net2\MoDemo\MoDemo\Views\PassData\TestViewModel.cshtml"
     foreach (var item in Model.branch)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7eb17e875a5a025545e6d4306aefa562941c9a44321", async() => {
#nullable restore
#line 20 "F:\projects net2\MoDemo\MoDemo\Views\PassData\TestViewModel.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "F:\projects net2\MoDemo\MoDemo\Views\PassData\TestViewModel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</select>\r\n\r\n\r\n<h4>");
#nullable restore
#line 25 "F:\projects net2\MoDemo\MoDemo\Views\PassData\TestViewModel.cshtml"
Write(Model.temp+10);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoDemo.ViewModel.EmployeeWithMessageAndBranchlistVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

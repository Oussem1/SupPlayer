#pragma checksum "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c11da04c9769236be123f5962d09b0f9fd3d6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Rename), @"mvc.1.0.view", @"/Views/Home/Rename.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Rename.cshtml", typeof(AspNetCore.Views_Home_Rename))]
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
#line 1 "C:\Users\ousse\source\repos\SupPlayer\Views\_ViewImports.cshtml"
using SupPlayer;

#line default
#line hidden
#line 2 "C:\Users\ousse\source\repos\SupPlayer\Views\_ViewImports.cshtml"
using SupPlayer.Models;

#line default
#line hidden
#line 1 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
using SupPlayer.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c11da04c9769236be123f5962d09b0f9fd3d6b", @"/Views/Home/Rename.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f5b97fc85c6a5cde039172932163f0e3fa0ba18", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Rename : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PlaylistViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rename_Playlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(200, 54, true);
            WriteLiteral("\r\n<div class=\"contentsite\" style=\"margin-top:20px;\">\r\n");
            EndContext();
#line 10 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
     if (SignInManager.IsSignedIn(User))
    {
        if(Model.Count == 0)
        {

#line default
#line hidden
            BeginContext(344, 58, true);
            WriteLiteral("            <h2>You haven\'t access to this playlist</h2>\r\n");
            EndContext();
#line 15 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
        }
        else 
        {
            

#line default
#line hidden
#line 18 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
             foreach (var data in Model)
            {

#line default
#line hidden
            BeginContext(496, 32, true);
            WriteLiteral("                <h3>Playlist  : ");
            EndContext();
            BeginContext(529, 17, false);
#line 20 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
                           Write(data.PlaylistName);

#line default
#line hidden
            EndContext();
            BeginContext(546, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(555, 65, true);
            WriteLiteral("                <p>Use this section to rename this playlist</p>\r\n");
            EndContext();
            BeginContext(622, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(638, 458, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6c11da04c9769236be123f5962d09b0f9fd3d6b5943", async() => {
                BeginContext(687, 60, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"PlaylistID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 747, "\"", 771, 1);
#line 25 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
WriteAttributeValue("", 755, data.PlaylistID, 755, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(772, 317, true);
                WriteLiteral(@" />
                    <div class=""form-group"">
                        <input type=""text"" name=""PlaylistName"" class=""form-control"" placeholder=""Enter new playlist name"" />
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">Update the Playlist</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1096, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
             }

#line default
#line hidden
#line 31 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
              
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(1149, 64, true);
            WriteLiteral("        <h2>You must be logged in to access this section.</h2>\r\n");
            EndContext();
#line 37 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Rename.cshtml"
    }

#line default
#line hidden
            BeginContext(1220, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PlaylistViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

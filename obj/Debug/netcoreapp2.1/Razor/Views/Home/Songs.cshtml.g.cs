#pragma checksum "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "309c2725825a476a9d8f9d13a0f8b8923fcb1dfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Songs), @"mvc.1.0.view", @"/Views/Home/Songs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Songs.cshtml", typeof(AspNetCore.Views_Home_Songs))]
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
#line 1 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
using SupPlayer.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"309c2725825a476a9d8f9d13a0f8b8923fcb1dfe", @"/Views/Home/Songs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f5b97fc85c6a5cde039172932163f0e3fa0ba18", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Songs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PlaylistViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create_Song", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
  
    //pour recuperer le nom et l'id de la playlist du song sans avoir a faire un foreach sur tout le fichier
    var pName = "";
    var pID = 0;

#line default
#line hidden
            BeginContext(358, 54, true);
            WriteLiteral("\r\n<div class=\"contentsite\" style=\"margin-top:20px;\">\r\n");
            EndContext();
#line 16 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
     if (SignInManager.IsSignedIn(User))
    {
        //on recupere nom et l'id de la playlist du song
        

#line default
#line hidden
#line 19 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
         foreach (var data in Model)
        {
            pName = data.PlaylistName;
            pID = data.PlaylistID;
        }

#line default
#line hidden
#line 23 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
         
        //securisation
        if(!string.IsNullOrEmpty(pName))
        {

#line default
#line hidden
            BeginContext(732, 27, true);
            WriteLiteral("            <h3>Playlist : ");
            EndContext();
            BeginContext(760, 5, false);
#line 27 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
                      Write(pName);

#line default
#line hidden
            EndContext();
            BeginContext(765, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(774, 67, true);
            WriteLiteral("            <p>Use this section to add songs to this playlist</p>\r\n");
            EndContext();
            BeginContext(843, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(855, 623, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "309c2725825a476a9d8f9d13a0f8b8923fcb1dfe6604", async() => {
                BeginContext(930, 56, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"PlaylistID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 986, "\"", 998, 1);
#line 32 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
WriteAttributeValue("", 994, pID, 994, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(999, 472, true);
                WriteLiteral(@" />
                <div class=""form-group"">
                    <input type=""text"" name=""SongName"" class=""form-control"" placeholder=""Enter song name"" />
                </div>

                <p>Upload a <b>mp3</b> file:</p>
                <div class=""form-group"">
                    <input type=""file"" name=""file"" class=""form-control"" />
                </div>
                <button type=""submit"" class=""btn btn-primary"">Add the Song</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1478, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1482, 55, true);
            WriteLiteral("            <h3>List of songs in this playlist :</h3>\r\n");
            EndContext();
            BeginContext(1539, 37, true);
            WriteLiteral("            <ul class=\"list-group\">\r\n");
            EndContext();
#line 47 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
                 foreach (var data in Model)
                {
                    //on affiche pas les infos du default song
                    

#line default
#line hidden
#line 50 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
                     if (data.SongName != "Default song")
                    {

#line default
#line hidden
            BeginContext(1787, 82, true);
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            ");
            EndContext();
            BeginContext(1870, 13, false);
#line 53 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
                       Write(data.SongName);

#line default
#line hidden
            EndContext();
            BeginContext(1883, 31, true);
            WriteLiteral("\r\n                            [");
            EndContext();
            BeginContext(1915, 69, false);
#line 54 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
                        Write(Html.ActionLink("play", "PlaySong", "Home", new { id = data.SongID }));

#line default
#line hidden
            EndContext();
            BeginContext(1984, 63, true);
            WriteLiteral("]\r\n                            -\r\n                            [");
            EndContext();
            BeginContext(2048, 73, false);
#line 56 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
                        Write(Html.ActionLink("delete", "DeleteSong", "Home", new { id = data.SongID }));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 34, true);
            WriteLiteral("]\r\n                        </li>\r\n");
            EndContext();
#line 58 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
                    }

#line default
#line hidden
#line 58 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2197, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 61 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2252, 49, true);
            WriteLiteral("            <script>location.reload();</script>\r\n");
            EndContext();
#line 65 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2336, 65, true);
            WriteLiteral("        <h2> You must be logged in to access this section.</h2>\r\n");
            EndContext();
#line 70 "C:\Users\ousse\source\repos\SupPlayer\Views\Home\Songs.cshtml"
    }

#line default
#line hidden
            BeginContext(2408, 8, true);
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

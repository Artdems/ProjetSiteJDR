#pragma checksum "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9200dd8d918dcb03ee3d878daa553bd35c4079e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personnage_CreateEditePersonnage), @"mvc.1.0.view", @"/Views/Personnage/CreateEditePersonnage.cshtml")]
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
#line 1 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\_ViewImports.cshtml"
using ProjetPerso;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\_ViewImports.cshtml"
using ProjetPerso.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
using ProjetPerso.Models.Personnages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9200dd8d918dcb03ee3d878daa553bd35c4079e", @"/Views/Personnage/CreateEditePersonnage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf607f545b4100ad5903e488cee3aec4131bbbdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Personnage_CreateEditePersonnage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateEditePersonnageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
  
    ViewData["Title"] = "CreateEditePersonnage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CreateEditePersonnage</h1>\r\n\r\n<h4>Personnage</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 14 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
         using (Html.BeginForm("Create", "Personnage", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 17 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Joueur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Joueur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 21 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 25 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Pernoms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Pernoms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 29 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 30 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 33 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Dexteriter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 34 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Dexteriter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 37 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Charisme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 38 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Charisme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 41 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Perseption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Perseption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 45 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Constitution));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 46 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Constitution));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 49 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Force));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 50 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Force));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 53 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Agiliter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 54 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Agiliter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 57 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Vie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 58 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Vie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 61 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.LabelFor(m => m.Personnages.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 62 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
           Write(Html.TextBoxFor(m => m.Personnages.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 67 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\CreateEditePersonnage.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9200dd8d918dcb03ee3d878daa553bd35c4079e12817", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateEditePersonnageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

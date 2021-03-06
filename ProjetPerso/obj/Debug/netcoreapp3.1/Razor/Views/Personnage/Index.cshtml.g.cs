#pragma checksum "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "840a60961e317df419a6b9b5f7d7c67feef3e9e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personnage_Index), @"mvc.1.0.view", @"/Views/Personnage/Index.cshtml")]
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
#line 1 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
using ProjetPerso.Models.Personnages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840a60961e317df419a6b9b5f7d7c67feef3e9e7", @"/Views/Personnage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf607f545b4100ad5903e488cee3aec4131bbbdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Personnage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DeleteButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
  
    ViewData["Title"] = "Personnage";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function launchModal(id, joueur, nom) {
        document.getElementById(""exampleModalLabel"").innerHTML = joueur + "" "" + nom;
        document.getElementById(""DeleteButton"").action = ""/Personnage/Delete?ReturnID="" + id;
        document.getElementById(""ContenteModal"").innerHTML = ""Voulez vous vraiment suprimez le personnage de "" + joueur + "" "" + nom + "" ?"";
    }

    function launchModalInfo(info, perso) {
        document.getElementById(""exampleModalLabel"").innerHTML = ""Information sur "" + perso;
        document.getElementById(""DeleteButton"").action = """";
        document.getElementById(""ContenteModal"").innerHTML = info;
    }

    $('#myModal').on('shown.bs.modal', function () {
        $('#myInput').trigger('focus')
    })

</script>

<h1>Liste des Personnage</h1>


<p>
    <a href=""Personnage/Create""><button class=""btn btn-secondary""> Ajouter un Personnage</button></a>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ID
    ");
            WriteLiteral(@"        </th>
            <th>
                Joueur
            </th>
            <th>
                Nom
            </th>
            <th>
                Prenoms
            </th>
            <th>
                Age
            </th>
            <th>
                Dexteriter
            </th>
            <th>
                Charisme
            </th>
            <th>
                Perseption
            </th>
            <th>
                Constitution
            </th>
            <th>
                Force
            </th>
            <th>
                Agiliter
            </th>
            <th>
                Vie
            </th>
            <th>
                Note
            </th>
            <th>
                Editer
            </th>
            <th>
                Supprimer
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 85 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
         foreach (var item in Model.Personnages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 92 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Joueur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 95 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 98 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pernoms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 101 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 104 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dexteriter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 107 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Charisme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 110 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Perseption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 113 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Constitution));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 116 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Force));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 119 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Agiliter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 122 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button type=\"submit\" class=\"btn btn-info\" data-toggle=\"modal\" data-target=\"#exampleModal\"");
            BeginWriteAttribute("onclick", " onclick=\'", 3581, "\'", 3637, 6);
            WriteAttributeValue("", 3591, "launchModalInfo(\"", 3591, 17, true);
#nullable restore
#line 125 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
WriteAttributeValue("", 3608, item.Note, 3608, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3618, "\",\"", 3618, 3, true);
#nullable restore
#line 125 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
WriteAttributeValue("", 3621, item.Pernoms, 3621, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3634, "\"", 3634, 1, true);
            WriteAttributeValue(" ", 3635, ")", 3636, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-sticky-note\"></i></button>\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 128 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
                     using (Html.BeginForm("Details", "Personnage", new { ReturnID = item.ID }, FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\"><i class=\"fas fa-cog\"></i></button>\r\n");
#nullable restore
#line 131 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    <button type=\"submit\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#exampleModal\"");
            BeginWriteAttribute("onclick", " onclick=\'", 4154, "\'", 4214, 9);
            WriteAttributeValue("", 4164, "launchModal(", 4164, 12, true);
#nullable restore
#line 134 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
WriteAttributeValue("", 4176, item.ID, 4176, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4184, ",\"", 4184, 2, true);
#nullable restore
#line 134 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
WriteAttributeValue("", 4186, item.Joueur, 4186, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4198, "\",", 4198, 2, true);
            WriteAttributeValue(" ", 4200, "\"", 4201, 2, true);
#nullable restore
#line 134 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
WriteAttributeValue("", 4202, item.Nom, 4202, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4211, "\"", 4211, 1, true);
            WriteAttributeValue(" ", 4212, ")", 4213, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i></button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 137 "C:\Users\adesmarais\source\repos\ProjetSiteJDR\ProjetPerso\Views\Personnage\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel""></h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"" id=""ContenteModal"">
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Annuler</button>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "840a60961e317df419a6b9b5f7d7c67feef3e9e715483", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Supprimer</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

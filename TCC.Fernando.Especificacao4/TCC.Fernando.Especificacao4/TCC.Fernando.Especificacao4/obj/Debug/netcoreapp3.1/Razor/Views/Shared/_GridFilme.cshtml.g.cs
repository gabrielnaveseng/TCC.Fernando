#pragma checksum "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98a8efc0967af1f59eeaafe246c71e93b1eaf060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GridFilme), @"mvc.1.0.view", @"/Views/Shared/_GridFilme.cshtml")]
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
#line 1 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\_ViewImports.cshtml"
using TCC.Fernando.Especificacao4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\_ViewImports.cshtml"
using TCC.Fernando.Especificacao4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a8efc0967af1f59eeaafe246c71e93b1eaf060", @"/Views/Shared/_GridFilme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58cc0419ff0abbf4251f1ac4e81d29724353a264", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GridFilme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FilmeModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Titulo Filme</th>
                <th scope=""col"">Genero</th>
                <th scope=""col"">Ano</th>
                <th scope=""col"">Estudio</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 15 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml"
             foreach(var filme in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 18 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml"
                               Write(filme.TituloFilme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml"
                   Write(filme.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml"
                   Write(filme.Ano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml"
                   Write(filme.Estudio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table> \r\n");
#nullable restore
#line 26 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert-info\">Nenhum resultado encontrato</div>\r\n");
#nullable restore
#line 30 "C:\Users\192455\source\repos\TCC.Fernando\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\TCC.Fernando.Especificacao4\Views\Shared\_GridFilme.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FilmeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

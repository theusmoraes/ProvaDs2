#pragma checksum "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c0ab7dda7a9935aabc294955a97d6d3306c489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Placars_Ranking), @"mvc.1.0.view", @"/Views/Placars/Ranking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Placars/Ranking.cshtml", typeof(AspNetCore.Views_Placars_Ranking))]
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
#line 1 "C:\Users\Matheus\source\repos\Prova\Prova\Views\_ViewImports.cshtml"
using Prova;

#line default
#line hidden
#line 2 "C:\Users\Matheus\source\repos\Prova\Prova\Views\_ViewImports.cshtml"
using Prova.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c0ab7dda7a9935aabc294955a97d6d3306c489", @"/Views/Placars/Ranking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db9ed8ee9d0b5370775aac14f6c8c634e9f360f", @"/Views/_ViewImports.cshtml")]
    public class Views_Placars_Ranking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Prova.Models.Placar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
  
    int i=1;
    ViewData["Title"] = "Ranking";

#line default
#line hidden
            BeginContext(100, 138, true);
            WriteLiteral("\r\n<h1>Ranking</h1>\r\n<table class=\"table\">\r\n<thead>\r\n    <tr>\r\n        <th>\r\n            Posição\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(239, 43, false);
#line 16 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
       Write(Html.DisplayNameFor(model => model.Jogador));

#line default
#line hidden
            EndContext();
            BeginContext(282, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(326, 42, false);
#line 19 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
       Write(Html.DisplayNameFor(model => model.Pontos));

#line default
#line hidden
            EndContext();
            BeginContext(368, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(412, 45, false);
#line 22 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
       Write(Html.DisplayNameFor(model => model.DataPonto));

#line default
#line hidden
            EndContext();
            BeginContext(457, 68, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n</thead>\r\n<tbody>\r\n\r\n");
            EndContext();
#line 29 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(561, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(610, 1, false);
#line 32 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(611, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(667, 47, false);
#line 35 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
           Write(Html.DisplayFor(modelItem => item.Jogador.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(770, 41, false);
#line 38 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pontos));

#line default
#line hidden
            EndContext();
            BeginContext(811, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(867, 44, false);
#line 41 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataPonto));

#line default
#line hidden
            EndContext();
            BeginContext(911, 50, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Matheus\source\repos\Prova\Prova\Views\Placars\Ranking.cshtml"
      
            i = i + 1;
      
    }

#line default
#line hidden
            BeginContext(1008, 24, true);
            WriteLiteral("</tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Prova.Models.Placar>> Html { get; private set; }
    }
}
#pragma warning restore 1591

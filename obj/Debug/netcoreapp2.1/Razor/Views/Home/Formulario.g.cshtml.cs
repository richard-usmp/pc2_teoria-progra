#pragma checksum "C:\Users\Ricardo\Documents\pc2_teoria-progra\Views\Home\Formulario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb194f155f4635f0721b2b57bbde01cae9b1b2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Formulario), @"mvc.1.0.view", @"/Views/Home/Formulario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Formulario.cshtml", typeof(AspNetCore.Views_Home_Formulario))]
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
#line 1 "C:\Users\Ricardo\Documents\pc2_teoria-progra\Views\_ViewImports.cshtml"
using Liga_Pokemon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb194f155f4635f0721b2b57bbde01cae9b1b2f", @"/Views/Home/Formulario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"265034242b1be22d56ff3b86ddd87b5cb8d5dd68", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Formulario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entrenador>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 466, true);
            WriteLiteral(@"
<h1>Formulario de incripción a la Liga Pokemon</h1>
<div asp-validation-summary=""All"">
    <form asp-action=""Formulario"">
        <label>Nombre del Entrenador: </label> 
            <input asp-for=""Nombre""> <br>
        <label>Pueblo de origen: </label> 
            <input asp-for=""Origen""> <br>
        <label>Cantidad de medallas: </label> 
            <input asp-for=""Cantidad""> <br>
        <input type=""submit"" value=""Registro"">
    </form>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entrenador> Html { get; private set; }
    }
}
#pragma warning restore 1591

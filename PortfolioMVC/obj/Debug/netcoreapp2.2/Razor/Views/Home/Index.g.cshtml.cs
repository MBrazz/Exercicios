#pragma checksum "C:\Users\51663853819\Documents\Exercicios C#\PortfolioMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fbe79bb36a3abcb76b7320fa5887c219792cd3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\51663853819\Documents\Exercicios C#\PortfolioMVC\Views\_ViewImports.cshtml"
using PortfolioMVC;

#line default
#line hidden
#line 2 "C:\Users\51663853819\Documents\Exercicios C#\PortfolioMVC\Views\_ViewImports.cshtml"
using PortfolioMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fbe79bb36a3abcb76b7320fa5887c219792cd3a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35f9e7cc43852acb9d689f96ec863a9bc802525", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 40, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n  ");
            EndContext();
            BeginContext(40, 280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fbe79bb36a3abcb76b7320fa5887c219792cd3a3373", async() => {
                BeginContext(46, 267, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Portfólio Marcos</title>
    <link rel=""stylesheet"" type=""text/css"" href=""style.css""/>
  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(320, 4, true);
            WriteLiteral("\r\n  ");
            EndContext();
            BeginContext(324, 1868, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fbe79bb36a3abcb76b7320fa5887c219792cd3a4838", async() => {
                BeginContext(330, 1855, true);
                WriteLiteral(@"
    <header>
      <h1>Marcos Roberto Hilario</h1>

      <br>
      <div id=""logo-area"">
        <img src=""destaque-19.jpg"">
      </div>
        <nav>
         <div class=""section-container"">
            <ul>      
                <li><a href=""index.html""></a></li>
            </ul>
        </div>
        </nav>
    </header>
        
   <main>
        <section id=""sobre"">
        <h2> Sobre </h2>
        <em>
        <strong>Idade</strong>:33 anos
        <br>
        
        
        <strong>Nasceu em</strong>: São Paulo
        <br>
        
        
        <strong>Estado Civil</strong>: Casado
        <br>
        
        
        <strong>Time do Coração</strong>: Corinthians
        <br>
        
        
        <strong>Esporte</strong>: Fã de UFC
        <br>
       
        
        <strong>Curiosidade</strong>: Fez parte de uma Banda de Rock  
        <br>
        
        
        <strong>Projetos Pessoais</strong>: Blog - No beer No idea
        <");
                WriteLiteral(@"br>
       </em>
      </section>
      <section id=""cursos"">
        
        <h2> Cursos </h2>  


  <div class=""curso1""><strong>2008</strong> - Aprovado no concurso da escola de formação de sargento do exército
    (6 Meses)</div>
    <div class=""curso2""><strong>2011</strong> - Missão de Paz no Haiti</div>
    <div class=""curso3""><strong>2013</strong> - Graduação em Técnologia da Segurança Pública</div>
    <div class=""curso4""><strong>2015</strong> - Pós Graduação em Gestão da Segurança Privada</div>
    <div class=""curso5""><strong>2018</strong> - Projeto de implantação de ponto eletrônico em postos de serviço da área de segurança</div>
    <div class=""curso6""><strong>2019</strong> - Senai - DEV. (Cursando)</div>
  </ul>
  </div>
            </section>
      

  </main>
      
          
      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2192, 57, true);
            WriteLiteral("\r\n      </html>\r\n            \r\n            \r\n            ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

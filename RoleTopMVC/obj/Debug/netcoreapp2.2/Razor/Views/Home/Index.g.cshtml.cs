#pragma checksum "C:\Users\51663853819\Documents\Exercicios C#\RoleTopMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970e145152c52bc81bb61aa25916b4ff35f337f5"
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
#line 1 "C:\Users\51663853819\Documents\Exercicios C#\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\51663853819\Documents\Exercicios C#\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970e145152c52bc81bb61aa25916b4ff35f337f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(0, 38, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(38, 649, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970e145152c52bc81bb61aa25916b4ff35f337f53361", async() => {
                BeginContext(44, 636, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" type=""text/css"" href=""style.css""/>
    <link href=""https://fonts.googleapis.com/css?family=Courgette&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Rokkitt&display=swap"" rel=""stylesheet"">
    <link rel=""icon"" type=""image/x-icon"" href=""logo.png"">
    
 

    <title>Rolê Top</title>
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
            BeginContext(687, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(689, 5265, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970e145152c52bc81bb61aa25916b4ff35f337f55211", async() => {
                BeginContext(695, 5252, true);
                WriteLiteral(@"
    <h1>Rolê Top</h1>
    <header>


            <nav>
                
                    <div class=""section-container"">
                        <ul>
                            <li><a href=""index.html"">Home</a></li>
                            <li><a href=""index.html#eventos"">Eventos</a></li>
                            <li><a href=""index.html#galeria"">Galeria</a></li>
                            <li><a href=""reservar.html"">Reservar</a></li>
                            <div class=""login"">                
                            <li><a href=""login.html"">Login</a></li>
                            <li><a href=""cadastro.html"">Cadastro</a></li>
                            </div> 
                         </ul>
                    </div>
                    <hr>
            </div>   
            </nav>

        
    </header>
<main>
    <section id=""banner"" >
    <img id=""logo"" src=""logo.png"">
    </section>
    <hr>
    <div class=""text"">
        <p>
                Atendim");
                WriteLiteral(@"ento personalizado, e mais de 2000 eventos realizados em todo país,<br> 
                O Rolê Top tem toda a estrutura, física, funcional e pacotes que facilitam <br>
                a vida de quem esta em busca contratar o melhor para seu evento, <br> 
                ele um evento: corporativo, social, balada, shows, uma pequena recepção para amigos <br> 
                ou até apenas a locação de um salão de festa, espaços para eventos e <br>
                espaços para festas
                </p>
                <p>
                Estamos conectados a você , seja em nosso portal, Telefone, através de e-mail,<br>
                pelo atendimento personalizado de consultores, em nosso Salão de Festa ou nossos Espaços para Eventos.
            <hr>
        </p>
    </div>
    <section id=""eventos"">
    <h2>Eventos</h2>       
    <div class=""fotodoseventos"">
        
            <div class=""dance-container"">
                    <p>30/02/2020</p>
    <img src=""danceparty.jpg"" height=""40");
                WriteLiteral(@"0px"" width=""250px"">
            </div>
            <div class=""dance-container"">
                    <p>30/02/2020</p>
    <img src=""raveparty.webp"" height=""400px"" width=""250px"">
            </div>
            <div class=""dance-container"">
                    <p>30/02/2020</p>
    <img src=""nightparty.jpg"" height=""400px"" width=""250px"">
            </div>
            <div class=""dance-container"">
                <p>30/02/2020</p>
    <img src=""evento80s.jpg"" height=""400px"" width=""250px"">
            </div>
        </div>
    

<div class=""tipos"">
    <h3>Tipos de Eventos</h3>
    
    <ul>
        <div class=""social"">
        <li>Social</li>
        <p>Aniversários<br> Debutantes<br> Infantíl<br> Temáticos<br> Chá Bar<br> Despedidas</p>
        </div>
        <div class=""casamentos"">
        <li>Casamentos</li>
        <p>Noivados <br> Mini Weddings<br> Casamentos<br> Despedidas<br> Bodas<br> Renovação dos Votos</p>
        </div>
        <div class=""corporativos"">
        <li>Cor");
                WriteLiteral(@"porativos</li>
        <p>Final de Ano <br>Palestras <br>Coquetéis <br>Lançamentos <br>Coffebreak<br>Exposições</p>
        </div>
        <div class=""universitarios"">
        <li>Universitários</li>
        <p>Formaturas <br> Bota foras <br> Cervejadas <br> Campus party <br> Festas <br> Jogos</p>
        </div>
    </ul>
    </div>
</section>
<section id=""galeria"">
    <h2>Galeria</h2>
    <div class= ""fotogaleria"">
            <div class= ""foto-container"">
                    
                    
    <img src=""fotenha1galeria.jpg"" height=""300px"" width=""350px"">
            </div>
            <div class=""foto-container"">
    <img src=""fotenha2galeria.jpg"" height=""300px"" width=""350px"">
            </div>
        <div class= ""foto-container"">
    <img src=""fotenha3galeria.jpg"" height=""300px"" width=""350px"">
            </div>
        <div class=""foto-container"">
    <img src=""fotenha4galeria.jpg"" height=""300px"" width=""350px"">
            </div>
        <div class=""foto-container"">
  ");
                WriteLiteral(@"  <img src=""fotenha5galeria.jpg"" height=""300px"" width=""350px"">
            </div>
        <div class=""foto-container"">
    <img src=""fotenha6galeria.jpg"" height=""300px"" width=""350px"">
                    
        </div>
    </div>
</section>

</main>

<section id=""local"">
        <div class=""section-container"">
            <iframe
                src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8869961505543!2d-46.648477085071065!3d-23.53656648469522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1sen!2sbr!4v1550223658410""
                width=""100%"" height=""200em;"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
        </div>
</section>
<footer>
    <div class=""section-container"">
        <address>
            Avenida de Limeira, 539 - Campos Elíseos - SP
            <br />
            mcbonalds@email.com
      ");
                WriteLiteral("      <br />\r\n            11 1234 6789\r\n        </address>\r\n        <a href=\"#\">Voltar para o topo!</a>\r\n    </div>\r\n</footer>\r\n\r\n\r\n");
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
            BeginContext(5954, 9, true);
            WriteLiteral("\r\n</html>");
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
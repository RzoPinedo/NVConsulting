#pragma checksum "C:\Users\Usuario\Desktop\Borrar\marilin_net\HERRAMIENTAS\NVConsulting-Herramientas\NVConsultingMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3103bf25eac45a5e346d65b49ce606523f8309a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\Borrar\marilin_net\HERRAMIENTAS\NVConsulting-Herramientas\NVConsultingMVC\Views\_ViewImports.cshtml"
using NVConsultingMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\Borrar\marilin_net\HERRAMIENTAS\NVConsulting-Herramientas\NVConsultingMVC\Views\_ViewImports.cshtml"
using NVConsultingMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3103bf25eac45a5e346d65b49ce606523f8309a6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05d9bc814d20a2aa99304ddea933e45e0374e95", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Usuario\Desktop\Borrar\marilin_net\HERRAMIENTAS\NVConsulting-Herramientas\NVConsultingMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\"\r\n      xmlns:th=\"http://www.thymeleaf.org\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3103bf25eac45a5e346d65b49ce606523f8309a64055", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>NVConsulting</title>
    <link href=""css/estilos.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""css/bootstrap.css"" rel=""stylesheet"">
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""estilos.css"" rel=""stylesheet"">
    <!---<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">--->
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3103bf25eac45a5e346d65b49ce606523f8309a65709", async() => {
                WriteLiteral(@"

    <div class=""container-fluid"">
        <div class=""container"">
            <div id=""cabecera"">
                <header>
                    <div class=""row"">
                        <h1 class=""text-center"">Capacitación, Asesoria personalizada y Cursos Online</h1>
                        <img src=""imagenes/fondo1.jpg"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 1185, "\"", 1191, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </header>
            </div>
            <div id=""promociones"" class=""container"">
                <h1>Nuevos Cursos</h1>
                <div class=""row mx5"">
                    <div class=""col-md-6 col-lg-4"">
                        <div class=""card h-100"" style=""width:18rem"">
                            <img src=""imagenes/Curso-Satisfaccion-Del-Cliente.jpg"" class=""card-img-top"">
                            <div class=""card body"">
                                <h5 style=""color:brown"">MEDICIÓN DE LA SATISFACCIÓN DEL CLIENTE</h5>
                                <p class=""card-text"" style=""color:darkgreen"">
                                    Conocer procesos efectivos para el monitoreo y medición de la satisfacción del
                                    cliente en el marco estándares internacionales (ISO 10004).
                                </p>
                                <a href=""#"" class=""btn btn-primary"">Comprar</a>
                  ");
                WriteLiteral(@"          </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-4"">
                        <div class=""card h-100"" style=""width:18rem"">
                            <img src=""imagenes/Curso-Gestion-De-La-Mejora-Continua.jpg"" class=""card-img-top"">
                            <div class=""card body"">
                                <h5 style=""color:brown"">GESTIÓN DE LA MEJORA CONTINUA</h5>
                                <p class=""card-text"" style=""color:darkgreen"">
                                    Brindar a los participantes los conceptos y herramientas necesarias para la
                                    definición, toma y control de Acciones Correctivas y Preventivas.
                                </p>
                                <a href=""#"" class=""btn btn-primary"">Comprar</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-4"">
    ");
                WriteLiteral(@"                    <div class=""card h-100"" style=""width:18rem"">
                            <img src=""imagenes/Curso-Validacion-Metodos-De-Ensayo-Cualitativos.jpg""
                                 class=""card-img-top"">
                            <div class=""card body"">
                                <h5 style=""color:brown"">VALIDACIÓN DE MÉTODOS DE ENSAYO CUALITATIVOS</h5>
                                <p class=""card-text"" style=""color:darkgreen"">
                                    Dar herramientas para definir, ejecutar y verificar validaciones de métodos de
                                    ensayo cualitativos.
                                </p>
                                <a href=""#"" class=""btn btn-primary"">Comprar</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""container-fluid col-3 align-content-center"">
                        <br>
      ");
                WriteLiteral(@"                  <button onclick=""location.href='cursos.html'"" type=""button"" class=""btn btn-primary btn-lg"">
                            Ir a
                            la Lista Completa Cursos
                        </button>
                    </div>
                </div>
            </div>
            <br>
            <br>
            <div class=""container-fluid row"" id=""galeria"">
                <div class=""col-12"">
                    <div class=""row"">
                        <div class=""col-3""></div>
                        <div class=""col-6"">
                            <div class=""text-center align-middle"">
                                <p><strong>Siempre comprometidos con nuestros alumnos</strong></p>
                            </div>
                            <div id=""slideGaleria"" class=""carousel slide"" data-bs-ride=""carousel"">
                                <div class=""carousel-inner"">
                                    <div class=""carousel-item active"">
           ");
                WriteLiteral(@"                             <img src=""./imagenes/galeria/1.jpg"" class=""d-block w-100"" alt=""#"">
                                    </div>
                                    <div class=""carousel-item"">
                                        <img src=""./imagenes/galeria/2.jpg"" class=""d-block w-100"" alt=""..."">
                                    </div>
                                    <div class=""carousel-item"">
                                        <img src=""./imagenes/galeria/3.jpg"" class=""d-block w-100"" alt=""..."">
                                    </div>
                                    <div class=""carousel-item"">
                                        <img src=""./imagenes/galeria/4.jpg"" class=""d-block w-100"" alt=""..."">
                                    </div>
                                    <div class=""carousel-item"">
                                        <img src=""./imagenes/galeria/5.jpg"" class=""d-block w-100"" alt=""..."">
                                    </div>
       ");
                WriteLiteral(@"                             <div class=""carousel-item"">
                                        <img src=""./imagenes/galeria/6.jpg"" class=""d-block w-100"" alt=""..."">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-3""></div>
                    </div>
                </div>
            </div>
            <br>
            <br>
        </div>
    </div>
    <script src=""js/bootstrap.bundle.min.js""></script>
    <script src=""js/jquery-3.6.0.js""></script>
    <script src=""js/jquery-3.6.0.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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

#pragma checksum "C:\Users\HF-NTB-04\Documents\Projetos\2022\Rich_text\Views\Texto\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd14f541d60aef1a57e6c21e51df5207ea57519"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Texto_Editar), @"mvc.1.0.view", @"/Views/Texto/Editar.cshtml")]
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
#line 1 "C:\Users\HF-NTB-04\Documents\Projetos\2022\Rich_text\Views\_ViewImports.cshtml"
using Rich_text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HF-NTB-04\Documents\Projetos\2022\Rich_text\Views\_ViewImports.cshtml"
using Rich_text.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dd14f541d60aef1a57e6c21e51df5207ea57519", @"/Views/Texto/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"134161a0a8f3842e5afd0bc0b0fbf19d8783c272", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Texto_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextoModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Titulo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Descrição"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Editando"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Texto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("editor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\t<div class=\"janela\">  \r\n\t\t<main class=\"janela-principal\">\r\n\r\n\t\t\t\r\n\r\n\r\n\t\t\t<div class=\"janela-principal-body\">  <!-- Essa parte é os icone -->\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd14f541d60aef1a57e6c21e51df5207ea575197004", async() => {
                WriteLiteral(@"


			<div class=""janela-principal-header"">  <!-- Apenas a header que fica no topo -->
				<ol class=""opcao-top"">
					<li class=""opcao-top-item"">
						<svg width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
							<path d=""M3.6 3H20.4C20.7314 3 21 3.26863 21 3.6V20.4C21 20.7314 20.7314 21 20.4 21H3.6C3.26863 21 3 20.7314 3 20.4V3.6C3 3.26863 3.26863 3 3.6 3Z"" stroke=""currentColor"" stroke-width=""1.5"" />
							<path d=""M9.75 9.75V21"" stroke=""currentColor"" stroke-width=""1.5"" />
							<path d=""M3 9.75H21"" stroke=""currentColor"" stroke-width=""1.5"" />
						</svg>
						");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4dd14f541d60aef1a57e6c21e51df5207ea575197918", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 22 "C:\Users\HF-NTB-04\Documents\Projetos\2022\Rich_text\Views\Texto\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Titulo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t");
#nullable restore
#line 23 "C:\Users\HF-NTB-04\Documents\Projetos\2022\Rich_text\Views\Texto\Editar.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Titulo));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  
					</li>
						<li class=""opcao-top-item atual"">
							<svg width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
								<path d=""M4 21.4V2.6C4 2.26863 4.26863 2 4.6 2H16.2515C16.4106 2 16.5632 2.06321 16.6757 2.17574L19.8243 5.32426C19.9368 5.43679 20 5.5894 20 5.74853V21.4C20 21.7314 19.7314 22 19.4 22H4.6C4.26863 22 4 21.7314 4 21.4Z"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
								<path d=""M16 5.4V2.35355C16 2.15829 16.1583 2 16.3536 2C16.4473 2 16.5372 2.03725 16.6036 2.10355L19.8964 5.39645C19.9628 5.46275 20 5.55268 20 5.64645C20 5.84171 19.8417 6 19.6464 6H16.6C16.2686 6 16 5.73137 16 5.4Z"" fill=""currentColor"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
								<path d=""M8 10L16 10"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
								<path d=""M8 18L16 18"" stroke=""currentColor"" stroke-width=""1.5"" stroke-lineca");
                WriteLiteral("p=\"round\" stroke-linejoin=\"round\" />\r\n\t\t\t\t\t\t\t\t<path d=\"M8 14L12 14\" stroke=\"currentColor\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\" />\r\n\t\t\t\t\t\t</svg>\r\n\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4dd14f541d60aef1a57e6c21e51df5207ea5751911399", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 33 "C:\Users\HF-NTB-04\Documents\Projetos\2022\Rich_text\Views\Texto\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Descricacao);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t");
#nullable restore
#line 34 "C:\Users\HF-NTB-04\Documents\Projetos\2022\Rich_text\Views\Texto\Editar.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Descricacao));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


					
					</li>
				</ol>
			<div>
				<div>						
					</div>
					<button type=""submit"" class=""button button--save"">
						<svg width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
							<path d=""M3 19V5C3 3.89543 3.89543 3 5 3H16.1716C16.702 3 17.2107 3.21071 17.5858 3.58579L20.4142 6.41421C20.7893 6.78929 21 7.29799 21 7.82843V19C21 20.1046 20.1046 21 19 21H5C3.89543 21 3 20.1046 3 19Z"" stroke=""currentColor"" stroke-width=""1.5"" />
							<path d=""M8.6 9H15.4C15.7314 9 16 8.73137 16 8.4V3.6C16 3.26863 15.7314 3 15.4 3H8.6C8.26863 3 8 3.26863 8 3.6V8.4C8 8.73137 8.26863 9 8.6 9Z"" stroke=""currentColor"" stroke-width=""1.5"" />
							<path d=""M6 13.6V21H18V13.6C18 13.2686 17.7314 13 17.4 13H6.6C6.26863 13 6 13.2686 6 13.6Z"" stroke=""currentColor"" stroke-width=""1.5"" />
						</svg>
						Salvar
					</button>


					<button class=""button button--delete"">
						<svg width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg");
                WriteLiteral(@""">
							<path d=""M19 11V20.4C19 20.7314 18.7314 21 18.4 21H5.6C5.26863 21 5 20.7314 5 20.4V11"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
							<path d=""M10 17V11"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
							<path d=""M14 17V11"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
							<path d=""M21 7L16 7M3 7L8 7M8 7V3.6C8 3.26863 8.26863 3 8.6 3L15.4 3C15.7314 3 16 3.26863 16 3.6V7M8 7L16 7"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
						</svg>
						Apagar
					</button>
				</div>
			</div>
					



				<div class=""area-para-editar"">  <!-- Essa é a parte de edição que poderá trocar por um imput -->
						
					<div class=""editor-barra"">
						<button class=""editor-barra-item icone"">
							<svg width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
								<path");
                WriteLiteral(@" d=""M5 9.5C8.5 9.5 11.5 9.5 15 9.5C15.1615 9.5 19 9.5 19 13.5C19 18 15.2976 18 15 18C12 18 10 18 7 18"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
								<path d=""M8.5 13C7.13317 11.6332 6.36683 10.8668 5 9.5C6.36683 8.13317 7.13317 7.36683 8.5 6"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
							</svg>	
						</button>

						<button class=""editor-barra-item icone"">
							<svg width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
								<path d=""M19 9.5C15.5 9.5 12.5 9.5 9 9.5C8.83847 9.5 5 9.5 5 13.5C5 18 8.70237 18 9 18C12 18 14 18 17 18"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
								<path d=""M15.5 13C16.8668 11.6332 17.6332 10.8668 19 9.5C17.6332 8.13317 16.8668 7.36683 15.5 6"" stroke=""currentColor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round"" />
							</svg>
						</button>

						<span");
                WriteLiteral(@" class=""separador""></span>
						<button class=""editor-barra-item dropdown"">
							<span>italic</span>
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<polyline points=""208 96 128 176 48 96"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></polyline>
							</svg>
						</button>

						<span class=""separador""></span>
						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<path d=""M64,120h88a40,40,0,0,1,0,80l-88.00586-.00488v-152L140,48a36,36,0,0,1,0,72"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
							</svg>
						</button>

						<button class=""editor-barra-item icone"">
							<svg xmlns=""htt");
                WriteLiteral(@"p://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<line x1=""151.99414"" y1=""55.99512"" x2=""103.99414"" y2=""199.99512"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""63.99414"" y1=""199.99512"" x2=""143.99414"" y2=""199.99512"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""111.99414"" y1=""55.99512"" x2=""191.99414"" y2=""55.99512"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
							</svg>
	
						</button>

						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<line x1=""40"" y1=""128"" x2=""216"" y2=""128"" fill=""none"" stroke=""#000000"" stroke-linecap");
                WriteLiteral(@"=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<g>
									<path d=""M76.334,96.00294A25.48209,25.48209,0,0,1,75.11111,88c0-22.09139,21.96094-40,52.88889-40,23.77865,0,42.25677,10.58606,49.529,25.52014"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
									<path d=""M72,168c0,22.09139,25.07205,40,56,40s56-17.90861,56-40c0-23.76634-21.62275-32.97043-45.59723-40.00076"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
								</g>
							</svg>	
						</button>

						<span class=""separador""></span>
						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<rect x=""40"" y=""40"" width=""176"" height=""176"" rx=""8"" stroke-width=""16"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" fill=""none""></rect>
		");
                WriteLiteral(@"						<path d=""M215.99982,159.99982l-42.343-42.343a8,8,0,0,0-11.3137,0l-44.6863,44.6863a8,8,0,0,1-11.3137,0l-20.6863-20.6863a8,8,0,0,0-11.3137,0L40,176"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
								<circle cx=""100"" cy=""92"" r=""12""></circle>
							</svg>
						</button>
	
						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<line x1=""94.05511"" y1=""161.93204"" x2=""161.93736"" y2=""94.04979"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<path d=""M144.96473,178.9102l-28.28427,28.28427a48,48,0,0,1-67.88225-67.88225L77.08248,111.028"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
								<path d=""M178.91069,144.96424,207.195,116.68a48,48,0,0,0-67.88225-67.8822");
                WriteLiteral(@"5L111.02844,77.082"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
							</svg>
						</button>

						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<path d=""M200,224.00005H55.99219a8,8,0,0,1-8-8V40a8,8,0,0,1,8-8L152,32l56,56v128A8,8,0,0,1,200,224.00005Z"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
								<polyline points=""152 32 152 88 208.008 88"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></polyline>
								<line x1=""96"" y1=""136"" x2=""160"" y2=""136"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""96"" y1=""168"" x2=""160"" y2=""168"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""r");
                WriteLiteral(@"ound"" stroke-width=""16""></line>
							</svg>
						</button>

						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<rect x=""44"" y=""44"" width=""168"" height=""168"" rx=""8"" stroke-width=""16"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" fill=""none""></rect>
								<line x1=""128"" y1=""44"" x2=""128"" y2=""212"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""212"" y1=""128"" x2=""44"" y2=""128"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
							</svg>
						</button>

						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<path d=""M");
                WriteLiteral(@"24,60H152a32,32,0,0,1,32,32v96a8,8,0,0,1-8,8H48a32,32,0,0,1-32-32V68A8,8,0,0,1,24,60Z"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
								<polyline points=""184 112 240 80 240 176 184 144"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></polyline>
							</svg>
						</button>

						<span class=""separador""></span>
						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<polyline points=""64 88 16 128 64 168"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></polyline>
								<polyline points=""192 88 240 128 192 168"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></polyline>
								<line x1=""160"" y1=""40"" x2=""96"" y2=""216"" fill=""none"" stroke");
                WriteLiteral(@"=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
							</svg>
						</button>

						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<path d=""M108,144H40a8,8,0,0,1-8-8V72a8,8,0,0,1,8-8h60a8,8,0,0,1,8,8v88a40,40,0,0,1-40,40"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
								<path d=""M224,144H156a8,8,0,0,1-8-8V72a8,8,0,0,1,8-8h60a8,8,0,0,1,8,8v88a40,40,0,0,1-40,40"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
							</svg>
						</button>

						<span class=""separador""></span>
						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none");
                WriteLiteral(@"""></rect>
								<line x1=""88"" y1=""64"" x2=""216"" y2=""64"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""88.00614"" y1=""128"" x2=""216"" y2=""128"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""88.00614"" y1=""192"" x2=""216"" y2=""192"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<circle cx=""44"" cy=""64"" r=""12""></circle>
								<circle cx=""44"" cy=""128"" r=""12""></circle>
								<circle cx=""44"" cy=""192"" r=""12""></circle>
							</svg>
						</button>

						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<line x1=""104"" y1=""128"" x2=""215.99902"" y2=""128"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></li");
                WriteLiteral(@"ne>
								<line x1=""104"" y1=""64"" x2=""215.99902"" y2=""64"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""103.99902"" y1=""192"" x2=""215.99902"" y2=""192"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<polyline points=""40 60 56 52 56 107.994"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></polyline>
								<path d=""M41.10018,152.55059A14.00226,14.00226,0,1,1,65.609,165.82752L40,200H68"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></path>
							</svg>
						</button>

						<span class=""separador""></span>
						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<line x1=""40"" y1=""68"" x2=""216"" y2=""68"" fill=""none"" stroke=""#000000"" stro");
                WriteLiteral(@"ke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""40"" y1=""108"" x2=""168"" y2=""108"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""40.00614"" y1=""148"" x2=""216"" y2=""148"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""40.00614"" y1=""188"" x2=""168"" y2=""188"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
							</svg>
						</button>

						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<line x1=""40"" y1=""68"" x2=""216"" y2=""68"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""64"" y1=""108"" x2=""192"" y2=""108"" fill=""none"" stroke=""#000000"" strok");
                WriteLiteral(@"e-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""40.00307"" y1=""148"" x2=""215.99693"" y2=""148"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""64.00307"" y1=""188"" x2=""191.99693"" y2=""188"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
							</svg>
						</button>

						<button class=""editor-barra-item icone"">
							<svg xmlns=""http://www.w3.org/2000/svg"" width=""192"" height=""192"" fill=""#000000"" viewBox=""0 0 256 256"">
								<rect width=""256"" height=""256"" fill=""none""></rect>
								<line x1=""40"" y1=""68"" x2=""216"" y2=""68"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""88"" y1=""108"" x2=""216"" y2=""108"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""40.00614"" y1=""148"" x2=""216"" y2=""148"" fill=""none"" strok");
                WriteLiteral(@"e=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
								<line x1=""88.00614"" y1=""188"" x2=""216"" y2=""188"" fill=""none"" stroke=""#000000"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""16""></line>
							</svg>
						</button>
					</div>
					<div>

							");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd14f541d60aef1a57e6c21e51df5207ea5751930990", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 244 "C:\Users\HF-NTB-04\Documents\Projetos\2022\Rich_text\Views\Texto\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Documento);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\t\t\t\t\r\n\t\t\t</div>\r\n\t\t</main>\r\n\t</div>\r\n\t<script>\r\n\t\t\r\n\t</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextoModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

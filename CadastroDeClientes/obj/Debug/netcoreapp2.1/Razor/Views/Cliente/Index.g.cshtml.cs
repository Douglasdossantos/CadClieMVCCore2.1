#pragma checksum "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937a533016bac9576a0a81fe3d2dfa19d0f9492c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Index.cshtml", typeof(AspNetCore.Views_Cliente_Index))]
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
#line 1 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\_ViewImports.cshtml"
using CadastroDeClientes;

#line default
#line hidden
#line 2 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\_ViewImports.cshtml"
using CadastroDeClientes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"937a533016bac9576a0a81fe3d2dfa19d0f9492c", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c6a21f97c118804bddab8ab8f058aecbacda7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CadastroDeClientes.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 85, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p class=\"row\">\r\n    <button  type=\"button\" class=\"btn btn-info\">");
            EndContext();
            BeginContext(183, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "141380b17a3f41fcb231b2bbadeee807", async() => {
                BeginContext(208, 12, true);
                WriteLiteral("Novo Cliente");
                EndContext();
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
            EndContext();
            BeginContext(224, 103, true);
            WriteLiteral("</button>\r\n\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(328, 38, false);
#line 17 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(366, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(422, 40, false);
#line 20 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(462, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(518, 50, false);
#line 23 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(568, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(624, 40, false);
#line 26 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
            EndContext();
            BeginContext(664, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(720, 53, false);
#line 29 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndCliente.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(773, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(829, 53, false);
#line 32 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndCliente.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(882, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1000, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1049, 37, false);
#line 41 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1142, 39, false);
#line 44 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1237, 49, false);
#line 47 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1342, 39, false);
#line 50 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1437, 52, false);
#line 53 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndCliente.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1489, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1545, 52, false);
#line 56 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndCliente.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 101, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button type=\"button\" class=\"btn btn-success\">");
            EndContext();
            BeginContext(1699, 65, false);
#line 59 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
                                                         Write(Html.ActionLink("Visualizar", "Visualizar", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 74, true);
            WriteLiteral(" </button>\r\n                <button type=\"button\" class=\"btn btn-warning\">");
            EndContext();
            BeginContext(1839, 57, false);
#line 60 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
                                                         Write(Html.ActionLink("Editar", "Editar", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 73, true);
            WriteLiteral(" </button>\r\n                <button type=\"button\" class=\"btn btn-danger\">");
            EndContext();
            BeginContext(1970, 58, false);
#line 61 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
                                                        Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 45, true);
            WriteLiteral("</button>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Douglas\source\repos\CadastroDeClientes\CadastroDeClientes\Views\Cliente\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2076, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CadastroDeClientes.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "D:\Projetos\LojaVirtualDaCris\LojaVirtualDaCris\LojaVirtual\Views\Home\CadastroCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d316a6f6409c86c13dd6057838c23d584164154"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CadastroCliente), @"mvc.1.0.view", @"/Views/Home/CadastroCliente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d316a6f6409c86c13dd6057838c23d584164154", @"/Views/Home/CadastroCliente.cshtml")]
    public class Views_Home_CadastroCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projetos\LojaVirtualDaCris\LojaVirtualDaCris\LojaVirtual\Views\Home\CadastroCliente.cshtml"
  
    ViewData["title"] = "Cadastro";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main role=""main"">

    <section class=""container"" style=""margin-top: 50px"">
        <div class=""row"">
            <aside class=""col-sm-6"">
                <h3 class=""subtitle-doc"">
                    # Register simple
                    <a href=""#"" data-html=""code_register_1"" class=""showcode"">[code]</a>
                </h3>
                <div id=""code_register_1"">
                    <div class=""card"">
                        <header class=""card-header"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 551, "\"", 558, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""float-right btn btn-outline-primary mt-1"">Log in</a>
                            <h4 class=""card-title mt-2"">Sign up</h4>
                        </header>
                        <article class=""card-body"">
                            <form>
                                <div class=""form-row"">
                                    <div class=""col form-group"">
                                        <label>First name</label>
                                        <input type=""text"" class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1083, "\"", 1097, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div> <!-- form-group end.// -->
                                    <div class=""col form-group"">
                                        <label>Last name</label>
                                        <input type=""text"" class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1383, "\"", 1397, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div> <!-- form-group end.// -->
                                </div> <!-- form-row end.// -->
                                <div class=""form-group"">
                                    <label>Email address</label>
                                    <input type=""email"" class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1737, "\"", 1751, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <small class=""form-text text-muted"">
                                        We'll never share your email with anyone
                                        else.
                                    </small>
                                </div> <!-- form-group end.// -->
                                <div class=""form-group"">
                                    <label class=""form-check form-check-inline"">
                                        <input class=""form-check-input"" type=""radio"" name=""gender"" value=""option1"">
                                        <span class=""form-check-label""> Male </span>
                                    </label>
                                    <label class=""form-check form-check-inline"">
                                        <input class=""form-check-input"" type=""radio"" name=""gender"" value=""option2"">
                                        <span class=""form-check-label""> Female</span>
                              ");
            WriteLiteral(@"      </label>
                                </div> <!-- form-group end.// -->
                                <div class=""form-row"">
                                    <div class=""form-group col-md-6"">
                                        <label>City</label>
                                        <input type=""text"" class=""form-control"">
                                    </div> <!-- form-group end.// -->
                                    <div class=""form-group col-md-6"">
                                        <label>Country</label>
                                        <select id=""inputState"" class=""form-control"">
                                            <option> Choose...</option>
                                            <option>Uzbekistan</option>
                                            <option>Russia</option>
                                            <option");
            BeginWriteAttribute("selected", " selected=\"", 3688, "\"", 3699, 0);
            EndWriteAttribute();
            WriteLiteral(@">United States</option>
                                            <option>India</option>
                                            <option>Afganistan</option>
                                        </select>
                                    </div> <!-- form-group end.// -->
                                </div> <!-- form-row.// -->
                                <div class=""form-group"">
                                    <label>Create password</label>
                                    <input class=""form-control"" type=""password"">
                                </div> <!-- form-group end.// -->
                                <div class=""form-group"">
                                    <button type=""submit"" class=""btn btn-primary btn-block""> Register </button>
                                </div> <!-- form-group// -->
                                <small class=""text-muted"">
                                    By clicking the 'Sign Up' button, you confirm that you
               ");
            WriteLiteral(@"                     accept our <br> Terms of use and Privacy Policy.
                                </small>
                            </form>
                        </article> <!-- card-body end .// -->
                        <div class=""border-top card-body text-center"">Have an account? <a");
            BeginWriteAttribute("href", " href=\"", 5026, "\"", 5033, 0);
            EndWriteAttribute();
            WriteLiteral(">Log In</a></div>\r\n                    </div> <!-- card.// -->\r\n\r\n                </div> <!-- code-wrap.// -->\r\n            </aside>\r\n        </div>\r\n    </section>\r\n\r\n</main>");
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

#pragma checksum "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea4047b5c0cf7df7f20fd7ba2b2d29b7622f2d69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Historique_pdf), @"mvc.1.0.view", @"/Views/Historique/pdf.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\_ViewImports.cshtml"
using App.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\_ViewImports.cshtml"
using App.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea4047b5c0cf7df7f20fd7ba2b2d29b7622f2d69", @"/Views/Historique/pdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c602c57965ce5caca06038002963a0a362a30e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Historique_pdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<App.Domain.Invoice>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml"
  

    ViewData["Title"] = "pdf";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4047b5c0cf7df7f20fd7ba2b2d29b7622f2d693934", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n<style>\r\n    table, th, td {\r\n        border: 1px solid black;\r\n    }\r\n</style>\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4047b5c0cf7df7f20fd7ba2b2d29b7622f2d695205", async() => {
                WriteLiteral("\r\n    <div class=\"htmlstuff\">\r\n        <h2>Invoice</h2>\r\n");
#nullable restore
#line 28 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml"
           
            float amount = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table style=""width:100%"" class=""table-bordered"">
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Invoice number</th>
                    <th>Invoice amount</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 39 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml"
                 foreach (var Invoice in Model)
                {
                    amount += float.Parse(Invoice.InvoiceAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <th>");
#nullable restore
#line 43 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml"
                       Write(Invoice.InvoiceDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 44 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml"
                       Write(Invoice.InvoiceID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 45 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml"
                       Write(Invoice.InvoiceAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td colspan=\"2\">Total des factures:</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml"
                   Write(Json.Serialize(amount));

#line default
#line hidden
#nullable disable
                WriteLiteral(" DT</td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n");
                WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n        <div class=\"mt-5\">\r\n            <button class=\"btn btn-primary\" id=\"btngenerate\">Generate Pdf</button>\r\n        </div>\r\n    ");
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
            WriteLiteral(@"
    <script type=""text/javascript"">
        $(""#btngenerate"").click(function () {
        var htmldata = $("".htmlstuff"").html();
        htmldata = htmldata.replace(/</g, ""strtTag"").replace(/>/g, ""EndTag"");
           // window.location = window.location.origin + '/Historique/GeneratePdf?html=' + htmldata;
            $.post(window.location.origin + '/Historique/GeneratePdf',
                {
                    html: htmldata,
                    lst:'");
#nullable restore
#line 75 "C:\Users\USER\source\repos\Extract\stage\App.Web\Views\Historique\pdf.cshtml"
                    Write(Json.Serialize(Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n                }\r\n            );\r\n        });\r\n    </script>\r\n \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<App.Domain.Invoice>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

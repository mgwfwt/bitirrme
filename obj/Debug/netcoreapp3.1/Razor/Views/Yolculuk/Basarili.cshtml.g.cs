#pragma checksum "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b0ef5bfdea7604ec2c6653b677fb3e1b121d81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Yolculuk_Basarili), @"mvc.1.0.view", @"/Views/Yolculuk/Basarili.cshtml")]
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
#line 1 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\_ViewImports.cshtml"
using BatuhanBilet.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\_ViewImports.cshtml"
using batuhanbilet.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\_ViewImports.cshtml"
using BatuhanBilet.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b0ef5bfdea7604ec2c6653b677fb3e1b121d81", @"/Views/Yolculuk/Basarili.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1a60f60aa5d47a878508b866a8a4a4fc6529f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Yolculuk_Basarili : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BiletGuzergah>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "iletisim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container shadow\" style=\"text-align:center;\">\r\n    <br />\r\n    <i class=\"fas fa-check-circle\" style=\"font-size:36px; color:green;\"></i><br />\r\n    <br /><p> Sayın ");
#nullable restore
#line 6 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.bilet.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
                               Write(Model.bilet.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 6 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
                                                   Write(Model.bilet.Nereden);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -> ");
#nullable restore
#line 6 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
                                                                           Write(Model.bilet.Nereye);

#line default
#line hidden
#nullable disable
            WriteLiteral(" için bilet alma işleminiz başarılı.</p> <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b0ef5bfdea7604ec2c6653b677fb3e1b121d815178", async() => {
                WriteLiteral("İletişim");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <br /><hr /><br />
    <h3>Bilet Bilgileriniz</h3><br />
    
    <table class=""table table table-bordered shadow-sm"">
        <thead>
            <tr>
                <th style=""width:40px;"">Bilet No</th>
                <th style=""width:200px;"">Ad - Soyad</th>
                <th");
            BeginWriteAttribute("style", " style=\"", 686, "\"", 694, 0);
            EndWriteAttribute();
            WriteLiteral(@">Mail</th>
                <th style=""width:105px;"">Başlangıç</th>
                <th style=""width:105px;"">Bitiş</th>
                <th style=""width:60px;"">KoltukNo</th>
                <th style=""width:80px;"">Fiyat</th>
                <th style=""width:200px;"">Tarih - Saat</th>
                
                <th style=""width:75px;"">Sefer No</th>

            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 29 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.bilet.BiletId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.bilet.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
                               Write(Model.bilet.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 32 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.bilet.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.bilet.Nereden);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.bilet.Nereye);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.bilet.KoltukNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.bilet.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.tarih);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 37 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
                              Write(Model.saat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n                <td>");
#nullable restore
#line 39 "C:\Users\batuhanh\Desktop\batuhanbilet\BatuhanBilet.webui\Views\Yolculuk\Basarili.cshtml"
               Write(Model.bilet.GuzergahId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <br />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BiletGuzergah> Html { get; private set; }
    }
}
#pragma warning restore 1591

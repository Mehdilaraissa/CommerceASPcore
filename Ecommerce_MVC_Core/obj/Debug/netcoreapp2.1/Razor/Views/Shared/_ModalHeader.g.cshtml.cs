#pragma checksum "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\Shared\_ModalHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9dd2cb7f75e5d8fe8496253155d8d21d25ac7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModalHeader), @"mvc.1.0.view", @"/Views/Shared/_ModalHeader.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ModalHeader.cshtml", typeof(AspNetCore.Views_Shared__ModalHeader))]
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
#line 1 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core;

#line default
#line hidden
#line 2 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Models;

#line default
#line hidden
#line 4 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
#line 5 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.BootstrapModal;

#line default
#line hidden
#line 6 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9dd2cb7f75e5d8fe8496253155d8d21d25ac7a", @"/Views/Shared/_ModalHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cfa9c3ae2f1e0493d4ca25e3a3394ef37b5862", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ModalHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce_MVC_Core.BootstrapModal.ModalHeader>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 153, true);
            WriteLiteral("\n<div class=\"modal-header\">\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>\n    <h4 class=\"modal-title\">");
            EndContext();
            BeginContext(207, 13, false);
#line 5 "C:\Users\Ultrapc\Desktop\workspace3\Project-main\Ecommerce_MVC_Core\Views\Shared\_ModalHeader.cshtml"
                       Write(Model.Heading);

#line default
#line hidden
            EndContext();
            BeginContext(220, 12, true);
            WriteLiteral("</h4>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce_MVC_Core.BootstrapModal.ModalHeader> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e6bf7c3d914f0eb939ae95eaf004a8a7137160"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
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
#line 1 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\_ViewImports.cshtml"
using Knowledge.Web.IdentityProvider;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\_ViewImports.cshtml"
using Knowledge.Web.IdentityProvider.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e6bf7c3d914f0eb939ae95eaf004a8a7137160", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a826902beab5dcd031c3850c6d35b0e39134f40", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Knowledge.Web.IdentityProvider.Controllers.ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck\"\r\n               type=\"checkbox\"\r\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\r\n               id=\"", 223, "\"", 262, 2);
            WriteAttributeValue("", 244, "scopes_", 244, 7, true);
#nullable restore
#line 8 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 251, Model.Name, 251, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n               value=\"", 263, "\"", 298, 1);
#nullable restore
#line 9 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 287, Model.Name, 287, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\r\n               checked=\"", 299, "\"", 339, 1);
#nullable restore
#line 10 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 325, Model.Checked, 325, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\r\n               disabled=\"", 340, "\"", 382, 1);
#nullable restore
#line 11 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 367, Model.Required, 367, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"\r\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 504, "\"", 543, 1);
#nullable restore
#line 16 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 532, Model.Name, 532, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>");
#nullable restore
#line 18 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 19 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
#nullable restore
#line 22 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </label>\r\n");
#nullable restore
#line 24 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><em>(required)</em></span>\r\n");
#nullable restore
#line 27 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 931, "\"", 955, 2);
            WriteAttributeValue("", 937, "scopes_", 937, 7, true);
#nullable restore
#line 31 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 944, Model.Name, 944, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 33 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Knowledge.Web.IdentityProvider.Controllers.ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

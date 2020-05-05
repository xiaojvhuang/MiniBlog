#pragma checksum "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "520d5b7572e5a1cc660be6a0834d51511afd36a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Posts), @"mvc.1.0.view", @"/Views/Home/Posts.cshtml")]
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
#line 1 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\_ViewImports.cshtml"
using MiniBlog.App.ManageUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\_ViewImports.cshtml"
using MiniBlog.App.ManageUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520d5b7572e5a1cc660be6a0834d51511afd36a4", @"/Views/Home/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db158fbfb8cfd78e3ed9fcd182f8ecb3ccebc17", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MiniBlog.Core.ViewModels.ListView.ListPostViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action-url", "/Home/Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::MiniBlog.Core.Plugin.PagerTagHelper __MiniBlog_Core_Plugin_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
  
    ViewData["Title"] = "博文管理";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Posts</h4>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
           Write(Html.ActionLink("编辑", "Post", new { id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 37 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
           Write(Html.ActionLink("删除", "DeletePost", new { id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "520d5b7572e5a1cc660be6a0834d51511afd36a46655", async() => {
            }
            );
            __MiniBlog_Core_Plugin_PagerTagHelper = CreateTagHelper<global::MiniBlog.Core.Plugin.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__MiniBlog_Core_Plugin_PagerTagHelper);
            __MiniBlog_Core_Plugin_PagerTagHelper.ActionUrl = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 43 "D:\working2020\MiniBlog\MiniBlog.App.ManageUI\Views\Home\Posts.cshtml"
__MiniBlog_Core_Plugin_PagerTagHelper.Option = ViewBag.Options;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("option", __MiniBlog_Core_Plugin_PagerTagHelper.Option, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MiniBlog.Core.ViewModels.ListView.ListPostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/leelanarasimha/code/dotnettraining/HahaFunnyJokes/HahaFunnyJokes.Mvc/Views/Category/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e72855ac258155aa5c9f3d820724653be6c5ca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
#line 1 "/Users/leelanarasimha/code/dotnettraining/HahaFunnyJokes/HahaFunnyJokes.Mvc/Views/_ViewImports.cshtml"
using HahaFunnyJokes.Mvc;

#line default
#line hidden
#line 2 "/Users/leelanarasimha/code/dotnettraining/HahaFunnyJokes/HahaFunnyJokes.Mvc/Views/_ViewImports.cshtml"
using HahaFunnyJokes.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e72855ac258155aa5c9f3d820724653be6c5ca7", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a985291f42da37fbf02f340d1a8cf05916cbf95c", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HahaFunnyJokes.Domain.ViewModels.Admin.CategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(75, 30, true);
            WriteLiteral("\r\n<div>Categories List</div>\r\n");
            EndContext();
#line 7 "/Users/leelanarasimha/code/dotnettraining/HahaFunnyJokes/HahaFunnyJokes.Mvc/Views/Category/Index.cshtml"
 if (@Model.categories.Count > 0)
{

#line default
#line hidden
#line 9 "/Users/leelanarasimha/code/dotnettraining/HahaFunnyJokes/HahaFunnyJokes.Mvc/Views/Category/Index.cshtml"
 foreach (var category in @Model.categories)
 {

#line default
#line hidden
            BeginContext(193, 10, true);
            WriteLiteral("     <div>");
            EndContext();
            BeginContext(204, 13, false);
#line 11 "/Users/leelanarasimha/code/dotnettraining/HahaFunnyJokes/HahaFunnyJokes.Mvc/Views/Category/Index.cshtml"
     Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(217, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 12 "/Users/leelanarasimha/code/dotnettraining/HahaFunnyJokes/HahaFunnyJokes.Mvc/Views/Category/Index.cshtml"
 }

#line default
#line hidden
#line 12 "/Users/leelanarasimha/code/dotnettraining/HahaFunnyJokes/HahaFunnyJokes.Mvc/Views/Category/Index.cshtml"
  
}
else
{

#line default
#line hidden
            BeginContext(241, 39, true);
            WriteLiteral("    <div>No Categories. Add One</div>\r\n");
            EndContext();
#line 17 "/Users/leelanarasimha/code/dotnettraining/HahaFunnyJokes/HahaFunnyJokes.Mvc/Views/Category/Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HahaFunnyJokes.Domain.ViewModels.Admin.CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

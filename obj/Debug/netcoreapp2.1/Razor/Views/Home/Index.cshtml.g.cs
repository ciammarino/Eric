#pragma checksum "/Users/user/Source/CulinaryConsulting/CulinaryConsulting/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8572297d2be622d70af52059322e128201f6d46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/user/Source/CulinaryConsulting/CulinaryConsulting/Views/_ViewImports.cshtml"
using CulinaryConsulting;

#line default
#line hidden
#line 2 "/Users/user/Source/CulinaryConsulting/CulinaryConsulting/Views/_ViewImports.cshtml"
using CulinaryConsulting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8572297d2be622d70af52059322e128201f6d46", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ef2822f67e19994c15b7aa609a4c960d78563b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/user/Source/CulinaryConsulting/CulinaryConsulting/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2417, true);
            WriteLiteral(@"<div class=""row"">

</div>
<div class=""row"">
    <div class=""col"">
        <div class=""flexbox-container"">
            <div class=""flexbox-item"">
                This is going to be content.
            </div>
            <div class=""flexbox-item"">
                This is going to be content.
            </div>
            <div class=""flexbox-item"">
                This is going to be content.
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col"" style=""width:100%; font-size:2em; color:#f8898e;""><h1>This is Important Content Cause It's got a Big Heading</h1></div>
</div>

<script>//date

    var d = new Date;
    var x = d.toDateString();
    var day = d.getDay();
    var date = d.getDate();
    var month = d.getMonth();
    var year = d.getFullYear();

    var strDay = """";
    var strMonth = """";
    switch (day) {
        case 0:
            strDay = ""Sunday"";
            break;
        case 1:
            strDay = ""Monday"";
       ");
            WriteLiteral(@"     break;
        case 2:
            strDay = ""Tuesday"";
            break;
        case 3:
            strDay = ""Wednesday"";
            break;
        case 4:
            strDay = ""Thursday"";
            break;
        case 5:
            strDay = ""Friday"";
            break;
        case 6:
            strDay = ""Saturday""
            break;
        default:
            alert('Nobody Wins!');
    }

    switch (month) {
        case 0:
            strMonth = ""January"";
            break;
        case 1:
            strMonth = ""February"";
            break;
        case 2:
            strMonth = ""March"";
            break;
        case 3:
            strMonth = ""April"";
            break;
        case 4:
            strMonth = ""May"";
            break;
        case 5:
            strMonth = ""June"";
            break;
        case 6:
            strMonth = ""July"";
            break;
        case 7:
            strMonth = ""August"";
            break;
        case");
            WriteLiteral(@" 8:
            strMonth = ""September"";
            break;
        case 9:
            strMonth = ""October"";
            break;
        case 10:
            strMonth = ""November"";
            break;
        case 11:
            strMonth = ""December"";
            break;

    }

    today.text(strDay + "", "" + date + "" "" + strMonth + "", "" + year)</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

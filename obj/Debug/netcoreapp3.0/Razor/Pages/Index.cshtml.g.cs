#pragma checksum "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbe1d780bb70db18a60666954449449953e411b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(fxUI.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace fxUI.Pages
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
#line 1 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\_ViewImports.cshtml"
using fxUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe1d780bb70db18a60666954449449953e411b0", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc37252e1b62f15e741b319b04ac47ef8a95641", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Foreign Exchange</h1>
    <table class=""table table-bordered table-responsive table-hover"">
        <tr>
            <th>From File</th> 
            <th>Date</th>
            <th>Transaction Id </th>  
            <th>Source Currency </th>  
            <th>Destination Currency </th>  
            <th>Amount</th>  
            <th>Exchanged Amount</th>  
            <th>Exchange rate</th>
        </tr>
");
#nullable restore
#line 17 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
         foreach (var transaction in IndexModel.transactions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
               Write(transaction.FromFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
               Write(transaction.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
               Write(transaction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
               Write(transaction.SourceCurrency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
               Write(transaction.DestinationCurrency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
               Write(transaction.SourceAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
               Write(transaction.ConvertedAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
               Write(transaction.ExchangeRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\ccorcoran\dev\dotnet\fxUI\Pages\Index.cshtml"
        }  

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\javid\source\repos\ExportExcelFromDB\ExportExcelFromDB\Views\Home\ExportExcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14f172bfbbee9ddc89d8e88f5ec3383037d59426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ExportExcel), @"mvc.1.0.view", @"/Views/Home/ExportExcel.cshtml")]
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
#line 1 "C:\Users\javid\source\repos\ExportExcelFromDB\ExportExcelFromDB\Views\_ViewImports.cshtml"
using ExportExcelFromDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javid\source\repos\ExportExcelFromDB\ExportExcelFromDB\Views\_ViewImports.cshtml"
using ExportExcelFromDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f172bfbbee9ddc89d8e88f5ec3383037d59426", @"/Views/Home/ExportExcel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a0f19f9407692b9576409eb04206fea0b6408b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ExportExcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""form-group"">
    <div class=""form-control"">
        <input type=""button"" id=""get-userlist-excel"" value=""Get Excel Link"" />
    </div>

    <div class=""btn-group btn-export-excel2"">
        <button type=""button"" class=""btn btn-primary dropdown-toggle export-btn""
                data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <i class=""fa fa-file"" aria-hidden=""true""></i>
            <span>&nbsp;</span>
            Export
        </button>
        <div class=""dropdown-menu export-drop"">
            <a class=""dropdown-item"" id=""getReportRelatedNPCsExcel"" href=""javascript:;"" onclick=""document.getElementById('excel-link').click();"">
                <i class=""fa fa-file-excel-o"" aria-hidden=""true""></i>
                <span>&nbsp;</span>
                Excel
            </a>
            <a");
            BeginWriteAttribute("href", " href=\"", 857, "\"", 864, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""disp-none"" id=""excel-link""></a>
            <!--  <a class=""dropdown-item pdf-btn"" id=""getExpReportCampPdf"" href=""#"">
                <i class=""fa fa-file-pdf-o pdf-btn"" aria-hidden=""true""></i>
                <span class=""pdf-btn"">&nbsp;</span>
                PDF
            </a>-->
        </div>
    </div>
</div>
<script src=""https://code.jquery.com/jquery-3.6.0.js"" 
        integrity=""sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk="" crossorigin=""anonymous"">

</script>
<script>
    $(document).on('click', '#get-userlist-excel', function () {
        $.ajax({
            type: 'POST',
            url: '/Home/GetExcelLink',
            success: function (link) {
                document.getElementById('excel-link').setAttribute('href', res.link.result);            }
        })
    });
</script>");
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

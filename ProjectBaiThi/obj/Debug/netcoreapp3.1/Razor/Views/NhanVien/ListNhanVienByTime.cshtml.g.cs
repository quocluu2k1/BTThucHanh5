#pragma checksum "F:\Học Tập\Xây dựng HTTT trên các framework\ProjectBaiThi\ProjectBaiThi\Views\NhanVien\ListNhanVienByTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4869dbb217f03b2be3e67f6afce29aa51bf486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_ListNhanVienByTime), @"mvc.1.0.view", @"/Views/NhanVien/ListNhanVienByTime.cshtml")]
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
#line 1 "F:\Học Tập\Xây dựng HTTT trên các framework\ProjectBaiThi\ProjectBaiThi\Views\_ViewImports.cshtml"
using ProjectBaiThi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Học Tập\Xây dựng HTTT trên các framework\ProjectBaiThi\ProjectBaiThi\Views\_ViewImports.cshtml"
using ProjectBaiThi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4869dbb217f03b2be3e67f6afce29aa51bf486", @"/Views/NhanVien/ListNhanVienByTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae9cebe789c672cfe62960941bbd8bb312b97dd7", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_ListNhanVienByTime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NhanVienvaSoLanSua>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Học Tập\Xây dựng HTTT trên các framework\ProjectBaiThi\ProjectBaiThi\Views\NhanVien\ListNhanVienByTime.cshtml"
  
    ViewData["Title"] = "Liệt số số lần sửa theo từng nhân viên";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table border=\"1\">\r\n    <tr>\r\n        <th>Tên Nhân Viên</th>\r\n        <th>Số Điện Thoại</th>\r\n        <th>Số Lần Sửa</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 12 "F:\Học Tập\Xây dựng HTTT trên các framework\ProjectBaiThi\ProjectBaiThi\Views\NhanVien\ListNhanVienByTime.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 16 "F:\Học Tập\Xây dựng HTTT trên các framework\ProjectBaiThi\ProjectBaiThi\Views\NhanVien\ListNhanVienByTime.cshtml"
           Write(item.GetType().GetProperty("HoTen").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "F:\Học Tập\Xây dựng HTTT trên các framework\ProjectBaiThi\ProjectBaiThi\Views\NhanVien\ListNhanVienByTime.cshtml"
           Write(item.GetType().GetProperty("SDT").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "F:\Học Tập\Xây dựng HTTT trên các framework\ProjectBaiThi\ProjectBaiThi\Views\NhanVien\ListNhanVienByTime.cshtml"
           Write(item.GetType().GetProperty("SoLan").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "F:\Học Tập\Xây dựng HTTT trên các framework\ProjectBaiThi\ProjectBaiThi\Views\NhanVien\ListNhanVienByTime.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NhanVienvaSoLanSua>> Html { get; private set; }
    }
}
#pragma warning restore 1591

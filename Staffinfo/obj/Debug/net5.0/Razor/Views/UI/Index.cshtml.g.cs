#pragma checksum "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cccf330001b73c64b0dcecb21426465ef9bf432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UI_Index), @"mvc.1.0.view", @"/Views/UI/Index.cshtml")]
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
#line 1 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\_ViewImports.cshtml"
using Staffinfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\_ViewImports.cshtml"
using Staffinfo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cccf330001b73c64b0dcecb21426465ef9bf432", @"/Views/UI/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27468b1ed7d327b8b54c01fb731dbd306c4eb191", @"/Views/_ViewImports.cshtml")]
    public class Views_UI_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Staffinfo.Models.StaffViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1> All staffs</h1>
<div class=""row col-sm-6"">
    <div class=""col-sm-6 form-group"">
        <input id=""txtVal"" class=""form-control mr-sm-2"" type=""text"" placeholder=""Search"" aria-label=""Search"">

    </div>
    <div class=""col-sm-6 form-group"">
        <button class=""btn btn-primary"" id=""btnSearch""> Search</button>

    </div>
</div>

<div id=""staffList""></div>
<table class=""table table-bordered table-responsive table-hover"">
    <thead class=""thead-light"">
        <tr>
            <th>ID</th>
            <th>Full Name</th>
            <th>Address</th>
            <th>Gender</th>
            <th>Action</th>
            <th>Image</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
         foreach (var item in Model.StaffList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
               Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
               Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "UI", new { id = item.Id }, new { @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 39 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", "UI", new { id = item.Id }, new { @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral("                </td>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1605, "\"", 1625, 1);
#nullable restore
#line 44 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
WriteAttributeValue("", 1611, item.FilePath, 1611, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"100\" />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\UI\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </tbody>
</table>
<div id=""staffList""></div>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script type=""text/javascript"">
    $(function () {
        $(""#btnSearch"").click(function () {
            $.ajax({
                type: ""GET"",
                url: ""/UI/_PartialStaff"",
                type: 'GET',
                data: {
                    val: $('#txtVal').val(),

                },
                success: function (response) {
                    $('#staffList').empty();
                    $('#staffList').html(response);
                },
                failure: function (response) {
                    alert(response.responseText);
                },
                error: function (response) {
                    alert(response.responseText);
                }
            });
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Staffinfo.Models.StaffViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
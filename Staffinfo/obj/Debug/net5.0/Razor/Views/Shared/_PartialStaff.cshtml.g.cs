#pragma checksum "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\Shared\_PartialStaff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81787593452a8f309688dfd02f227ebfc06cbd9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialStaff), @"mvc.1.0.view", @"/Views/Shared/_PartialStaff.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81787593452a8f309688dfd02f227ebfc06cbd9f", @"/Views/Shared/_PartialStaff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27468b1ed7d327b8b54c01fb731dbd306c4eb191", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialStaff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Staffinfo.Models.StaffViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\Shared\_PartialStaff.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\Shared\_PartialStaff.cshtml"
 foreach (var item in Model.StaffList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 8 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\Shared\_PartialStaff.cshtml"
       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\Shared\_PartialStaff.cshtml"
       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 10 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\Shared\_PartialStaff.cshtml"
       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 11 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\Shared\_PartialStaff.cshtml"
       Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 273, "\"", 293, 1);
#nullable restore
#line 13 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\Shared\_PartialStaff.cshtml"
WriteAttributeValue("", 279, item.FilePath, 279, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"100\" />\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Anjali\Desktop\Staffinfo\Staffinfo\Views\Shared\_PartialStaff.cshtml"
}

#line default
#line hidden
#nullable disable
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

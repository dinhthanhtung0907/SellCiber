#pragma checksum "C:\Users\traih\OneDrive\Máy tính\SellOfCiber\FrontEnd\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d3711130eaa1a8eb950c34a223026a61efd7563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\traih\OneDrive\Máy tính\SellOfCiber\FrontEnd\Views\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\traih\OneDrive\Máy tính\SellOfCiber\FrontEnd\Views\_ViewImports.cshtml"
using FrontEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3711130eaa1a8eb950c34a223026a61efd7563", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ea719869d0121793e2abdd0e78c4bddb249e5ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\traih\OneDrive\Máy tính\SellOfCiber\FrontEnd\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 53, "\"", 61, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    
    <input type=""text"" id=""myInput"" placeholder=""Tìm Kiếm""/>
    <button class=""btn-group-circle""  data-bind=""click: $root.search"">Tìm kiếm</button>
     <button class=""btn-group-circle"" id=""btnSearch"" data-bind=""click: $root.create"">Create</button>
</div>
<table class=""table"" id=""myTable"">
    <thead>
        <tr>
            <th>Product name</th>
            <th>Category name</th>
            <th>Customer name</th>
            <th>Order Date</th>

            <th>Amount</th>

            
        </tr>
    </thead>
    <tbody data-bind=""foreach:$root.arrays"" id=""myTable"">
        <tr>
            <td data-bind=""text:ProductName""></td>
            <td data-bind=""text:CategoryName""></td>
            <td data-bind=""text:ApplicationUserUserName""></td>
            <td data-bind=""text:OrderDate""></td>
            <td data-bind=""text:Amount""></td>         
        </tr>

    </tbody>
</table>
<div id=""modal"" class=""modal"" tabindex=""-1"">
    <div class=""modal-dialog"">
        ");
            WriteLiteral(@"<div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Create new order</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""mb-3"" hidden>
                    <label class=""col-form-label"" for=""ordername"">order name: </label> 
                    <input class=""form-control"" type=""text"" id=""ordername"" /><br />
                </div>
                <div class=""mb-3"">
                    <label class=""col-form-label"" for=""Product"">Product: </label>
                    <select id=""Product"" data-bind=""options: $root.arrayproduct,
                                    optionsText: 'Name',
                                      optionsValue: 'Id',
                                      optionsCaption: 'chọn',
                                    "">
                    </select><br />
                </div>
 ");
            WriteLiteral(@"               <div class=""mb-3"">
                    <label class=""col-form-label"" for=""Customer"">Customer: </label>
                    <select id=""Customer"" data-bind=""options: $root.arrayCustomer,
                                      optionsText: 'UserName',
                                      optionsValue: 'Id',
                                      optionsCaption: 'chọn',
                                    "">
                    </select><br />
                </div>
                 <div class=""mb-3"">
                            <label class=""col-form-label"" for=""orderdate"">orderdate</label>
                            <input class=""form-control"" type=""date"" id=""orderdate"" />
                        </div>
                
               
                <div class=""mb-3"">
                    <label class=""col-form-label"" for=""Amount"">Amount: </label> 
                    <input class=""form-control"" type=""number"" id=""Amount""><br />
                </div>
                
       ");
            WriteLiteral(@"         <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Đóng</button>
                    <button type=""button"" class=""btn btn-primary"" data-bind=""click:$root.save"">Lưu</button>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d3711130eaa1a8eb950c34a223026a61efd75637199", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3500, "~/js/Manager/Order.js?v=", 3500, 24, true);
#nullable restore
#line 86 "C:\Users\traih\OneDrive\Máy tính\SellOfCiber\FrontEnd\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3524, DateTime.Now.ToString(" yyyyMMddhhmmss"), 3524, 41, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
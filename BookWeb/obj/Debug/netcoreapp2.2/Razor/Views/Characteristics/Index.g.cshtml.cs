#pragma checksum "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b941e9bf5511773812c7aa7483cdd90af40d9093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characteristics_Index), @"mvc.1.0.view", @"/Views/Characteristics/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Characteristics/Index.cshtml", typeof(AspNetCore.Views_Characteristics_Index))]
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
#line 1 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\_ViewImports.cshtml"
using BookWeb;

#line default
#line hidden
#line 2 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\_ViewImports.cshtml"
using BookWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b941e9bf5511773812c7aa7483cdd90af40d9093", @"/Views/Characteristics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba6b1b965d54a65f696aeef7f37afda1d7ae018", @"/Views/_ViewImports.cshtml")]
    public class Views_Characteristics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookWeb.Entities.Characteristics>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Characteristics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right hidden-sm-down btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
  
    ViewData["Title"] = "Characteristicss";

#line default
#line hidden
            BeginContext(108, 1171, true);
            WriteLiteral(@"
<div class=""row page-titles"">
    <div class=""col-md-5 align-self-center"">
        <h3 class=""text-themecolor""> Characteristicss </h3>
    </div>
</div>

<div class=""container"">
    <div class=""row "">
        <div class="" col-lg-12 "">
            <div class=""tm-bg-primary-dark tm-block tm-block-products"">
                <div class=""tm-product-table-container "">
                    <table class=""table table-hover tm-table-small tm-product-table align-self-center "">
                        <thead>
                            <tr>
                                <th scope=""col"">&nbsp;</th>
                                <th scope=""col"">#</th>
                                <th scope=""col"">Title</th>
                                <th scope=""col"">Length</th>
                                <th scope=""col"">Width</th>
                                <th scope=""col"">Pages</th>                                
                                <th scope=""col"">Date Created</th>
                ");
            WriteLiteral("                <th scope=\"col\">&nbsp;</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                             foreach (var characteristics in Model)
                            {

#line default
#line hidden
            BeginContext(1379, 144, true);
            WriteLiteral("                            <tr>\r\n                                <th scope=\"col\"> &nbsp;</th>\r\n                                <th scope=\"col\">");
            EndContext();
            BeginContext(1524, 18, false);
#line 36 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                                           Write(characteristics.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1542, 55, true);
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
            EndContext();
            BeginContext(1598, 21, false);
#line 37 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                                           Write(characteristics.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1619, 55, true);
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
            EndContext();
            BeginContext(1675, 26, false);
#line 38 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                                           Write(characteristics.Lengthincm);

#line default
#line hidden
            EndContext();
            BeginContext(1701, 55, true);
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
            EndContext();
            BeginContext(1757, 25, false);
#line 39 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                                           Write(characteristics.Widthincm);

#line default
#line hidden
            EndContext();
            BeginContext(1782, 55, true);
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
            EndContext();
            BeginContext(1838, 26, false);
#line 40 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                                           Write(characteristics.Numofpages);

#line default
#line hidden
            EndContext();
            BeginContext(1864, 55, true);
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
            EndContext();
            BeginContext(1920, 27, false);
#line 41 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                                           Write(characteristics.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 104, true);
            WriteLiteral("</th>\r\n                                <th scope=\"col\">&nbsp;</th>\r\n                                <td>");
            EndContext();
            BeginContext(2051, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b941e9bf5511773812c7aa7483cdd90af40d90939557", async() => {
                BeginContext(2140, 65, true);
                WriteLiteral("<i class=\"fa fa-pen\" style=\"color:white;\" aria-hidden=\"true\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                                                                                            WriteLiteral(characteristics.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2209, 44, true);
            WriteLiteral(" </td>\r\n                                <td>");
            EndContext();
            BeginContext(2253, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b941e9bf5511773812c7aa7483cdd90af40d909312272", async() => {
                BeginContext(2344, 69, true);
                WriteLiteral("<i class=\"fa fa-trash\" style=\"color:darkred;\" aria-hidden=\"true\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                                                                                              WriteLiteral(characteristics.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2417, 43, true);
            WriteLiteral(" </td>\r\n                            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\siji4\Documents\Cyberspace\BookWeb\BookWeb\Views\Characteristics\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2489, 177, true);
            WriteLiteral(",\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <div class=\"col-md-12 col-12 align-self-center\">\r\n                    ");
            EndContext();
            BeginContext(2666, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b941e9bf5511773812c7aa7483cdd90af40d909315447", async() => {
                BeginContext(2773, 54, true);
                WriteLiteral("<i class=\"mdi mdi-plus-circle\"></i>New Characteristics");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2831, 137, true);
            WriteLiteral("\r\n                </div>\r\n                <!-- table container -->\r\n\r\n\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookWeb.Entities.Characteristics>> Html { get; private set; }
    }
}
#pragma warning restore 1591

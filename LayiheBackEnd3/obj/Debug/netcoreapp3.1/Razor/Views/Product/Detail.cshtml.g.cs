#pragma checksum "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe6e3ee76914d2ef284505e8aa8542b7aa837e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\User\Desktop\LayiheBackEnd2\Views\_ViewImports.cshtml"
using LayiheBackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\LayiheBackEnd2\Views\_ViewImports.cshtml"
using LayiheBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\LayiheBackEnd2\Views\_ViewImports.cshtml"
using LayiheBackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe6e3ee76914d2ef284505e8aa8542b7aa837e9", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fe6e9028f7d8ce978d5ec4c342c63f2a01ba70e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("review-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getproduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("open-product-modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <main>
        <!-- breadcrumb area start -->
        <div class=""breadcrumb-area bg-img"" data-bg=""~/assets/img/banner/breadcrumb-banner.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""breadcrumb-wrap text-center"">
                            <nav aria-label=""breadcrumb"">
                                <h1 class=""breadcrumb-title"">shop</h1>
                                <ul class=""breadcrumb"">
                                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efe6e3ee76914d2ef284505e8aa8542b7aa837e96872", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efe6e3ee76914d2ef284505e8aa8542b7aa837e98302", async() => {
                WriteLiteral("Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                    <li class=""breadcrumb-item active"" aria-current=""page"">Product Details</li>
                                </ul>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- breadcrumb area end -->
        <!-- product details wrapper start -->
        <div class=""product-details-wrapper section-padding"">
            <div class=""container custom-container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <!-- product details inner end -->
                        <div class=""product-details-inner"">
                            <div class=""row"">
                                <div class=""col-lg-5"">
                                    <div class=""product-large-slider mb-20"">
                                        <div class=""pro-large-img img-zoom"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "efe6e3ee76914d2ef284505e8aa8542b7aa837e910493", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1798, "~/uploads/product/", 1798, 18, true);
#nullable restore
#line 35 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 1816, Model.Product.ProductImages.FirstOrDefault(x=>x.PosterStatus==true)?.Image, 1816, 75, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                      
                                    </div>
                                   
                                </div>
                                <div class=""col-lg-7"">
                                    <div class=""product-details-des"">
                                        <h3 class=""pro-det-title"">");
#nullable restore
#line 43 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                             Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                        <div class=""pro-review"">
                                            <span><a href=""#"">1 Review(s)</a></span>
                                        </div>
                                        <div class=""price-box"">

");
#nullable restore
#line 49 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                             if (Model.Product.DiscountPercent > 0)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"regular-price\">$");
#nullable restore
#line 52 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                                         Write((Model.Product.SalePrice * (1- Model.Product.DiscountPercent/100)).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <span class=\"old-price\"><del>$");
#nullable restore
#line 53 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                                         Write(Model.Product.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></span>\r\n");
#nullable restore
#line 54 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"regular-price\">$");
#nullable restore
#line 57 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                                        Write(Model.Product.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 58 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 62 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                       Write(Model.Product.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                        <div class=""quantity-cart-box d-flex align-items-center mb-20"">
                                            <div class=""quantity"">
                                                <div class=""pro-qty""><input type=""text"" value=""1""></div>
                                            </div>
                                            <a href=""cart.html"" class=""btn btn-default"">Add To Cart</a>
                                        </div>
                                        <div class=""availability mb-20"">
                                            <h5 class=""cat-title"">Availability:</h5>
                                            <span> ");
#nullable restore
#line 72 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                               Write(Model.Product.IsAvailable? "In Stock":"Out of Stock");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                        <div class=\"availability mb-20\">\r\n                                            <h5 class=\"cat-title\">Colors:</h5>\r\n\r\n");
#nullable restore
#line 77 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                             foreach (var item in Model.Product.ProductColors)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span>");
#nullable restore
#line 79 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                 Write(item.Color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 80 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                        </div>
                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- product details inner end -->
                        <!-- product details reviews start -->
                        <div class=""product-details-reviews section-padding"">
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <div class=""product-review-info"">
                                        <ul class=""nav review-tab"">
                                        
                                            <li>
                                                <a class=""active show"" data-toggle=""tab"" href=""#tab_three"">reviews</a>
                                            </li>
                                        </ul>
                      ");
            WriteLiteral("                  <div class=\"tab-content reviews-tab\">\r\n                                            \r\n                                            <div class=\"tab-pane fade active show\" id=\"tab_three\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efe6e3ee76914d2ef284505e8aa8542b7aa837e918967", async() => {
                WriteLiteral(@"
                                                    <h5>1 review for <span>Chaz Kangeroo Hoodies</span></h5>
                                                    <div class=""total-reviews"">
                                                        <div class=""rev-avatar"">
                                                            <img src=""assets/img/about/avatar.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6446, "\"", 6452, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                        </div>
                                                        <div class=""review-box"">
                                                            <div class=""ratings"">
                                                                <span class=""good""><i class=""fa fa-star""></i></span>
                                                                <span class=""good""><i class=""fa fa-star""></i></span>
                                                                <span class=""good""><i class=""fa fa-star""></i></span>
                                                                <span class=""good""><i class=""fa fa-star""></i></span>
                                                                <span><i class=""fa fa-star""></i></span>
                                                            </div>
                                                            <div class=""post-author"">
                                                            ");
                WriteLiteral(@"    <p><span>admin -</span> 30 Nov, 2018</p>
                                                            </div>
                                                            <p>Aliquam fringilla euismod risus ac bibendum. Sed sit amet sem varius ante feugiat lacinia. Nunc ipsum nulla, vulputate ut venenatis vitae, malesuada ut mi. Quisque iaculis, dui congue placerat pretium, augue erat accumsan lacus</p>
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <div class=""col"">
                                                            <label class=""col-form-label""><span class=""text-danger"">*</span> Your Name</label>
                                                            <input type=""text"" class=""form-control"" required>
                                                        </div>
              ");
                WriteLiteral(@"                                      </div>
                                                    <div class=""form-group row"">
                                                        <div class=""col"">
                                                            <label class=""col-form-label""><span class=""text-danger"">*</span> Your Email</label>
                                                            <input type=""email"" class=""form-control"" required>
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <div class=""col"">
                                                            <label class=""col-form-label""><span class=""text-danger"">*</span> Your Review</label>
                                                            <textarea class=""form-control"" required></textarea>
                        ");
                WriteLiteral(@"                                    <div class=""help-block pt-10""><span class=""text-danger"">Note:</span> HTML is not translated!</div>
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <div class=""col"">
                                                            <label class=""col-form-label""><span class=""text-danger"">*</span> Rating</label>
                                                            &nbsp;&nbsp;&nbsp; Bad&nbsp;
                                                            <input type=""radio"" value=""1"" name=""rating"">
                                                            &nbsp;
                                                            <input type=""radio"" value=""2"" name=""rating"">
                                                            &nbsp;
                            ");
                WriteLiteral(@"                                <input type=""radio"" value=""3"" name=""rating"">
                                                            &nbsp;
                                                            <input type=""radio"" value=""4"" name=""rating"">
                                                            &nbsp;
                                                            <input type=""radio"" value=""5"" name=""rating"" checked>
                                                            &nbsp;Good
                                                        </div>
                                                    </div>
                                                    <div class=""buttons"">
                                                        <button class=""sqr-btn"" type=""submit"">Continue</button>
                                                    </div>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" <!-- end of review-form -->
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- product details reviews end -->
                        <!-- featured product area start -->
                        <section class=""Related-product"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-12"">
                                        <div class=""section-title text-center"">
                                            <h2 class=""title"">Related Product</h2>
                                            <p class=""sub-title"">Lorem ipsum dolor sit amet consectetur adipisicing</p>
                                        </div>
                                    </div>
                   ");
            WriteLiteral("             </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-12\">\r\n                                        <div class=\"product-carousel-4 mbn-50 slick-row-15 slick-arrow-style\">\r\n\r\n");
#nullable restore
#line 185 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                             foreach (var item in Model.RelatedProducts)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""product-item mb-50"">
                                                    <div class=""product-thumb"">
                                                        <a href=""product-details.html"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efe6e3ee76914d2ef284505e8aa8542b7aa837e928124", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 13209, "~/uploads/product/", 13209, 18, true);
#nullable restore
#line 190 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 13227, item.ProductImages.FirstOrDefault(x=>x.PosterStatus==true)?.Image, 13227, 66, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </a>
                                                    </div>
                                                    <div class=""product-content"">
                                                        <h5 class=""product-name"">
                                                            <a href=""product-details.html"">");
#nullable restore
#line 195 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                        </h5>\r\n                                                        <div class=\"price-box\">\r\n");
#nullable restore
#line 198 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                             if (item.DiscountPercent > 0)
                                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"regular-price\">$");
#nullable restore
#line 201 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                                                         Write((item.SalePrice * (1- item.DiscountPercent/100)).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                                <span class=\"old-price\"><del>$");
#nullable restore
#line 202 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                                                         Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></span>\r\n");
#nullable restore
#line 203 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"regular-price\">$");
#nullable restore
#line 206 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                                                        Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 207 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"

                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </div>
                                                        <div class=""product-action-link"">
                                                            <a href=""#"" data-toggle=""tooltip"" title=""Wishlist""><i class=""ion-android-favorite-outline""></i></a>
                                                            <a href=""#"" data-toggle=""tooltip"" title=""Add To Cart""><i class=""ion-bag""></i></a>
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efe6e3ee76914d2ef284505e8aa8542b7aa837e933302", async() => {
                WriteLiteral("\r\n                                                                <i class=\"ion-ios-eye-outline\"></i>\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 213 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </div>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 219 "C:\Users\User\Desktop\LayiheBackEnd2\Views\Product\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                        <!-- featured product area end -->
                    </div>
                </div>
            </div>
        </div>
        <!-- product details wrapper end -->
    </main>
    <!-- main wrapper end -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f1b45087bfe616d67dea77eb2040b8a73ad88e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messenger_Chat), @"mvc.1.0.view", @"/Views/Messenger/Chat.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\_ViewImports.cshtml"
using Tinno;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\_ViewImports.cshtml"
using Tinno.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\_ViewImports.cshtml"
using Tinno.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f1b45087bfe616d67dea77eb2040b8a73ad88e6", @"/Views/Messenger/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74a654ede6d95d234ad5ad0ae7412e5ff10e6f24", @"/Views/_ViewImports.cshtml")]
    public class Views_Messenger_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmBase>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/media/svg/chat_empty.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
  
    ViewData["Title"] = "Chat";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- chat -->
<div class=""chat chat-page"">
    <!-- no-message -->
    <div class=""chat-preloader d-none"">
        <div class=""spinner-border"" role=""status"">
            <span class=""sr-only"">Loading...</span>
        </div>
    </div>
    <div class=""no-message-container"">
        <div class=""row mb-5"">
            <div class=""col-md-4 offset-4"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f1b45087bfe616d67dea77eb2040b8a73ad88e66065", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <p class=\"lead\">Choose a chat or start a <a href=\"#\" data-left-sidebar=\"friends\">new chat</a>.</p>\r\n    </div>\r\n    <div class=\"chat-header\">\r\n        <div class=\"chat-header-user\">\r\n");
#nullable restore
#line 26 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
             if (ViewBag.Friend.Image != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <figure");
            BeginWriteAttribute("id", " id=\"", 911, "\"", 934, 1);
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
WriteAttributeValue("", 916, ViewBag.Friend.Id, 916, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 935, "\"", 1015, 3);
            WriteAttributeValue("", 943, "avatar", 943, 6, true);
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
WriteAttributeValue(" ", 949, ViewBag.Friend.IsActive == true?"avatar-state-success":"", 950, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1010, "mr-3", 1011, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f1b45087bfe616d67dea77eb2040b8a73ad88e68649", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1049, "~/Uploads/Images/Accounts/", 1049, 26, true);
#nullable restore
#line 29 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
AddHtmlAttributeValue("", 1075, ViewBag.Friend.Image, 1075, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </figure>\r\n");
#nullable restore
#line 31 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <figure");
            BeginWriteAttribute("id", " id=\"", 1233, "\"", 1256, 1);
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
WriteAttributeValue("", 1238, ViewBag.Friend.Id, 1238, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1257, "\"", 1337, 3);
            WriteAttributeValue("", 1265, "avatar", 1265, 6, true);
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
WriteAttributeValue(" ", 1271, ViewBag.Friend.IsActive == true?"avatar-state-success":"", 1272, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1332, "mr-3", 1333, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span class=\"avatar-title bg-secondary rounded-circle\">");
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
                                                                      Write(ViewBag.FriendNameSubstring);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </figure>\r\n");
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <h5>");
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
               Write(ViewBag.Friend.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
                                    Write(ViewBag.Friend.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <small id=\"isActive\"");
            BeginWriteAttribute("class", " class=\"", 1621, "\"", 1692, 1);
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
WriteAttributeValue("", 1629, ViewBag.Friend.IsActive == true?"text-success":"text-danger", 1629, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
                                                                                                         Write(ViewBag.Friend.IsActive == true?"Online":"Offline");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>

            </div>
        </div>
        <div class=""chat-header-action"">
            <ul class=""list-inline"" data-intro-js=""7"">
                <li class=""list-inline-item d-inline d-lg-none"">
                    <a href=""#"" class=""btn btn-danger btn-floating example-chat-close"">
                        <i class=""mdi mdi-arrow-left""></i>
                    </a>
                </li>
                <li class=""list-inline-item"" data-toggle=""tooltip"" title=""Voice call"">
                    <a href=""#"" class=""btn btn-info btn-floating"" data-right-sidebar=""notifications"">
                        <i class=""mdi mdi-bell-outline""></i>
                    </a>
                </li>
                <li class=""list-inline-item"" data-toggle=""tooltip"" title=""Voice call"">
                    <a href=""#"" class=""btn btn-success btn-floating voice-call-request"">
                        <i class=""mdi mdi-phone""></i>
                    </a>
                </li>
                <li class=""lis");
            WriteLiteral(@"t-inline-item"" data-toggle=""tooltip"" title=""Video call"">
                    <a href=""#"" class=""btn btn-warning btn-floating video-call-request"">
                        <i class=""mdi mdi-video-outline""></i>
                    </a>
                </li>
                <li class=""list-inline-item"">
                    <a href=""#"" class=""btn btn-dark btn-floating"" data-toggle=""dropdown"">
                        <i class=""mdi mdi-dots-horizontal""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a href=""#"" data-right-sidebar=""user-profile"" class=""dropdown-item"">Profile</a>
                        <a href=""#"" class=""dropdown-item example-close-selected-chat"">Close chat</a>
                        <a href=""#"" class=""dropdown-item"">Add to archive</a>
                        <a href=""#"" class=""dropdown-item example-delete-chat"">Delete</a>
                        <div class=""dropdown-divider""></div>
                        <a hr");
            WriteLiteral("ef=\"#\" class=\"dropdown-item text-danger example-block-user\">Block</a>\r\n                    </div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div class=\"chat-body cont\">\r\n        <div class=\"messages\" id=\"message-box\">\r\n");
#nullable restore
#line 84 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
             foreach (var message in Model.Messages)
            {
                if (ViewBag.Friend.Id == message.SenderId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"message-item in\">\r\n                        <div class=\"message-content\">\r\n                            <div class=\"message-text\">");
#nullable restore
#line 90 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
                                                 Write(message.MessageText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"time mt-2\">");
#nullable restore
#line 91 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
                                                  Write(message.Date.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 94 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"message-item out\">\r\n                        <div class=\"message-content\">\r\n                            <div class=\"message-text\">");
#nullable restore
#line 99 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
                                                 Write(message.MessageText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"time mt-2\">");
#nullable restore
#line 100 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
                                                  Write(message.Date.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 104 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"chat-footer\" data-intro-js=\"6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f1b45087bfe616d67dea77eb2040b8a73ad88e618508", async() => {
                WriteLiteral(@"
            <div class=""dropdown"">
                <button class=""btn btn-light-info btn-floating mr-3"" data-toggle=""dropdown"" title=""Emoji""
                        type=""button"">
                    <i class=""mdi mdi-face""></i>
                </button>
                <div class=""dropdown-menu dropdown-menu-big p-0"">
                    <div class=""dropdown-menu-search"">
                        <input type=""text"" class=""form-control"" placeholder=""Search emoji"">
                    </div>
                    <div class=""emojis chat-emojis"">
                        <ul>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                        ");
                WriteLiteral(@"    <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                            <li>????</li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""dropdown"">
                <button class=""btn btn-light-inf");
                WriteLiteral(@"o btn-floating mr-3"" data-toggle=""dropdown"" title=""Emoji""
                        type=""button"">
                    <i class=""mdi mdi-plus""></i>
                </button>
                <div class=""dropdown-menu"">
                    <a href=""#"" class=""dropdown-item"">Location</a>
                    <a href=""#"" class=""dropdown-item"">Attach</a>
                    <a href=""#"" class=""dropdown-item"">Document</a>
                    <a href=""#"" class=""dropdown-item"">File</a>
                    <a href=""#"" class=""dropdown-item"">Video</a>
                </div>
            </div>

            <div id=""message-input"" style=""width:100%"">
                <input type=""text"" id=""message"" class=""form-control form-control-main"" placeholder=""Write a message."">
                <input hidden id=""friend-id""");
                BeginWriteAttribute("value", " value=\"", 8633, "\"", 8659, 1);
#nullable restore
#line 188 "C:\Users\ASUS\source\repos\Tinno\Tinno\Views\Messenger\Chat.cshtml"
WriteAttributeValue("", 8641, ViewBag.Friend.Id, 8641, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <button class=\"btn btn-primary ml-2 btn-floating\" id=\"sendButton\">\r\n                <i class=\"mdi mdi-send\"></i>\r\n            </button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<!-- ./ chat -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmBase> Html { get; private set; }
    }
}
#pragma warning restore 1591

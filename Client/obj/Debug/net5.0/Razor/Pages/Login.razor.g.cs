#pragma checksum "E:\Bug-Tracker\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54395b6a68900c72e9856a2ca248e11fc80e8ceb"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Bug-Tracker\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Bug-Tracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Bug-Tracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Bug-Tracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Bug-Tracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Bug-Tracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Bug-Tracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Bug-Tracker\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Bug-Tracker\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Bug-Tracker\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Bug-Tracker\Client\Pages\Login.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style b-qqczw58t74>\r\n    body {\r\n        background: rgb(112,58,180);\r\n        background: linear-gradient(90deg, rgba(112,58,180,1) 14%, rgba(29,141,253,1) 73%, rgba(69,99,252,1) 100%);\r\n    }\r\n</style>\r\n\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "b-qqczw58t74");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddAttribute(6, "b-qqczw58t74");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-xs-12 child");
            __builder.AddAttribute(9, "b-qqczw58t74");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                 user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "id", "myModal");
                __builder2.AddAttribute(17, "b-qqczw58t74");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "modal-dialog modal-login");
                __builder2.AddAttribute(20, "b-qqczw58t74");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "modal-content");
                __builder2.AddAttribute(23, "b-qqczw58t74");
                __builder2.AddMarkupContent(24, "<div class=\"modal-header\" b-qqczw58t74><h4 class=\"modal-title\" b-qqczw58t74>Log in</h4></div>\r\n                                ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "modal-body");
                __builder2.AddAttribute(27, "b-qqczw58t74");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddAttribute(30, "b-qqczw58t74");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "type", "text");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "placeholder", "Email");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                                                                     user.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.email = __value, user.email))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                                        ");
                __Blazor.Client.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 39, 40, 
#nullable restore
#line 25 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                  () => user.email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddAttribute(44, "b-qqczw58t74");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "type", "password");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "placeholder", "Password");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                                                                            user.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.password = __value, user.password))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                                        ");
                __Blazor.Client.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 53, 54, 
#nullable restore
#line 29 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                  () => user.password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                                    ");
                __builder2.AddMarkupContent(56, "<div class=\"form-group\" b-qqczw58t74><button ype=\"submit\" class=\"btn btn-primary btn-block btn-lg\" b-qqczw58t74>Log in</button></div>\r\n                                    ");
                __builder2.AddMarkupContent(57, "<p class=\"hint-text small\" b-qqczw58t74><a href=\"#\" b-qqczw58t74>Forgot Your Password?</a></p>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            <div class=\"emptyDiv col-xs-12\" b-qqczw58t74></div>\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-xs-12 anotherChild");
            __builder.AddAttribute(61, "b-qqczw58t74");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(62);
            __builder.AddAttribute(63, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 43 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                 user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(65);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "id", "myModal");
                __builder2.AddAttribute(69, "b-qqczw58t74");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "modal-dialog modal-login");
                __builder2.AddAttribute(72, "b-qqczw58t74");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "modal-content");
                __builder2.AddAttribute(75, "b-qqczw58t74");
                __builder2.AddMarkupContent(76, "<div class=\"modal-header\" b-qqczw58t74><h4 class=\"modal-title\" b-qqczw58t74>Sign up</h4></div>\r\n                                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "modal-body");
                __builder2.AddAttribute(79, "b-qqczw58t74");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddAttribute(82, "b-qqczw58t74");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "type", "text");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "placeholder", "Name");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                                                                    user.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.name = __value, user.name))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n                                        ");
                __Blazor.Client.Pages.Login.TypeInference.CreateValidationMessage_2(__builder2, 91, 92, 
#nullable restore
#line 54 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                  () => user.name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                                    ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group");
                __builder2.AddAttribute(96, "b-qqczw58t74");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(97);
                __builder2.AddAttribute(98, "type", "text");
                __builder2.AddAttribute(99, "class", "form-control");
                __builder2.AddAttribute(100, "placeholder", "Email");
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                                                                     user.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.email = __value, user.email))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                                        ");
                __Blazor.Client.Pages.Login.TypeInference.CreateValidationMessage_3(__builder2, 105, 106, 
#nullable restore
#line 58 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                  () => user.email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                                    ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group");
                __builder2.AddAttribute(110, "b-qqczw58t74");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(111);
                __builder2.AddAttribute(112, "type", "password");
                __builder2.AddAttribute(113, "class", "form-control");
                __builder2.AddAttribute(114, "placeholder", "Password");
                __builder2.AddAttribute(115, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                                                                            user.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.password = __value, user.password))));
                __builder2.AddAttribute(117, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(118, "\r\n                                        ");
                __Blazor.Client.Pages.Login.TypeInference.CreateValidationMessage_4(__builder2, 119, 120, 
#nullable restore
#line 62 "E:\Bug-Tracker\Client\Pages\Login.razor"
                                                                  () => user.password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                                    ");
                __builder2.AddMarkupContent(122, "<div class=\"form-group\" b-qqczw58t74><button type=\"submit\" class=\"btn btn-primary btn-block btn-lg\" b-qqczw58t74>Sign up</button></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "E:\Bug-Tracker\Client\Pages\Login.razor"
       
    private User user = new User();

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Client.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
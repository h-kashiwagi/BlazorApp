#pragma checksum "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnAdvanceRouting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1456b23b1af0ab75f50310f5105593a9fc5c057d"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnadvancerouting")]
    public partial class LearnAdvanceRouting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>LearnAdvanceRouting</h3>\r\n");
            __builder.OpenElement(1, "h4");
            __builder.AddMarkupContent(2, "Parameter??????");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnAdvanceRouting.razor"
                Param1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "h4");
            __builder.AddMarkupContent(6, "Parameter??????");
            __builder.AddContent(7, 
#nullable restore
#line 6 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnAdvanceRouting.razor"
                Param2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "h4");
            __builder.AddContent(10, 
#nullable restore
#line 7 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnAdvanceRouting.razor"
     Test

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "p");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnAdvanceRouting.razor"
                                              LoadParameters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n        Load Parameters\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.AddMarkupContent(18, "<a href=\"/learnrouting\" class=\"btn btn-secondary\">Back to Routing</a>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "href", "/learnrouting");
            __builder.AddAttribute(21, "class", "btn btn-secondary");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(23, "Back to Routing");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-secondary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnAdvanceRouting.razor"
                                                BackToRouting

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Back to Routing");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-secondary");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnAdvanceRouting.razor"
                                                TestSet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Back to Routing");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnAdvanceRouting.razor"
       
    private string Param1;
    private string Param2;

    private string Test;

    private void TestSet()
    {
        Test = "Hello";
    }


    private void LoadParameters()
    {
        var absoluteUri = new Uri(NavigationManager.Uri);
        var queryParam = System.Web.HttpUtility.ParseQueryString(absoluteUri.Query);
        Param1 = queryParam["Param1"];
        Param2 = queryParam["Param2"];
    }

    private void BackToRouting()
    {
        NavigationManager.NavigateTo("learnrouting");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

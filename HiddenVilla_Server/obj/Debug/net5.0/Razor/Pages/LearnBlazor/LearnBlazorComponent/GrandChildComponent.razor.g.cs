#pragma checksum "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\GrandChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad50fcf2c7e0d9cc229016854496738de9aaca1"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent
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
    public partial class GrandChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "border mt-2");
            __builder.AddMarkupContent(2, "<div class=\"row\"><h4 class=\"text-primary pl-4 pt-2 col-12\">Grand Child Component</h4></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "p");
            __builder.AddAttribute(6, "class", "pl-4 ml-2");
            __builder.AddContent(7, "There is a message - ");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\GrandChildComponent.razor"
                                                   MessageForGrandChild

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "class", "pl-4 ml-2");
            __builder.AddContent(12, "Lucky Number - ");
            __builder.AddContent(13, 
#nullable restore
#line 7 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\GrandChildComponent.razor"
                                             LuckyNumberFromGrandParent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\GrandChildComponent.razor"
       
        /*親<CascadingValue Value="@messageForGrandChild">
        <CascadingValue Value="@LuckyNumber">順番に適用されるがすべてstring型だとMessageForGrandChildにも"7"が入る*/

        [CascadingParameter(Name ="MessageFromGrandParent")]
        public string MessageForGrandChild { get; set; }

        [CascadingParameter(Name = "GrandParentsLuckyNumber")]
        public string LuckyNumberFromGrandParent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

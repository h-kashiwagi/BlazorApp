#pragma checksum "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba24f51255487619c6432bd9a5ba792f74a6eaf4"
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
#nullable restore
#line 1 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
    public partial class IndividualAmenities : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2 col-5 offset-1");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor"
                                                          (args)=> AmenitySelectionChanged(args,Amenities.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(3, "h4");
            __builder.AddAttribute(4, "class", "text-secondary");
            __builder.AddMarkupContent(5, " アメニティ- ");
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor"
                                        Amenities.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "　\r\n\r\n    ");
            __builder.AddContent(8, 
#nullable restore
#line 8 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor"
     Amenities.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "<br>\r\n    ");
            __builder.AddContent(10, 
#nullable restore
#line 9 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor"
     Amenities.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "<br>\r\n    RE form Parent - ");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor"
                      FirstFragment

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " ");
            __builder.AddContent(14, 
#nullable restore
#line 10 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor"
                                     SecondFragment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor"
       

    [Parameter]
    public BlazorAmenities Amenities { get; set; }  

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\h-kashiwagi\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenities.razor"
                                                                                    

    //8/9
    [Parameter]
    public EventCallback<string> OnAmenitySelection { get; set; }

    //8/13
    [Parameter]
    public RenderFragment FirstFragment { get; set; }
    [Parameter]
    public RenderFragment SecondFragment { get; set; }

    protected async Task AmenitySelectionChanged(MouseEventArgs e,string name)
    {
        await OnAmenitySelection.InvokeAsync((string)name);  //OnAmenitySelectiionに強制的に文字列型になったnameが追加される
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

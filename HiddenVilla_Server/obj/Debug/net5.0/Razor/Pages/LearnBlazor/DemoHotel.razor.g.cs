#pragma checksum "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81aa8b5ea03237fc3b4b0196eb4f054e391d6fa7"
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
#line 1 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/demoHotel")]
    public partial class DemoHotel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>部屋の種類・アメニティ</h1>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "border p-2 mt-2");
            __builder.AddAttribute(3, "style", "background-color:lightgrey");
            __builder.AddMarkupContent(4, "<h2 class=\"text-info\">部屋一覧</h2> \n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row container");
            __builder.AddMarkupContent(7, "<div class=\"col-12\"><h4 class=\"text-info\">ホテルの部屋</h4></div>");
#nullable restore
#line 16 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
     foreach (var room in RoomsList)

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.IndividualRoom>(8);
            __builder.AddAttribute(9, "Room", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HiddenVilla_Server.Model.BlazorRoom>(
#nullable restore
#line 17 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                           room

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                  }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<div class=\"col-12 mt-4\"><h4 class=\"text-info\">ホテルのアメニティ</h4></div>");
#nullable restore
#line 22 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
     foreach (var amenity in AmenitiesList)

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                               {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.IndividualAmenities>(11);
            __builder.AddAttribute(12, "Amenities", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HiddenVilla_Server.Model.BlazorAmenities>(
#nullable restore
#line 23 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                     amenity

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 23 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
      







    List<BlazorRoom> RoomsList = new List<BlazorRoom>();
    List<BlazorAmenities> AmenitiesList = new List<BlazorAmenities>();



    protected override void OnInitialized()　

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                                                             
    {
    base.OnInitialized();　　　　

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                    

    RoomsList.Add(new BlazorRoom() 

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                  
    {
         Id = 201, 

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                   
         RoomName = "シングルベッドルーム",
         Price = 36000,
         IsActive = true,
         RoomProps = new List<BlazorRoomProp> 

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                              
                         {
                         new Model.BlazorRoomProp{Id=1,Name="平方フィート",Value="330"},
                         new Model.BlazorRoomProp{Id=2,Name="占有率",Value="4"},

                          }
     });

     RoomsList.Add(new BlazorRoom() 

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                   
     {
          Id = 301, 

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                    
          RoomName = "ダブルベッドルーム",
          Price = 65000,
          IsActive = true,
          RoomProps = new List<BlazorRoomProp> 

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                               
                          {
                           new Model.BlazorRoomProp{Id=1,Name="平方フィート",Value="150"},
                           new Model.BlazorRoomProp{Id=2,Name="占有率",Value="6"},

                          }
}); 

    AmenitiesList.Add(new BlazorAmenities()
    {
          Id =111,
          Name = "ジム",
          Description = "ジムの利用可能時間：7am to 10pm"
    });

    AmenitiesList.Add(new BlazorAmenities()
    {
          Id = 222,
          Name = "プール",
          Description = "プールのオープン時間：6am to 10pm"

    });

    AmenitiesList.Add(new BlazorAmenities()
    {
          Id = 333,
          Name = "朝食",
          Description = "朝食の時間：7am to 10am"
    });

}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

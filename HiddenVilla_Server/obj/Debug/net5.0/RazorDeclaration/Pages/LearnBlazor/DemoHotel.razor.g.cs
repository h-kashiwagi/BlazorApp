// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.LearnBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
      


    public int SelectedRooms { get; set; } = 0;
    public string SelectedAmenity { get; set; } = "";

    List<BlazorRoom> RoomsList = new List<BlazorRoom>();
    List<BlazorAmenities> AmenitiesList = new List<BlazorAmenities>();



    protected override void OnInitialized()

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                                                            
    {
        base.OnInitialized(); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                     

        RoomsList.Add(new BlazorRoom() 

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                      
        {
            Id = 201, 

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                      
            RoomName = "シングルベッドルーム",
            Price = 36000,
            IsActive = true,
            RoomProps = new List<BlazorRoomProp> 

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                                 
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
#line 70 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                      
                        {
                            Id = 301, 

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                      
                            RoomName = "ダブルベッドルーム",
                            Price = 65000,
                            IsActive = true,
                            RoomProps = new List<BlazorRoomProp> 

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                                                 
                                                      {
                           new Model.BlazorRoomProp{Id=1,Name="平方フィート",Value="150"},
                           new Model.BlazorRoomProp{Id=2,Name="占有率",Value="6"},

                          }
                        });

        AmenitiesList.Add(new BlazorAmenities()
        {
            Id = 111,
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


    protected void RoomSelectionCounterChanged(bool isRoomSelected)
    {
        if (isRoomSelected)
        {
            SelectedRooms++;
        }
        else
        {
            SelectedRooms--;
        }
    }

    //AmenityのNameが渡される
    protected void AmenitySelectionChanged(string amenity)
    {
         SelectedAmenity = amenity;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

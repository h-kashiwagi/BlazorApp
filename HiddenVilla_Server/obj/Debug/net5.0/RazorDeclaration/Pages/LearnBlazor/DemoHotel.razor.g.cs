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
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
      


    List<BlazorRoom> RoomsList = new List<BlazorRoom>();



    protected override void OnInitialized()　

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                                                             
    {
        base.OnInitialized();　　　　

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                        

        RoomsList.Add(new BlazorRoom() 

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                      
        {
            Id = 201, 

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                      
            RoomName = "シングルベッドルーム",
            Price = 399,
            IsActive = true,
            RoomProps = new List<BlazorRoomProp> 

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                                 
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
#line 44 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                       
         {
             Id = 301, 

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                       
             RoomName = "ダブルベッドルーム",
             Price = 699,
             IsActive = true,
             RoomProps = new List<BlazorRoomProp> 

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\h-kashiwagi\Desktop\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                                                  
                          {
                           new Model.BlazorRoomProp{Id=1,Name="平方フィート",Value="150"},
                           new Model.BlazorRoomProp{Id=2,Name="占有率",Value="6"},

                          }
         });
     }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

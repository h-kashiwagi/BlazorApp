#pragma checksum "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "657d58b14de90beb95e17e1a9c70a0b36fd4d1aa"
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
#line 11 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bindProp")]
    public partial class BindProp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2");
            __builder.AddMarkupContent(2, "<h2 class=\"bg-light border p-2\">\r\n        ファーストルーム\r\n    </h2>\r\n    Room:");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
          Room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n    <br>\r\n    Price:");
            __builder.AddContent(5, 
#nullable restore
#line 14 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
           Room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "number");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                      Room.Price

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.Price = __value, Room.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    <br>\r\n    ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "checkbox");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                        Room.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.IsActive = __value, Room.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "&nbsp;Is.Active \r\n    <br>\r\n    ");
            __builder.OpenElement(17, "span");
            __builder.AddContent(18, "This room is ");
            __builder.AddContent(19, 
#nullable restore
#line 21 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                         Room.IsActive ? "Active": "Inactive"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, " \r\n\r\n    ");
            __builder.OpenElement(21, "select");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                   SelectedRoomProp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedRoomProp = __value, SelectedRoomProp));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 24 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
         foreach (var prop in Room.RoomProps)

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                         
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", 
#nullable restore
#line 26 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                            prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, 
#nullable restore
#line 26 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                        prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    <br>\r\n    ");
            __builder.OpenElement(28, "span");
            __builder.AddMarkupContent(29, "The Room Prop selected is：");
            __builder.AddContent(30, 
#nullable restore
#line 31 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                     SelectedRoomProp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddMarkupContent(33, "<br>\r\n    ");
            __builder.AddMarkupContent(34, "<h2 class=\"taxt-info\">部屋一覧 [Assignment 2]</h2>\r\n    ");
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "class", "table table-dark");
#nullable restore
#line 38 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
         foreach(var room in RoomsList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "tr");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                    room.RoomName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.RoomName = __value, room.RoomName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                    room.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.Price = __value, room.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                 foreach(var roomProp in room.RoomProps)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 49 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                         roomProp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, " - ");
            __builder.AddContent(52, 
#nullable restore
#line 49 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                          roomProp.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
      

    string SelectedRoomProp = "";
    List<BlazorRoom> RoomsList = new List<BlazorRoom>();

    BlazorRoom Room = new BlazorRoom() 

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                      
    {
        Id = 1, 

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                
        RoomName = "Villa Suite",
        Price = 499,
        IsActive = true,
        RoomProps = new List<BlazorRoomProp> 

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                                             
       {
            new Model.BlazorRoomProp{Id=1,Name="平方フィート",Value="100"},
            new Model.BlazorRoomProp{Id=2,Name="占有率",Value="3"},
         }
         };

             protected override void OnInitialized()
             {
                 base.OnInitialized();

                 RoomsList.Add(new BlazorRoom() 

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                               
                {
                        Id = 201, 

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                                  
                        RoomName = "Villa Suite One Bed Room",
                        Price = 399,
                        IsActive = true,
                        RoomProps = new List<BlazorRoomProp> 

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                                                             
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
#line 91 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                                 
                  {
                         Id = 301, 

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                                   
                         RoomName = "Villa Suite Tow Bed Room",
                         Price = 699,
                         IsActive = true,
                         RoomProps = new List<BlazorRoomProp> 

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\KASHIWAGI HIROMITU\Desktop\BlazorApp\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                                                              
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

#pragma checksum "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48c2378162cfd3305e6195f26246f9e4405d697d"
// <auto-generated/>
#pragma warning disable 1591
namespace SGACOL.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using SGACOL;

#line default
#line hidden
#line 7 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using SGACOL.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Bienvenido a nuestra App</h2>\r\n");
            __builder.AddMarkupContent(1, "<section>\r\n    <div id=\"carouselExampleControls\" class=\"carousel slide\" data-bs-ride=\"carousel\">\r\n        <div class=\"carousel-indicators\">\r\n            <button type=\"button\" data-bs-target=\"#carouselExampleIndicators\" data-bs-slide-to=\"0\" class=\"active\" aria-current=\"true\" aria-label=\"Slide 1\"></button>\r\n            <button type=\"button\" data-bs-target=\"#carouselExampleIndicators\" data-bs-slide-to=\"1\" aria-label=\"Slide 2\"></button>\r\n            <button type=\"button\" data-bs-target=\"#carouselExampleIndicators\" data-bs-slide-to=\"2\" aria-label=\"Slide 3\"></button>\r\n        </div>\r\n        <div class=\"carousel-inner\">\r\n            <div class=\"carousel-item active\">\r\n                <img src=\"/img/clasevirtual1.jpg\" class=\"d-block w-100\" alt=\"banner 1\">\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img src=\"/img/images.jpg\" class=\"d-block w-100\" alt=\"banner 2\">\r\n            </div>\r\n                <div class=\"carousel-item\">\r\n            <img src=\"/img/ensevirtual.jpeg\" class=\"d-block w-100\" alt=\"banner 3\">\r\n            </div>\r\n        </div>\r\n        <button class=\"carousel-control-prev\" type=\"button\" data-bs-target=\"#carouselExampleControls\" data-bs-slide=\"prev\">\r\n            <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"visually-hidden\">Previous</span>\r\n        </button>\r\n        <button class=\"carousel-control-next\" type=\"button\" data-bs-target=\"#carouselExampleControls\" data-bs-slide=\"next\">\r\n            <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"visually-hidden\">Next</span>\r\n        </button>\r\n    </div>\r\n</section>\r\n");
            __builder.OpenComponent<SGACOL.Shared.SurveyPrompt>(2);
            __builder.AddAttribute(3, "Title", "Como estuvo tu visita?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f3c48a25a52df4e7047b278c733791b3926801b"
// <auto-generated/>
#pragma warning disable 1591
namespace Lab.WASM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Lab.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Lab.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Lab.WASM.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\_Imports.razor"
using Lab.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 8 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 24 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
#nullable restore
#line 27 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
__builder.AddContent(9, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 28 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
__builder.AddContent(12, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 29 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
__builder.AddContent(15, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 30 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
__builder.AddContent(18, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
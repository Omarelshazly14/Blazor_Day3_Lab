// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Lab.WASM.ProductComponent
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product")]
    public partial class GetAllProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\GetAllProductsComponent.razor"
       
    public List<Product> products { get; set; }
    protected override async Task OnInitializedAsync()
    {
        products = await productService.GetAll();
        await base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<Product> productService { get; set; }
    }
}
#pragma warning restore 1591

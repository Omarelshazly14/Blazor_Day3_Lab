#pragma checksum "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40bb8f9926a8ed7fb9d795052c50e75e5e914b6e"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/Edit/{id:int}")]
    public partial class EditProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditProduct</h3>");
#nullable restore
#line 7 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
 if (product != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                     product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                             Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "<label>Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                    product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Name = __value, product.Name))));
                __builder2.AddAttribute(15, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __Blazor.Lab.WASM.ProductComponent.EditProduct.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 15 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                    ()=>product.Name

#line default
#line hidden
#nullable disable
                , 19, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddMarkupContent(22, "<label>Price</label>\r\n            ");
                __Blazor.Lab.WASM.ProductComponent.EditProduct.TypeInference.CreateInputNumber_1(__builder2, 23, 24, "form-control", 25, 
#nullable restore
#line 19 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                      product.Price

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Price = __value, product.Price)), 27, () => product.Price);
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.Lab.WASM.ProductComponent.EditProduct.TypeInference.CreateValidationMessage_2(__builder2, 29, 30, 
#nullable restore
#line 20 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                    ()=>product.Price

#line default
#line hidden
#nullable disable
                , 31, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddMarkupContent(34, "<label>Image</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                    product.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Image = __value, product.Image))));
                __builder2.AddAttribute(39, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.Image));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __Blazor.Lab.WASM.ProductComponent.EditProduct.TypeInference.CreateValidationMessage_3(__builder2, 41, 42, 
#nullable restore
#line 26 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                    ()=>product.Image

#line default
#line hidden
#nullable disable
                , 43, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddMarkupContent(46, "<label>Category</label>\r\n            ");
                __Blazor.Lab.WASM.ProductComponent.EditProduct.TypeInference.CreateInputSelect_4(__builder2, 47, 48, "form-control", 49, 
#nullable restore
#line 30 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                      product.Cat_ID

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Cat_ID = __value, product.Cat_ID)), 51, () => product.Cat_ID, 52, (__builder3) => {
#nullable restore
#line 31 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                 foreach (var item in catList)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(53, "option");
                    __builder3.AddAttribute(54, "value", 
#nullable restore
#line 33 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 33 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
__builder3.AddContent(55, item.Name);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 34 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(56, "\r\n            ");
                __Blazor.Lab.WASM.ProductComponent.EditProduct.TypeInference.CreateValidationMessage_5(__builder2, 57, 58, 
#nullable restore
#line 36 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
                                    ()=>product.Cat_ID

#line default
#line hidden
#nullable disable
                , 59, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        <input type=\"submit\" value=\"Update\" class=\"btn btn-success\">");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "E:\Employment\ITI\9-month Scholarship\36- Blazor\Day3\Lab\Solution1\Lab.WASM\ProductComponent\EditProduct.razor"
           
        [Parameter]
        public int id { get; set; }
    public Product product { get; set; }
    public List<Category> catList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        product = await productService.GetById(id);
        catList = await categoryService.GetAll();
        await base.OnInitializedAsync();
    }

    public async void Save()
    {
        await productService.Update(product);
        navManager.NavigateTo("/Product");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<Category> categoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<Product> productService { get; set; }
    }
}
namespace __Blazor.Lab.WASM.ProductComponent.EditProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
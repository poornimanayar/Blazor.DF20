#pragma checksum "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\Shared\DisplayText.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cccdc84940634ee8205d17a5fa9ba4ee5e373f69"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.WASM.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using Blazor.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using Blazor.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\_Imports.razor"
using Blazor.WASM.Components;

#line default
#line hidden
#nullable disable
    public partial class DisplayText : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\Shared\DisplayText.razor"
 if (string.IsNullOrWhiteSpace(Text))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 3 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\Shared\DisplayText.razor"
         FallbackText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 4 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\Shared\DisplayText.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h3");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\Shared\DisplayText.razor"
         Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\Shared\DisplayText.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\Shared\DisplayText.razor"
       

    [CascadingParameter(Name = "SharedTextName")]
    private string FallbackText { get; set; }

    [Parameter]
    public string Text { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class ChildCounterUpdate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\Shared\ChildCounterUpdate.razor"
       
    [Parameter]
    public int ChildCounterUpdateValue { get; set; }

    [Parameter]
    public EventCallback<int> ChildCounterUpdateValueChanged { get; set; }

    private async Task IncrementCountChild()
    {
        ChildCounterUpdateValue = ChildCounterUpdateValue + 1;

        await ChildCounterUpdateValueChanged.InvokeAsync(ChildCounterUpdateValue);
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine($"OnParametersSet called {ChildCounterUpdateValue}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\WORK\_freelance\Blazor.DF20\Blazor.WASM\Pages\ComponentLifecycle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a0dd56ca27d5b1253ca51f197df25e3d1ab0039"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.WASM.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/componentlifecycle")]
    public partial class ComponentLifecycle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Lifecycle methods example</h2>\r\n\r\n");
            __builder.OpenComponent<Blazor.WASM.Shared.LifecycleMethods>(1);
            __builder.AddAttribute(2, "FirstName", "Poornima");
            __builder.AddAttribute(3, "LastName", "Nayar");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

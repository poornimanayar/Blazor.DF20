using Microsoft.AspNetCore.Components;

namespace Blazor.WASM.ComponentBaseClasses
{
    public class ComponentBaseClassExample : ComponentBase
    {
        public string SomeStringValue { get; set; } = "Base Class String";
    }
}

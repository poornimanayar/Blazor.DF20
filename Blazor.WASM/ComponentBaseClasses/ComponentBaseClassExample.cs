using Microsoft.AspNetCore.Components;

namespace Blazor.WASM.ComponentBaseClasses
{
    public class ComponentBaseClassExample : ComponentBase
    {
        public int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}

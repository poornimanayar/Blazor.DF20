using System.Linq;
using Microsoft.AspNetCore.Components.Forms;

namespace Blazor.WASM.Validation
{
    public class MyCustomValidationClass : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext,
            in FieldIdentifier fieldIdentifier)
        {
            var isValid = !editContext.GetValidationMessages(fieldIdentifier).Any();

            return isValid ? "valid goodfield" : "badfield";
        }
    }
}

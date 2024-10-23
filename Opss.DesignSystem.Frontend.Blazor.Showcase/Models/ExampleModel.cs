using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Showcase.Models
{
    public class ExampleModel : ComponentBase
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public string CodeExampleContent { get; set; }
    }
}

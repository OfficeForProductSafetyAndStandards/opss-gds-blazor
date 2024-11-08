using Opss.DesignSystem.Frontend.Blazor.Components.Models.Base;
using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models;

public class GdsContentModel : GdsViewModel
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}

using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models;

public abstract class GdsWithContent : GdsViewModel
{
    /// <summary>
    /// Content of the container
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models;

public abstract class GdsViewModel : GdsAttributes
{
    /// <summary>
    /// Classes to add to the element
    /// </summary>
    [Parameter]
    public string? Classes { get; set; }
}
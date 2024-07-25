using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models.Base;

public abstract class GdsWithHref : GdsWithContent
{
    /// <summary>
    /// The value of the link's href attribute.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }
}
using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models;

public abstract class GdsWithHref : GdsWithContent
{
    /// <summary>
    /// The value of the link's href attribute.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// Indicates that the component is on a dark background and should utilise the inverse class
    /// </summary>
    [Parameter]
    public bool IsOnDarkBackground { get; set; }
}
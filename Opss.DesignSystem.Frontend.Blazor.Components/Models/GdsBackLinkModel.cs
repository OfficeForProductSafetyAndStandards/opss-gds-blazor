using Microsoft.AspNetCore.Components;
using Opss.DesignSystem.Frontend.Blazor.Components.Models.Base;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models;

/// <summary>
/// Use the back link component to help users go back to the previous page in a multi-page transaction.
/// 
/// Although browsers have a back button, some sites break when you use it - so many users avoid it, instead of losing their progress in a service.
/// Also, not all users are aware of the back button.
/// </summary>
public class GdsBackLinkModel : GdsWithHref
{
    public GdsBackLinkModel()
    {
        Href = "#";
    }

    /// <summary>
    /// Indicates that the component is on a dark background and should utilise the inverse class
    /// </summary>
    [Parameter]
    public bool IsOnDarkBackground { get; set; }
}
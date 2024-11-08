using Opss.DesignSystem.Frontend.Blazor.Components.Models.Base;
using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models;

/// <summary>
/// Follow the validation pattern and show an error message when there is a validation error.
/// In the error message explain what went wrong and how to fix it.
/// </summary>
public class GdsErrorMessageModel : GdsWithContent
{
    /// <summary>
    /// A visually hidden prefix used before the error message.
    /// </summary>
    [Parameter]
    public string? VisuallyHiddenText { get; set; }
}

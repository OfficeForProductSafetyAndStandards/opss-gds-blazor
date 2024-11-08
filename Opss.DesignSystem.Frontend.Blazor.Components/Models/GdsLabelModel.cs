using Opss.DesignSystem.Frontend.Blazor.Components.Models.Base;
using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models;

public class GdsLabelModel : GdsWithContent
{
    /// <summary>
    /// The value of the `for` attribute, the ID of the input the label is associated with.
    /// </summary>
    [Parameter]
    public string? For { get; set; }

    /// <summary>
    /// Whether the label also acts as the heading for the page.
    /// </summary>
    [Parameter]
    public bool IsPageHeading { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1034:Nested types should not be visible", Justification = "Type is specific to its parent")]
    public static class Size
    {
        public const string Small = "govuk-label--s";
        public const string Medium = "govuk-label--m";
        public const string Large = "govuk-label--l";
    }
}
using Opss.DesignSystem.Frontend.Blazor.Components.Models.Base;
using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models;

public partial class GdsInputModel : GdsViewModel
{
    /// <summary>
    /// The name of the input, which is submitted with the form data.
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// Type of input control to render, for example, a password input control.
    /// </summary>
    [Parameter]
    public string? Type { get; set; }

    [Parameter]
    public string? Inputmode { get; set; }

    /// <summary>
    /// Optional initial value of the input.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    private string? _describedBy;
    /// <summary>
    /// One or more element IDs to add to the aria-describedby attribute, used to provide additional descriptive information for screenreader users.
    /// </summary>
    [Parameter]
    public string? DescribedBy
    {
        get
        {
            var fullText = _describedBy ?? "";
            if (ErrorMessageTemplate != null) fullText += $" {Id}-error";
            if (HintTemplate != null) fullText += $" {Id}-hint";
            return string.IsNullOrWhiteSpace(fullText) ? null : fullText;
        }
        set => _describedBy = value;
    }

    [Parameter]
    public RenderFragment? LabelTemplate { get; set; }
    [Parameter]
    public RenderFragment? HintTemplate { get; set; }
    [Parameter]
    public RenderFragment? ErrorMessageTemplate { get; set; }
    [Parameter]
    public RenderFragment? PrefixTemplate { get; set; }
    [Parameter]
    public RenderFragment? SuffixTemplate { get; set; }

    /// <summary>
    /// Classes to add to the form group (for example to show error state for the whole group).
    /// </summary>
    [Parameter]
    public string? FormGroupClasses { get; set; }

    /// <summary>
    /// Attribute to identify input purpose, for instance "postal-code" or "username".
    /// </summary>
    [Parameter]
    public string? Autocomplete { get; set; }

    /// <summary>
    /// Attribute to provide a regular expression pattern, used to match allowed character combinations for the input value.
    /// </summary>
    [Parameter]
    public string? Pattern { get; set; }

    /// <summary>
    /// Optional field to enable or disable the spellcheck attribute on the input.
    /// </summary>
    [Parameter]
    public bool Spellcheck { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1034:Nested types should not be visible", Justification = "Type is specific to its parent")]
    public static class Width
    {
        public const string Width30 = "govuk-input--width-30";
        public const string Width20 = "govuk-input--width-20";
        public const string Width10 = "govuk-input--width-10";
        public const string Width5 = "govuk-input--width-5";
        public const string Width4 = "govuk-input--width-4";
        public const string Width3 = "govuk-input--width-3";
        public const string Width2 = "govuk-input--width-2";
    }
}

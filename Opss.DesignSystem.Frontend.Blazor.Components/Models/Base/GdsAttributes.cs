using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models.Base;

public abstract class GdsAttributes : ComponentBase
{
    /// <summary>
    /// HTML attributes (for example data attributes) to add to the element
    /// </summary>
    [Parameter]
    [SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Component parameters should have a public setter")]
    public Dictionary<string, object>? Attributes { get; set; } = new Dictionary<string, object>();
}

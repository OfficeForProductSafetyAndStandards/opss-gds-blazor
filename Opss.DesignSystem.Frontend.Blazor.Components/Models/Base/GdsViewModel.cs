﻿using Microsoft.AspNetCore.Components;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models.Base;

public abstract class GdsViewModel : GdsAttributes
{
    /// <summary>
    /// Set the id of the element
    /// </summary>
    [Parameter]
    public string? Id { get; set; }

    /// <summary>
    /// Classes to add to the element
    /// </summary>
    [Parameter]
    public string? Classes { get; set; }

    protected GdsViewModel(string? id, string? classes = "", Dictionary<string, object>? attributes = null)
    {
        Id = id;
        Classes = classes;
        Attributes = attributes;
    }

    protected GdsViewModel() : this(null)
    {
    }
}
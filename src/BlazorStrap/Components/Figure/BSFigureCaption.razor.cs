﻿using Microsoft.AspNetCore.Components;
using BlazorStrap.Util.Components;
using BlazorComponentUtilities;
using System;
using System.Collections.Generic;

namespace BlazorStrap
{
    public class CodeBSFigureCaption : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)] protected IDictionary<string, object> UnknownParameters { get; set; }
        protected string classname =>
        new CssBuilder("figure-caption")
            .AddClass(GetAlignment())
            .AddClass(Class)
            .Build();

        [Parameter] protected Alignment Alignment { get; set; } = Alignment.None;
        [Parameter] protected string Class { get; set; }
        [Parameter] protected string Style { get; set; }
        [Parameter] protected RenderFragment ChildContent { get; set; }
        protected string GetAlignment()
        {
            if (Alignment == Alignment.Center) { return "text-center"; }
            if (Alignment == Alignment.Right) { return "text-right"; }
            return null;
        }
    }
}
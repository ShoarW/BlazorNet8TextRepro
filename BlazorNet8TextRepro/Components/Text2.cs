using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorNet8TextRepro.Components;

public class Text2 : ComponentBase
{
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "h3");
        builder.AddContent(1, ChildContent);
        builder.CloseElement();
    }
}
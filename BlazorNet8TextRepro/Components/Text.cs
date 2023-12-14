using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorNet8TextRepro.Components
{
    public class Text : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "h1");
            builder.AddContent(1, ChildContent);
            builder.CloseElement();
        }
    }
}

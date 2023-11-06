using Microsoft.AspNetCore.Razor.TagHelpers;

namespace lab2.TagHelpers
{
    [HtmlTargetElement("item-link")]
    public class ItemLinkTagHelper : TagHelper
    {
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string? CustomUrl { get; set; }
        public int ItemId { get; set; }
        public string? DisplayText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            if (CustomUrl == null && ControllerName != null && ActionName != null)
            {
                output.Attributes.SetAttribute("href", $"/{ControllerName}/{ActionName}/{ItemId}");
            }
            else
            {
                output.Attributes.SetAttribute("href", $"/{CustomUrl}");
            }
            output.Content.SetContent(DisplayText);
        }
    }
}

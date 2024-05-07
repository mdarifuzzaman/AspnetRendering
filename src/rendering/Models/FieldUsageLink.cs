using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace FptApp.Models
{
    public class FieldUsageLink : HeadingAndDescription
    {
        public HyperLinkField ExternalLink { get; set; } = default!;

        public HyperLinkField InternalLink { get; set; } = default!;

        public HyperLinkField EmailLink { get; set; } = default!;

        public HyperLinkField ParamsLink { get; set; } = default!;
    }
}

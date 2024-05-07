using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace FptApp.Models
{
    public class HeadingAndDescription : HeadingOnly
    {
        public RichTextField Description { get; set; } = default!;
    }
}

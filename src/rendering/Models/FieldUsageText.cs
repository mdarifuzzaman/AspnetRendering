using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace FptApp.Models
{
    public class FieldUsageText : HeadingAndDescription
    {
        public TextField Sample { get; set; } = default!;

        public TextField Sample2 { get; set; } = default!;
    }
}
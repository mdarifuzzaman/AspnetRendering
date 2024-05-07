using Sitecore.LayoutService.Client.Response.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FptApp.Models
{
    public class PromoComponentModel
    {
        public TextField Title { get; set; }
        public RichTextField BodyText { get; set; }
        public ImageField FeaturedImage { get; set; }
        public HyperLinkField PromoLink { get; set; }
        public DateField Date { get; set; }
    }
}

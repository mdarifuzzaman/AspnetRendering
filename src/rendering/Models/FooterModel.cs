using Sitecore.LayoutService.Client.Response.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FptApp.Models
{
    public class FooterModel: HeadingAndDescription
    {
        public ImageField FooterLogo { get; set; }
        public ContentListField Links { get; set; }
    }
}

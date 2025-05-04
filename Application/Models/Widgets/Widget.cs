using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Widgets
{
    public class WidgetResponse
    {
        public List<Widget> Widgets { get; set; } = new();
    }

    public class Widget
    {
        public string Type { get; set; }
        public WidgetHeader Header { get; set; }
        public string ServiceURL { get; set; }
    }

    public class WidgetHeader
    {
        public string Title { get; set; }
        public WidgetNavigation Navigation { get; set; }
    }

    public class WidgetNavigation
    {
        public string Title { get; set; }
        public string Deeplink { get; set; }
    }
}

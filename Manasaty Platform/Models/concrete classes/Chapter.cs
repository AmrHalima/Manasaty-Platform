using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manasaty_Platform.Models.concrete_classes
{
    internal class Chapter
    {
        public TimeSpan Duration { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Chapter() { }

        public Chapter(TimeSpan Duration, string Link, string Title, string Description)
        {
            this.Duration = Duration;
            this.Link = Link;
            this.Title = Title;
            this.Description = Description;
        }
    }
}

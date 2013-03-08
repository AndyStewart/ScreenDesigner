using System.Collections.Generic;

namespace ScreenDesigner
{
    public class Screen
    {
        public string Name { get; set; }
        public ICollection<Element> Elements { get; set; }
    }
}
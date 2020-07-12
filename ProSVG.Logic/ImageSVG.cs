using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSVG.Logic
{
    public class ImageSVG : ElementSVG
    {
        private List<ElementSVG> svg = new List<ElementSVG>();

        public string Generate()
        {
            string s = "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"300\" height=\"300\" version = \"1.1\" >\n";
            foreach(ElementSVG e in svg)
            {
                s += e.Generate() + "\n";
            }
            s += "</svg>";

            return s;
        }

        public void AddElement(ElementSVG e)
        {
            svg.Add(e);
        }
    }
}

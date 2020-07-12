using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSVG.Logic 
{
    public class Line : ElementSVG
    {
        private readonly int x1, y1, x2, y2;
        private readonly ColorSVG color;

        public Line(int x1, int y1, int x2, int y2, ColorSVG color)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.color = color;
        }

        public string Generate()
        {
            return "<line x1=\""+ x1 +"\" y1=\""+ y1 +"\" x2=\""+ x2 + "\" y2=\""+ y2 + "\" stroke=\""+ color.ToString()+"\" />";
        }
    }
}

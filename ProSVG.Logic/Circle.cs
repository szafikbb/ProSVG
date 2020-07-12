using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSVG.Logic
{
    public class Circle : ElementSVG
    {
        private readonly int x, y, r;
        private readonly ColorSVG color;

        public Circle(int x, int y, int r, ColorSVG color)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.color = color;
        }

        public string Generate()
        {
            return "<circle cx=\""+ x +"\" cy=\""+y+"\" r=\""+r+"\" fill=\""+color.ToString()+"\"/>";
        }
    }
}

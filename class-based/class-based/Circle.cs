using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_based
{
    internal class Circle:Shape
    {
        private float  piValue = (float)Math.PI;
        private float radius;

        public void SetRadius(float radius)
        {
            this.radius = radius;
        }
  
        public override float getArea()
        {
            return ( piValue * this.radius * this.radius);
        }

        public override float getPerimeter()
        {
            return 2* (piValue * this.radius);
        }
    }
}

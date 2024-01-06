using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class_based
{
    internal abstract class Shape
    {
        private string name;
        private int no_of_sides;
        private float[] sides;  
        public void setName(string name) {  this.name = name; }
        public void setNumberOfSides(int no_of_sides) { this.no_of_sides = no_of_sides; }

        public void setSides(float[] sides) { this.sides = sides; }
        public virtual float getPerimeter()
        {
            float total = 0;
            foreach (var side in sides)
            {
                total += side;
            }
            return total;
        }
        public abstract float getArea();
    }
}

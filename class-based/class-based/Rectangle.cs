using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_based
{
    internal class Rectangle:Shape
    {
        private float height;
        private float width;

        public void SetBase(float height)
        {
            this.height = height;
        }
        public void SetHeight(float width)
        {
            this.width = width;
        }
        public override float getArea()
        {
            return (this.height * this.width);
        }
    }
}

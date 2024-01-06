using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_based
{
    internal class Triangle:Shape
    {
        private float @base;
        private float height;

        public void SetBase(float  @base)
        {
            this.@base = @base;
        }
        public void SetHeight(float height)
        {
            this.height = height;
        }
        public override float getArea()
        {
            return (this.@base * this.height) / 2;     
        }
    }
}

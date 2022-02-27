using System;
using System.Collections.Generic;
using System.Text;

namespace AN_Labb1
{
    
    public class Box : IEquatable<Box>
    {

        public Box(int h, int l, int b)
        {
            this.Height = h;
            this.Length = l;
            this.Width = b;
        }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }


        public bool Equals(Box other)
        {
            if (new BoxSameDimensions().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}

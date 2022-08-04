using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_3_3_Vector.MyMath
{
    internal struct Vector
    {
        public float X;
        public float Y;
        public float Z;

        public void Assign(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public string Show()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
        }
    }
}

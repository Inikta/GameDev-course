using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_3_3_Vector.MyMath
{
    internal class Operation
    {
        private static bool isNull(Vector v)
        {
            if (v.Equals(null))
            {
                Console.WriteLine("ERROR: Vector is not assigned!");
                return true;
            }

            return false;
        }

        private static bool isZero(float num)
        {
            if (num == 0)
            {
                Console.WriteLine("ERROR: Number equals 0!");
                return true;
            }

            return false;
        }

        public static bool Add(Vector v1, Vector v2, out Vector resVector)
        {
            resVector = new Vector();
            if (isNull(v1) || isNull(v2))
            {
                return false;
            }

            resVector.X = v1.X + v2.X;
            resVector.Y = v1.Y + v2.Y;
            resVector.Z = v1.Z + v2.Z;

            return true;
        }

        public static bool Sub(Vector v1, Vector v2, out Vector resVector)
        {
            resVector = new Vector();
            if (isNull(v1) || isNull(v2))
            {
                return false;
            }

            resVector.X = v1.X - v2.X;
            resVector.Y = v1.Y - v2.Y;
            resVector.Z = v1.Z - v2.Z;

            return true;
        }

        public static bool Mult(Vector v1, float num, out Vector resVector)
        {
            resVector = new Vector();
            if (isNull(v1))
            {
                return false;
            }

            resVector.X = v1.X * num;
            resVector.Y = v1.Y * num;
            resVector.Z = v1.Z * num;

            return true;
        }

        public static bool Div(Vector v1, float num, out Vector resVector)
        {
            resVector = new Vector();
            if (isNull(v1) || isZero(num))
            {
                return false;
            }

            resVector.X = v1.X / num;
            resVector.Y = v1.Y / num;
            resVector.Z = v1.Z / num;

            return true;
        }
    }
}

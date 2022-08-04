using task1_3_3_Vector.MyMath;

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector();
        v1.Assign(1, 2, 3);

        Vector v2 = new Vector();
        v2.Assign(2, 3, 4);

        float num = 5;
        bool correct = true;

        correct = Operation.Add(v1, v2, out Vector res);
        if (correct)
        {
            Console.WriteLine($"({v1.X}; {v1.Y}; {v1.Z}) + ({v2.X}; {v2.Y}; {v2.Z}) = ({res.X}; {res.Y}; {res.Z})\n");
        } else
        {
            Console.WriteLine("ADD: Error during computations!\n");
        }

        correct = Operation.Sub(v1, v2, out res);
        if (correct)
        {
            Console.WriteLine($"({v1.X}; {v1.Y}; {v1.Z}) - ({v2.X}; {v2.Y}; {v2.Z}) = ({res.X}; {res.Y}; {res.Z})\n");

        }
        else
        {
            Console.WriteLine("SUB: Error during computations!\n");
        }

        correct = Operation.Mult(v1, num, out res);
        if (correct)
        {
            Console.WriteLine($"({v1.X}; {v1.Y}; {v1.Z}) * {num} = ({res.X}; {res.Y}; {res.Z})\n");
        }
        else
        {
            Console.WriteLine("MULT: Error during computations!\n");
        }

        correct = Operation.Div(v1, num, out res);
        if (correct)
        {
            Console.WriteLine($"({v1.X}; {v1.Y}; {v1.Z}) / {num} = ({res.X}; {res.Y}; {res.Z})\n");

        }
        else
        {
            Console.WriteLine("DIV: Error during computations!\n");
        }
    }
}

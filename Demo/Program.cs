using Demo.Operator_overloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator overloading (Unary Operators , Ternary Operator ,Relational Operators)
            #region Operator Overloading (+,-,*,/)
            ////complex numbre (realnum&imaginnum)
            //Complex c1 = new Complex() { Real = 3, Imag = 4 };
            //Complex c2 = new Complex() { Real = 1, Imag = 2 };

            ////Complex c3 =c1+c2 ;--> not correct 
            //Complex c3 = new Complex();
            //Console.WriteLine("------------------");
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine("------------------");

            //c3 += c1;
            //Console.WriteLine(c3.ToString());
            //c3 -= c2;
            //Console.WriteLine(c3.ToString());

            #endregion
            #region Operator Overloading _-->Ternary
            //c3 = c1++;
            //Console.WriteLine(c3.ToString());
            //c3 = ++c1;
            //Console.WriteLine(c3.ToString());
            #endregion
            #region operator overloadingre -->Reletional operator
            //if (c1 > c2 && c1 > c3)
            //{
            //    Console.WriteLine("C1 is Greater");
            //}
            //else if (c2 > c1 && c2 > c3)
            //{
            //    Console.WriteLine("C2 is Greater");
            //}
            //else if (c3 > c1 && c3 > c2)
            //{
            //    Console.WriteLine("C3 is Greater");
            //}
            //else if (c1 == c2 && c1 > c3)
            //{
            //    Console.WriteLine("C1 and C2 are equal and greater than C3");
            //}
            //else if (c1 == c3 && c1 > c2)
            //{
            //    Console.WriteLine("C1 and C3 are equal and greater than C2");
            //}
            //else if (c2 == c3 && c2 > c1)
            //{
            //    Console.WriteLine("C2 and C3 are equal and greater than C1");
            //}
            //else
            //{
            //    Console.WriteLine("All values are equal");
            //}

            #endregion 
            #endregion
        }
    }
}

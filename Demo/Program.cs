using Demo.Abstraction;
using Demo.Casting_operator_Overloading;
using Demo.Operator_overloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //complex numbre (realnum&imaginnum)
            Complex c1 = new Complex() { Real = 3, Imag = 4 };
            Complex c2 = new Complex() { Real = 1, Imag = 2 };

            #region Operator overloading (Unary Operators , Ternary Operator ,Relational Operators)
            #region Operator Overloading (+,-,*,/)
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

            #region Casting
            #region casting operators
            //int x = (int)complex01;
            //Console.WriteLine($"X = {x}");

            //object O = "saeed";
            //string S = (string)O;
            #endregion

            #region Casting overloading
            //User user = new User()
            //{
            //    Id = 1,
            //    FullName = "Wanees sayed",
            //    Email = "Wanees@gmail.com",
            //    Password = "506070",
            //    SecurityStmp = Guid.NewGuid()
            //};

            //UserViewModel userViewModel = (UserViewModel)user;

            //Console.WriteLine(userViewModel.Fname);
            //Console.WriteLine(userViewModel.Lname);
            //Console.WriteLine(userViewModel.Password);
            //Console.WriteLine(userViewModel.Email);
            #endregion 
            #endregion

            #region Abstraction [class , method , property]
            //Rect rect = new Rect() { Dim01 = 10, Dim02 = 20 };

            //Console.WriteLine($"Rect area = {rect.CalcArea()}");
            //Console.WriteLine($"Rcct perimeter = {rect.Perimeter}");

            //Circle circle = new Circle(10);
            //Console.WriteLine(circle.Perimeter);
            //Console.WriteLine(circle.CalcArea());
            #endregion

            #region static member

            //utility utility01 = new utility(4 , 5);
            //utility utility02 = new utility(2, 6);


            //the result of calling method "cmtoinch" will not be different by the difference of the obj [state(x,y)]
            //console.writeline(utility.cmtoinch(254));
            //console.writeline(utility.circlearea(10)); 
            #endregion
        }
    }
}

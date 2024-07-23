using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i\nHashcode {GetHashCode()}";
        }
        //To overload operator
        //       -->Function Must be non private  
        //       -->Function Must be static 
        public static Complex operator + (Complex left, Complex right)
        {
            return new Complex
            {
                Real =( left?.Real ?? 0) + (right.Real),//--> ?? Nullcoleasing operator
                Imag = (left?.Imag ?? 0) + (right.Imag)//--> ?? Nullcoleasing operator
            };

        }
        public static Complex operator - (Complex left, Complex right)
        {
            return new Complex
            {
                Real =( left?.Real ?? 0) - (right.Real),//--> ?? Nullcoleasing operator
                Imag = (left?.Imag ?? 0) - (right.Imag)//--> ?? Nullcoleasing operator
            };

        }
        public static Complex operator ++(Complex comp)
        {
            return new Complex { Real = comp?.Real??0 + 1, Imag = comp?.Imag??0 + 1 };
        }
        public static bool operator >(Complex Left, Complex Right) {
            return (Left.Real == Right.Real) && (Left?.Imag > Right?.Imag) || (Left?.Real > Right?.Real);
        //    if (Left?.Real==Right?.Real)
        //    {
        //        return Left?.Imag > Right?.Imag;
        //    }
        //    else
        //    {
        //        return Left?.Real > Right?.Real;
        //    }
        }
        public static bool operator <(Complex Left, Complex Right) {
            return (Left.Real == Right.Real) && (Left?.Imag < Right?.Imag) || (Left?.Real < Right?.Real);
        //    if (Left?.Real==Right?.Real)
        //    {
        //        return Left?.Imag < Right?.Imag;
        //    }
        //    else
        //    {
        //        return Left?.Real < Right?.Real;
        //    }
        }
        public static bool operator<=(Complex Left, Complex Right) {
            return (Left.Real == Right.Real) && (Left?.Imag <= Right?.Imag) || (Left?.Real <= Right?.Real);
            //    if (Left?.Real==Right?.Real)
            //    {
            //        return Left?.Imag <= Right?.Imag;
            //    }
            //    else
            //    {
            //        return Left?.Real <= Right?.Real;
            //    }
        }
        public static bool operator>=(Complex Left, Complex Right) {
            return (Left.Real == Right.Real) && (Left?.Imag >= Right?.Imag) || (Left?.Real >= Right?.Real);
            //    if (Left?.Real==Right?.Real)
            //    {
            //        return Left?.Imag >= Right?.Imag;
            //    }
            //    else
            //    {
            //        return Left?.Real >= Right?.Real;
            //    }
        }
    }
}

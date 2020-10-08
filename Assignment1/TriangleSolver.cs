using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public static class TriangleSolver
    {
        public static string Analyze(int sidea, int sideb, int sidec) 
        {

            if (sidea + sideb <= sidec || sidea + sidec <= sideb || sideb + sidec <= sidea)
            {
                return "The triangle is invalid";
            }
            else
            {
                if (sidea == sideb && sideb == sidec)
                {
                    return "This is an equilateral triangle.";
                }
                else if (sidea == sideb || sidea == sidec || sideb == sidec)
                {
                    return "This is an isosceles triangle.";
                }
                else
                {
                    return "This is a scalene triangle";
                }

            }
        }

    }
}

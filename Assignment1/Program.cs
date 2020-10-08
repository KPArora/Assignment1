using System;

namespace Assignment1
{
    class Program
    {
        public static bool Menu()
        {
            Console.WriteLine("Select 1 to Enter Triangle dimensions ");
            Console.WriteLine("Select 2 to Exit");
            string input;
            input = Console.ReadLine();
            //ask user to select choice
            if (input == "1")
            {
                int side1, side2, side3;
                Console.Write("Input side 1 of triangle: ");
                side1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 2 of triangle: ");
                side2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 3 of triangle: ");
                side3 = Convert.ToInt32(Console.ReadLine());

                string test = TriangleSolver.Analyze(side1, side2, side3);
                Console.WriteLine(test);
            }
            else if (input == "2")
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            bool x = true;
            while (x == true)
            {
                x = Menu();
            }
        }
    }
}

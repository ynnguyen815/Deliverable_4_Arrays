/*
 Author: Nhi Nguyen
Date: 2/5/2023
Comments: This C# Console application code demonstrates the use of arrays after getting input from users
*/

namespace Deliverable_4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int i = 0;

            Console.Write(a + ", " + b);
            
            for (i = 1; i < 24; i++)
            {
                c = a + b;
                Console.Write(", "+c);

                a = b;
                b = c; 
            }

            Console.WriteLine();
        }
    }
}
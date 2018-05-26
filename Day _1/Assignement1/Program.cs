using System;

namespace Assignement1
{
    class Program
    {
        static void Main(string[] args)

        {
            int myInt = 1;
            Console.WriteLine("Alive");
            if (myInt == 1)
            {
             Console.WriteLine("Alive");   
            }
            else if(myInt == 2)
            {
                Console.WriteLine("Dead");
            }
            else if (myInt == 3)
            {
                Console.WriteLine("Zombie")
            }
            else if (myInt == 4)
            {Console.WriteLine("Unknown")}
        }
    }
}

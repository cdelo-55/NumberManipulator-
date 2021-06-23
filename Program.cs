using System;

namespace NumberManipulator_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be manipulated:");
            
            int input = Convert.ToInt32(Console.ReadLine());
            input = input * input;
            input += 14;
            input -= 3;   
            Console.WriteLine(input);
        }
    }
}

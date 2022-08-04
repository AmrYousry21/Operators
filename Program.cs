using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();    

            var a = 17;
            var b = 4;
            

            program.OperatorExercise(a, b);

            Console.WriteLine("Enter the radius");
            var r = double.Parse(Console.ReadLine());

            program.CalculateTheArea(r);
        }

        public void OperatorExercise(int a,  int b) 
        {
            int division = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} is {division} remainder {remainder}");

        }

        public void CalculateTheArea(double r) 
        {

            double pi = Math.PI;
            Console.WriteLine($"Area of the circle = {pi * r * r}");
        }


    }
}
using System.Runtime.ConstrainedExecution;
using System;

namespace ExceptionHandelingPractice
{
    internal class Program
    {
        
       /* Övning 1 Koden kraschar om användaren inte matar in ett korrekt tal. 
       Gör koden mer robust genom att hantera felaktig inmatning
       (t.ex.om användaren matar in en sträng istället för ett tal).*/
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett tal:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Du matade in: " + number);
        }

        /* Övning 2 Gör koden mer robust genom att hantera fallet 
         där det andra talet är noll, vilket orsakar en DivideByZeroException*/

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Mata in första talet:");
        //    int num1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Mata in andra talet:");
        //    int num2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Resultatet av divisionen är: " + (num1 / num2));
        //}


        /* Övning 3 Gör koden mer robust genom att hantera fallet där filen 
         inte existerar(FileNotFoundException) eller där läsningen misslyckas av någon annan anledning.*/

        //static void Main(string[] args)
        //{
        //    string content = File.ReadAllText("data.txt");
        //    Console.WriteLine(content);
        //}


        /* Övning 4 Hantera fallet där användaren matar in ett 
        index som ligger utanför arrayens gränser(IndexOutOfRangeException */

        //static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    Console.WriteLine("Ange ett index:");
        //    int index = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Värdet vid index är: " + numbers[index]);
        //}
    }
}

using System;

namespace Practice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myDelegate = new MyDelegate(
                (num1, num2) =>
                {
                    Console.Write(num1 + num2);
                },
                (num1, num2) =>
                {
                    return num1 + num2;
                }
            );

            myDelegate.Excute(3, 4);

            Console.ReadKey();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
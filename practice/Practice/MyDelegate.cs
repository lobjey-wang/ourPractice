using System;

namespace Practice
{
    internal class MyDelegate
    {
        private event Action<int, int> ActionDelegate;
        private event Func<int, int, int> FuncDelegate;

        public MyDelegate(Action<int, int> initAction, Func<int, int, int> initFunc)
        {
            ActionDelegate += initAction;
            FuncDelegate += initFunc;
        }

        public void Excute(int num1, int num2)
        {
            if (ActionDelegate != null)
            {
                Console.Write($"ActionDelegate: ");
                ActionDelegate(num1, num2);
            }

            Console.WriteLine("----------------");

            if (FuncDelegate != null)
            {
                Console.WriteLine($"FuncDelegate: {FuncDelegate(num1, num2)}");
            }
        }
    }
}
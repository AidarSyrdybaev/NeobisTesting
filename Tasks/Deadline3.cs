using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Deadline3
    {
        public static void OddNumbersTaskActive()
        {
            int MaxNumber = int.Parse(Console.ReadLine());
            var Numbers = Enumerable.Range(0, MaxNumber).Where(i => i % 2 != 0);
            foreach (int i in Numbers)
                Console.WriteLine(i);
            
        }

        public static void ArrayReplacmentTaskActive()
        {
            var Numbers = new int[10];
            foreach (int i in Enumerable.Range(0, 10))
                Numbers[i] = int.Parse(Console.ReadLine());
            foreach (int i in Enumerable.Range(0, 10))
            {
                if (Numbers[i] > 0)
                    Console.WriteLine($"X[{i}] = {Numbers[i]}");
                else
                    Console.WriteLine($"X[{i}] = 1");
            }
        }

        public static void FibonacciArrayTaskActive()
        {
            int Count = int.Parse(Console.ReadLine());
            var IndexMass = new int[Count];
            foreach (int i in Enumerable.Range(0, Count))
                IndexMass[i] = int.Parse(Console.ReadLine());
            foreach (int i in IndexMass)
                Console.WriteLine($"Fib({i}) = {FibbomacciFormulaFunc(i)}");

            static int FibbomacciFormulaFunc(int index)
            {
                int firstNum = 0;
                int SecondNum = 1;
                foreach (int i in Enumerable.Range(0, index))
                {
                    int Temp = SecondNum;
                    SecondNum = SecondNum + firstNum;
                    firstNum = Temp;
                }
                return firstNum;
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Tasks
{
    public class Deadline4
    {
        public static void SquareMatrixTaskAction()
        {
            int Number = int.Parse(Console.ReadLine());
            var Numbers = new List<int>();
            Numbers.Add(Number);
            while (Number != 0)
            {
                Number = int.Parse(Console.ReadLine());
                Numbers.Add(Number);
            }

            foreach (int i in Numbers)
            {
                GetSquareMatrix(i);
                Console.WriteLine();
            }

            static void GetSquareMatrix(int size)
            {
                int Middle = size / 2 + size % 2;
                for (int i = 1; i < size + 1; i++)
                {
                    for (int a = 1; a < size + 1; a++)
                    {
                        int ABonus = a > Middle && size % 2 == 0 ? 1 : 0;
                        int A = Middle - Math.Abs(Middle - a) + ABonus;
                        int IBonus = i > Middle && size % 2 == 0 ? 1 : 0;
                        int I = Middle - Math.Abs(Middle - i) + IBonus;
                        var Min = (A + I) - (A + I + Math.Abs(I - A)) / 2;
                        int bonus = 0;
                        if (Min > Middle && size % 2 == 0)
                            bonus = 1;

                        Console.Write($"{Middle - Math.Abs(Middle - Min) + bonus} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void GreyscaleTaskAction()
        {
            var Results = new List<string>();
            Dictionary<string, Func<float[], int>> commands = new Dictionary<string, Func<float[], int>>();
            commands.Add("eye", Eye);
            commands.Add("min", Min);
            commands.Add("mean", Mean);
            commands.Add("max", Max);
            int Count = int.Parse(Console.ReadLine());
            foreach (int i in Enumerable.Range(0, Count))
            {
                var FuncName = Console.ReadLine().Trim();
                var Numbers = Console.ReadLine().Split(' ').Select(a => float.Parse(a)).ToArray();
                if (commands.ContainsKey(FuncName))
                    Results.Add($"Caso #{i + 1}: {commands[FuncName.ToLower()](Numbers)}");

            }
            foreach (var answer in Results)
            {
                Console.WriteLine(answer);
            }

            static int Eye(float[] mass)
            {
                return (int)(mass[0] * 0.3 + mass[1] * 0.59 + mass[2] * 0.11);
            }

            static int Min(float[] mass)
            {
                return (int)(mass.Min());
            }

            static int Mean(float[] mass)
            {
                return (int)((mass[0] + mass[1] + mass[2]) / mass.Length);
            }

            static int Max(float[] mass)
            {
                return (int)(mass.Max());
            }
        }

        public static void LedTaskActive()
        {
            var Leds = new List<int>();
            int Count = int.Parse(Console.ReadLine());
            foreach (int i in Enumerable.Range(0, Count))
                Leds.Add(Sum(Console.ReadLine()));
            foreach (int i in Leds)
                Console.WriteLine($"{i} Leds");
            static int Sum(string Number)
            {
                int Sum = 0;
                foreach (char i in Number)
                    Sum += NumberConfig(int.Parse(i.ToString()));
                return Sum;

            }
            static int NumberConfig(int number)
            {
                if (number == 1)
                    return 2;
                else if (number == 5 || number == 2 || number == 3)
                    return 5;
                else if (number == 9 || number == 0)
                    return 6;
                else if (number == 4)
                    return 4;
                else if (number == 6)
                    return 6;
                else if (number == 7)
                    return 3;
                else if (number == 8)
                    return 7;
                else
                    return -1;
            }
        }
    }
}

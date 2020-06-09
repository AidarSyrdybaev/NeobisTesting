using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public static class Deadline2
    {
        public static void SalaryTaskAction()
        {
            int Number = int.Parse(Console.ReadLine());
            float Stavka = float.Parse(Console.ReadLine());
            float Hours = float.Parse(Console.ReadLine());

            Console.WriteLine($"NUMBER = {Number}");
            Console.WriteLine($"SALARY = U$ {string.Format("{0:F2}", Stavka * Hours)}");
        }

        public static void GreatestNumberTaskAction()
        {
            var NumbersTxt = Console.ReadLine().Split(' ');
            var Number1 = int.Parse(NumbersTxt[0]);
            var Number2 = int.Parse(NumbersTxt[1]);
            var Number3 = int.Parse(NumbersTxt[2]);
            var Max = (Number1 + Number2 + Math.Abs(Number1 - Number2)) / 2;
            var Max2 = (Max + Number3 + Math.Abs(Max - Number3)) / 2;

            Console.WriteLine($"{Max2} eh o maior");
        }

        public static void SnackTaskAction()
        {
            var PriceList = new float[] { 4, 4.5f, 5, 2, 1.5f };
            var NumbersTxt = Console.ReadLine().Split(' ');
            var Sum = PriceList[int.Parse(NumbersTxt[0]) - 1] * int.Parse(NumbersTxt[1]);
            Console.WriteLine($"Total: R$ {string.Format("{0:F2}", Sum)}");
        }
    }
}

using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var PriceList = new float[] { 4, 4.5f, 5, 2, 1.5f };
            var NumbersTxt = Console.ReadLine().Split(' ');
            var Sum = PriceList[int.Parse(NumbersTxt[0]) - 1] * int.Parse(NumbersTxt[1]);
            Console.WriteLine($"Total: R$ {string.Format("{0:F2}", Sum)}");
        }
    }
}

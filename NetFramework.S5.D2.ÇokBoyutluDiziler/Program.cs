using System;

namespace NetFramework.S5.D2.ÇokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { -2, 3 }, { 4, 6 }, { 5, 8 } };

            Console.WriteLine("İKİ BOYUTLU DİZİ");
            Console.WriteLine(array[0, 0] + "\t" + array[0, 1]);    // {-2, 3}
            Console.WriteLine(array[1, 0] + "\t" + array[1, 1]);    // {4, 6}
            Console.WriteLine(array[2, 0] + "\t" + array[2, 1]);    // {5, 8}

            int[,,] secArray = { { { 2, 6 }, { 4, 9 }, { 8, -9 } }, { { -2, 13 }, { 6, 7 }, { 17, -19 } } };

            Console.WriteLine("\nÜÇ BOYUTLU DİZİ");
            Console.WriteLine(secArray[0, 0, 0] + "\t" + secArray[0, 0, 1]);
            Console.WriteLine(secArray[0, 1, 0] + "\t" + secArray[0, 1, 1]);
            Console.WriteLine(secArray[0, 2, 0] + "\t" + secArray[0, 2, 1]);

            Console.WriteLine();

            Console.WriteLine(secArray[1, 0, 0] + "\t" + secArray[1, 0, 1]);
            Console.WriteLine(secArray[1, 1, 0] + "\t" + secArray[1, 1, 1]);
            Console.WriteLine(secArray[1, 2, 0] + "\t" + secArray[1, 2, 1]);


            Console.ReadLine();
        }
    }
}
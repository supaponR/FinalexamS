using System;

namespace Final_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            int[] inputNum = new int[Number];
            for(int i = 0; i < inputNum.Length; i++)
            {
                inputNum[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}

using System;

namespace Final_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[3, 3];
            for (int i = 0; i < table.GetLength(1); i++)
            {
                for (int j = 0; j < table.GetLength(0); j++)
                {
                    table[i, j] = 0;
                }
            }
            bool Run = true;
            while (Run = true)
            {
                for (int i = 0; i < table.GetLength(1); i++)
                {
                    for(int j = 0; j < table.GetLength(0); j++)
                    {
                        int tablenum = int.Parse(Console.ReadLine());
                        if (i == 0)
                        {
                            tablenum = table[0, j];
                        }
                        if(i== 1)
                        {
                            tablenum = table[1, j];
                        }
                        if (i == 2)
                        {
                            tablenum = table[2, j];
                        }
                    }
                }
               

            }

        }


    }
}

using System;

namespace Final_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0 , sumRealNumber = 0, count=0;
            int Mean;
            int[] ArrayNum;
            bool RunInputnum = false;
            while(RunInputnum = false)
            {
                int RealNumber = int.Parse(Console.ReadLine());
                ArrayNum = new int[count++];
                for (int i = 0; i < RealNumber; i++)
                {
                    ArrayNum[i] = RealNumber;
                }
                RealNumber.ToString();
                if (RealNumber = "End")
                {
                    RunInputnum = true;
                    
                    sum = sum++;
                    sumRealNumber += RealNumber;
                }
            }
            string Mode;
            int max;
            Mode = Console.ReadLine();
            switch (Mode)
            {
                case "FindMax":
                    for(int i = 0; i < sum; i++)
                    {
                        if (Math.Max(ArrayNum) > ArrayNum[i + 1])
                        {

                        }
                    }
                    
                    break;
                case "FindMin":
                    break;
                case "FindMean":
                    Mean = sumRealNumber / sum;
                    Console.WriteLine("Meam = {0}", Mean);
                    break;
                case "":
                    Console.WriteLine("Invalid mode");
                    break;
            }
        }
    }
}

using System;

namespace Final_4
{
    class Program
    {
        struct infoCity
        {
            public String NameCity;
            public int Citynearly;
            public int CityNearNum;
        }
        static void Main(string[] args)
        {
            int CityNum = int.Parse(Console.ReadLine());
            infoCity[] CityNumArray = new infoCity[CityNum];
            for (int i = 0; i < CityNum; i++)
            {
                CityNumArray[i].NameCity = Console.ReadLine();
                CityNumArray[i].Citynearly = int.Parse(Console.ReadLine());
                CityNumArray[i].CityNearNum = int.Parse(Console.ReadLine());

            }
        }
    }
}

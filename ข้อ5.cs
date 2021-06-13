using System;

namespace Final_5
{
    class Program
    {
        struct InfoItem
        {
            public String name;
            public String Type;
        }
        static void Main(string[] args)
        {
            int NumItem = int.Parse(Console.ReadLine());
            InfoItem[] Item = new InfoItem[NumItem];
            int i,r;
            
            for ( i = 0; i < Item.Length; i++)
            {
                Item[i].name = Console.ReadLine();
                Item[i].Type = Console.ReadLine();
                Console.WriteLine();
            }

            bool RunMode = false;
            while (RunMode = true)
            {

                String Mode = Console.ReadLine();
                if (Mode == "ShowAll")
                {
                    for (int k = 0; k < Item.Length; k++)
                    {
                        Console.WriteLine(Item[k].name);
                        Console.WriteLine(Item[k].Type);
                        Console.WriteLine();
                    }
                }
                
                else if (Mode != "showAll" )
                {
                    for (int j = 0; j < Item.Length; j++)
                    {
                        if (Mode == Item[j].Type)
                        {
                            Console.WriteLine(Item[j].name);
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    RunMode = true;
                    Console.WriteLine("End");
                }
            }
        }
    }
}

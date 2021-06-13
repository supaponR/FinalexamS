using System;

namespace Final_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] FileArray;
            
            FileArray = new string[5];
            for (int i = 0; i < FileArray.Length; i++)
            {
                FileArray[i] = " ";
            }
            ModePage();
            int Number;
            bool RunMode = false;
            while (RunMode = false)
            {
                Number = int.Parse(Console.ReadLine());
                if (Number == 0)
                {
                    for (int i = 0; i < FileArray.Length; i++)
                    {
                        Console.WriteLine(FileArray[i]);
                    }
                }
                else if (Number == 1)
                {
                    
                }
                else if (Number == 2)
                {

                }
                else if (Number == 3)
                {
                    RunMode = true;
                }
                else
                {
                    Console.WriteLine("Invalid menu number.");
                }
                ModePage();
            }
            
            


        }
        static void ModePage()
        {
            Console.WriteLine("Please input a number from 0 - 3 to choose the following menu: ");
            Console.WriteLine("[0] Show all recent files ");
            Console.WriteLine("[1] Open new file ");
            Console.WriteLine("[2] Open recent file ");
            Console.WriteLine("[3] Exit");
        } 
    }
}

﻿namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Teie töö on teha switch rakendus
            //kus on kolm case (1, 2, 3).
            //Iga case puhul teeb erineb arb beep-e
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Beep(1000, 500);
                    break;
                case 2:
                    Console.Beep(2000, 500);
                    Console.Beep(2000, 500);
                    break;
                case 3:
                    Console.Beep(3000, 50);
                    Console.Beep(3000, 50);
                    Console.Beep(3000, 50);
                    break;

                    default:
                    Console.WriteLine("Error kood ei tööta!");
                    break;
            }
        }
    }
}

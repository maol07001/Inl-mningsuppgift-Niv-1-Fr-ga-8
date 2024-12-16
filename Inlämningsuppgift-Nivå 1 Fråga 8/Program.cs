using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int produkt = 1; 
            for (int i = 1; i <= 5; i++)
            {
                produkt *= i; // produkt = produkt * i
            }

            Console.WriteLine("Produkten av heltalen från 1 till 5 är:" + produkt);
        }
    }
}

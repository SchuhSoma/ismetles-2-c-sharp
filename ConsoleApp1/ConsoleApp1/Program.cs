using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Feladat1(); Console.WriteLine("\n----------------------\n");
            Feladat2(); Console.WriteLine("\n----------------------\n");
            Feladat3();
            Console.ReadKey();
        }

        private static void Feladat3()
        {
            Console.Write("Kérem adja meg a magasságát cm-ben: ");
            double Magassag = double.Parse(Console.ReadLine()) / 100;
            Console.Write("Kérem adja meg a testsúlyát kg-ban: ");
            double Suly = double.Parse(Console.ReadLine());
            double TestomegIndex = Suly / Math.Pow(Magassag, 2);
            Console.WriteLine("Az Ön testömeg indexe: {0:0.00}", TestomegIndex);
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat:Kártya");
            int Kartya = 0;
            int Sum = 0;
            double Atlag = 0;
            int db7 = 0;
            for(int i=1; i<=15; i++)
            {
                Kartya = rnd.Next(1, 11);
                Sum += Kartya;
                if(Kartya==7)
                {
                    db7++;
                }
                Console.WriteLine("\t{0:00}. kártya : {1}",i, Kartya);
            }
            Atlag = (double)Sum / 15;
            Console.WriteLine("\tA kártyák összege: {0}", Sum);
            Console.WriteLine("\tA kártyák összegének átlaga: {0:0.00}", Atlag);
            Console.WriteLine("\tA hetes kártyát ennyi alkalommal osztották ki: {0}", db7);
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat: számok 2400-ig amik " +
                "oszthatók 6-al és 15-el is");
            for(int i=0; i<=2400; i++)
            {
                if(i%6==0 && i%15==0)
                {                  
                    if (i%12==0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("{0} ,", i);
                    Console.ResetColor();
                }
            }
        }
    }
}

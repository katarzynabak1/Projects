using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr_1Bak48678
{
    class Program
    {
        static void Main(string[] args)
        {   //wypisanie metryki programu 
            Console.WriteLine("\n\tProgram umożliwiający określenie, czy wczytana liczba" + "\n\tjest liczbą doskonałą");
            //deklaracje lokalne 
            int n, a;
            //zaproszenie do podania ilości liczb
            Console.Write("\n\tPodaj, ile liczb chcesz sprawdzić: ");
            //sprawdzenie poprawności wpisywanej liczby
            do
            {
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("\n\tERROR!!! Wystąpił niedozwolony bład w zapisie n");
                    Console.Write("\n\tPodaj ponownie, ile liczb chcesz sprawdzić: ");
                }
                if (n <= 0)
                {
                    Console.WriteLine("\n\tERROR N MUSI BYC WIEKSZE OD 0!!!");
                    Console.Write("\n\tPodaj ponownie, ile liczb chcesz sprawdzić: ");
                }
            } while (n <= 0);
            //wczytanie ze sprawdzeniem liczb, które mają być liczbami doskonałymi
            for (int i = 0; i < n; i++)

            {
                int suma = 0;
                Console.Write("\n\tPodaj {0} liczbę: ", i + 1);
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("\n\tERROR! Wystąpił niedozwolony znak w zapisie liczby");
                    Console.Write("\n\tPodaj ponownie {0} liczbę: ", i + 1);
                }
                if (a == 0)
                {
                    Console.WriteLine("Wystąpił błąd w zapisie liczby a");
                    Console.Write("Podaj ponownie liczbę: ");
                }
                
                //sprawdzenie, czy liczba jest doskonała przy pomocy dzielenia 
                    for (int j = 1; j < a; j++)
                    
                        if (a % j == 0)
                        {
                            suma = suma + j;
                        }
                    //wypisanie wyniku 
                    if (suma == a)
                    {
                        Console.WriteLine("\n\tLiczba {0} jest doskonała", a);
                    }
                    else
                        Console.WriteLine("\n\tLiczba {0} nie jest doskoanała", a);
                    }
            //zakończenie programu
                Console.Write("\n\tKONIEC PROGRAMU");
                Console.ReadKey();
                }
            }
        }
    


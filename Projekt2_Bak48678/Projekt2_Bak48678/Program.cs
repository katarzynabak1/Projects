using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Bak48678
{
    class Program
    {   static float WczytajLiczbeRzeczywista(string ZaproszenieDoPodaniaDanej)
        {
            float kbx;
            Console.Write("\n\t" + ZaproszenieDoPodaniaDanej);
            while (!float.TryParse(Console.ReadLine(), out kbx))
            {//sygnalizacja błędu w zapisie x
                Console.WriteLine("\n\tERROR!!! Wystąpił niedozwolony znak w zapisie zmiennej!");
                Console.Write("\n\tPodaj ponownie zmienną: ");
            }
            return kbx;
        }
        static void kbSumaSzereguPotegowego (float kbx, float kbeps, out double kbSuma, out double kbn)
        {
            double kbw;
            //początkowe wartości 
            kbSuma = 0.0F;
            kbw = 1.0F;
            kbn = 1.0f;
            do
            {
                kbn++;
                kbw = Math.Pow((kbx - 1), kbn) * Math.Sin(1 / Math.Sqrt(kbn));
                kbSuma = kbSuma + kbw;
            } while (Math.Abs(Math.Abs((kbSuma - kbw)) - kbSuma) > kbeps);
        }
        static void kbWartoscSzereguPotegowego (float kbx, out double kbWartosc)
        {

             kbWartosc = 0.0f;
            double kbn = 1.0f;
            kbWartosc = Math.Pow((kbx - 1), kbn) * Math.Sin(1 / Math.Sqrt(kbn));
           
        }
        static void Main(string[] args)
        {   //deklaracje lokalne
            ConsoleKeyInfo WybranaFunkcjonalnosc;
            //ustawienia konsoli 
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowWidth = 125;
            //wypisanie daty
            Console.WriteLine("\n\tDzisiejsza data: {0}", DateTime.Today.ToShortDateString());
            //wypisanie metryki programu 
            Console.WriteLine("\n\tProgram umożliwiający obliczenie sumy szeregu potęgowego" + "\n\toraz tablicowanie jego wartości." + "Wzór szeregu: (x-1)^n * sin(1/sqrt(n))");
            do
            {//wypisanie MENU
                Console.WriteLine("\n\tMENU PROGRAMU");
                Console.WriteLine("\n\tA. Obliczenie sumy szeregu potęgowego");
                Console.WriteLine("\n\tB. Tablicowanie wartości szeregu potęgowego");
                Console.WriteLine("\n\tC. Wyjście z programu");
                Console.Write("\n\tWybierz funkcjonalość podając odpowiednią literę: ");
                WybranaFunkcjonalnosc = Console.ReadKey();
                if (WybranaFunkcjonalnosc.Key == ConsoleKey.A)
                { //deklaracje lokalne 
                    float kbx, kbeps;
                    double kbSuma = 0.0F, kbn = 1.0F;
                    //wypisanie informacji o wybranej funkcjonalości 
                    Console.WriteLine("\n\tObliczenie sumy szeregu potęgowego ");
                    //wypisanie zaproszenia do podania x
                    do
                    {
                        kbx = WczytajLiczbeRzeczywista("\n\tPodaj x, dla którego chcesz policzyć sumę szeregu potęgowego: ");
                        //sprawdzenie warunku dla x ---> ma należeć od (0;1)
                        if (kbx <= 1.0F || kbx >= 2.0F)
                        {   //sygnalizacja błędu
                            Console.Write("\n\tERROR!!! Wartość x musi należeć do przedziału (1;2)");
                        }

                    } while (kbx <= 1.0F || kbx >= 2.0F);
                    //wypisanie zaproszenia do podania Eps   
                    do
                    {
                       kbeps = WczytajLiczbeRzeczywista("\n\tPodaj, z jaką dokładnością chcesz policzyć sumę szeregu: ");
                        if (kbeps <= 0 || kbeps >= 1.0F)
                        {
                            //sygnalizacja błędu
                            Console.WriteLine("\n\tERROR!!! Eps musi znajdować się w przedziale 0 < eps < 1.");
                        }
                    } while (kbeps <= 0 || kbeps >= 1.0F);
                    kbSumaSzereguPotegowego(kbx, kbeps, out kbSuma, out kbn);
                    //wypisanie wartosci sumy szeregu
                    Console.WriteLine("\n\tSuma szeregu jest równa: {0}", kbSuma);
                    //wypisanie liczby zsumowanych wyrazów
                    Console.WriteLine("\n\tLiczba zsumowanych wyrazów jest równa: {0}", kbn);
                }
                else if (WybranaFunkcjonalnosc.Key == ConsoleKey.B)
                { //wypisanie informacji o wybranej funkcjonalności 
                    Console.WriteLine("\n\tTablicowanie wartości szeregu potęgowego.");
                    //deklaracje lokalne
                    float kbXd, kbXg, kbh;
                    //wypisanie zaproszenia do podania przedziału zmian wartości x
                        do
                        {
                            Console.Write("\n\tPodaj wartość dolnej granicy przedziału: ");
                            while (!float.TryParse(Console.ReadLine(), out kbXd))
                            {//sygnalizacja błędu w zapisie x
                                Console.WriteLine("\n\tERROR!!! Wystąpił niedozwolony znak w zapisie dolnej granicy!");
                                Console.Write("\n\tPodaj ponownie dolną granicę: ");
                            }
                            if (kbXd <= 1.0F || kbXd >= 2.0F)
                            {
                                Console.WriteLine("\n\tERROR! Granica musi zawierać się w przedziale (1;2)");
                            }
                        } while (kbXd <= 1.0F || kbXd >= 2.0F);
                        do
                        {
                            Console.Write("\n\tPodaj wartość górnej granicy przedziału: ");
                            while (!float.TryParse(Console.ReadLine(), out kbXg))
                            {//sygnalizacja błędu w zapisie x
                            Console.WriteLine("\n\tERROR!!! Wystąpił niedozwolony znak w zapisie górnej granicy!");
                            Console.Write("\n\tPodaj ponownie górną granicę: ");
                        }
                            if (kbXd >= kbXg || (kbXg <= 1.0F || kbXg >= 2.0F))
                            {
                                Console.WriteLine("\n\tERROR! Górna granica musi być większa od dolnej!" +
                                    "\n\toraz musi zawierać się w przedziale (1;2)");
                            }
                        } while (kbXd >= kbXg || (kbXg <= 1.0F || kbXg >= 2.0F));
                    /*wczytanie wartości h, czyli przyrostu zmian wartości w kolejnych krokach tablicowania 
                    zmiennej niezależnej x*/
                    do
                    {
                        kbh = WczytajLiczbeRzeczywista("\n\tPodaj wartość 'h', czyli wartości przyrostu zmian zmiennej niezależnej x: ");
                        //wczytanie warunku na h
                        if (kbh <= 0.0F || kbh > (kbXg - kbXd) / 2)
                            Console.WriteLine("\n\tWartość h musi być większa od 0" +
                                 "\n\toraz musi być mniejsza od połowy różnicy krańców przedziału!");

                    } while (kbh <= 0.0F || kbh > (kbXg - kbXd) / 2);
                    //wypisanie nagłowka tablicy
                    Console.WriteLine("\n\tTabela wartości szeregu potęgowego: ");
                    //wypisanie nazw kolumn funkcjonalności tablicowania 
                    Console.WriteLine("\n\nWartość x:\t\t\tWartość: (Format F):\t\t(Format E):\t\t\t(Format G): ");
                    //odstęp między nagłówkiem tabeli a wartościami 
                    Console.WriteLine("________________\t\t______________________\t\t________________________\t________________________");
                    //deklaracje lokalne do wczytania danych 
                    double kbWartosc=0.0F;
                    //obliczenie wartości szeregu dla podanych danych wejściowych 
                    float kbx;
                    for ( kbx = kbXd; kbx <= kbXg; kbx = kbx + kbh)
                    {
                        kbWartoscSzereguPotegowego(kbx, out kbWartosc);
                        Console.WriteLine("{0,10:F}\t\t\t{1,10:F}\t\t\t{1,10:E}\t\t\t{1,10:G}", kbx, kbWartosc);

                    }
                }
                
                else if (WybranaFunkcjonalnosc.Key == ConsoleKey.C)
                {
                    //chwilowe zatrzymanie programu 
                    Console.Write("\n\tDla zakończenia programu naciśnij dowolny klawisz...");
                    Console.ReadKey();
                    //wypisanie informacji o autorze programu i chwilowe zatrzymanie programu
                    Console.WriteLine("\n\tZAKOŃCZENIE PROGRAMU");
                    Console.WriteLine("\n\tAutor programu: Katarzyna Bąk, Numer indeksu: 48678");
                }
                //sprawdzenie, czy użytkownik wybrał właściwą funkcjonalność
                else
                {   //wypisanie informacji o podaniu złej funkcjonalności i zaproszenie do podania właściwej
                    Console.WriteLine("\n\tNie ma takiej funkcjonalności!");
                }
                } while (WybranaFunkcjonalnosc.Key != ConsoleKey.C) ;
                Console.ReadKey();
            }
    }
}



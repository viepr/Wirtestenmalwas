using System;
using System.Linq;
using System.Text;
using System.Collections;

namespace Wirtestenmalwas
{
    class Program
    {
        static void Main(string[] args)
    
        {
            int y = 1;
            string z = "Hallo Ihr";
            while(y < 10)  {
                    Ausgabe(z, y);
                   y = Eingabe(y);
                            }
            MeineKlasse instanzMeine = new MeineKlasse();
            instanzMeine.MeineMethode();
            Console.ReadKey();
            
        }

        static int  Eingabe(int x)
        {
            int result;
            result = x + 1;
            return result;
        }

        static void Ausgabe(string x, int y)
        {
            Console.WriteLine( x + y);
           
            
        }
    }
    public class MeineKlasse
    {
        public void MeineMethode()
        {
            Console.WriteLine("Ausgabe aus der Klasse");
        }
    }
}

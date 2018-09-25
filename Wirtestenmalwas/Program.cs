using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Configuration;

namespace Wirtestenmalwas
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int y = 1;

            string z = "Hallo Ihr", variable1, variable2;
            variable1 = System.Configuration.ConfigurationManager.AppSettings["var1"];
            variable2 = System.Configuration.ConfigurationManager.AppSettings["var2"];
            while (y < 10)  {
                    Ausgabe(z, y);
                   y = Eingabe(y);
                            }
            MeineKlasse instanzMeine = new MeineKlasse();
            instanzMeine.MeineMethode();
            MeinQuad meinneuesquad = new MeinQuad();
            meinneuesquad.AQD(variable1 ,variable2 );
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
    public class MeinQuad
    {
        public void AQD(string x, string y)
        {
            Console.WriteLine(x + y);


        }
    }
}

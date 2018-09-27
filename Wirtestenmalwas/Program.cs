using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Configuration;
using System.IO;

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
            while (y < 10)
            {
                Ausgabe(z, y);
                y = Eingabe(y);
            }
            MeineKlasse instanzMeine = new MeineKlasse();
            instanzMeine.MeineMethode();
            MeinQuad meinneuesquad = new MeinQuad();
            meinneuesquad.AQD(variable1, variable2);
            MeinSchrLe schreiblese = new MeinSchrLe();
            schreiblese.LeseSchreibe();
            Console.ReadKey();

        }

        static int Eingabe(int x)
        {
            int result;
            result = x + 1;
            return result;
        }

        static void Ausgabe(string x, int y)
        {
            Console.WriteLine(x + y);


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
    public class MeinSchrLe
    {
        public void LeseSchreibe()
        {

            StreamReader reader = new StreamReader("f:\\file.txt");
            string line = reader.ReadLine();
            // UTF8Encoding(line);
            Console.WriteLine(line);

        }

        private void UTF8Encoding(string v)
        {
            throw new NotImplementedException();
            //foreach ( ) {
            //byte[] utf = Encoding.UTF8.GetBytes(v);

            //Console.WriteLine(utf);
        }
    }
}


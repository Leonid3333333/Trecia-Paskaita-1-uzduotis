using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.Marshalling;

namespace PirmaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // Random rnd = new Random();
           // metuSkaiciavivas(rnd.Next(1, 6));

           // valPoVidurnakcio();

           // Random v = new Random();
           // Random n = new Random();
           // VidKnygu(v.Next(10, 100), n.Next(1, 50));

           Random a = new Random();
           Random b = new Random();
           Random c = new Random();

           iVilniu(a.Next(100, 300), b.Next(10, 15), c.Next(50, 99));




        }
        /*
 * 1. Sukurkite metodą, kuris priima metų skaičių ir atspausdina, 
kiek mėnesių, dienų ir valandų tai yra. Tarkime kad metai turi 365 dienas.
Pvz.: "16 metu, tai: 192 menesiu, 5840 dienu, 140160 valandu."

        public static void metuSkaiciavivas(int metai)
        {

            int men = metai * 12;
            int day = metai * 365;
            int hour = day * 24;
            Console.WriteLine($"{metai} metai bus - {men} menesiai(u), {day} dienos ir {hour} valamdos" );

        }
        */
        /* 2. Sukurkite metodą, kuris pagal šiuo metu esančių valandų bei minučių skaičių
     (naudokite parametrus hour ir minute iš DateTime) apskaičiuoja kiek minučių ir sekundžių praėjo po vidurnakčio.
     Pvz.: "Siuo metu yra 14val. 33min., tai praejo 873 minutes (arba 52380 sekundziu) po vidurnakcio."

     galime naudoti tokius parametrus iš DateTime tipo objekto:

     DateTime.Now.Hour
     DateTime.Now.Minute
     
        public static void valPoVidurnakcio()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int minutes = hour * 60;
            int sekundes = min * 60;
            Console.WriteLine($"Sio metu yra {hour} valandu ir tai bus {minutes} minuciu ir {sekundes} sekundziu po vidurnakcio");



        }
        */

        /* 3. Sukurkite metodą, kuris suskaičiuoja, kiek knygų k vidutiniškai per metus perskaito
     vienas mokyklos bibliotekos lankytojas.Žinomas vidutiniškai per mėnesį perskaitytų
     knygų skaičius v ir vidutiniškai per metus apsilankiusių bibliotekoje skaičius n.

     galite naudoti random skaicius:
         */
        /*
       public static void VidKnygu(int v, int n)
        {
            int k = (v * 12) / n;

            Console.WriteLine($"Vidutiniskai per metus lakytojas perskaito {k} knygas(u) ");


        }
        */
        /*
         * 4. Sukurkite metodą, kuris suskaičiuoja, kiek vidutiniškai keleivių k važiuoja į Vilnių
	viename traukinio vagone, jei žinomas traukinio keleivių skaičius n, keleivių, vykstančių
	ne į Vilnių skaičius m ir vagonų skaičius v. 

	galite naudoti random skaicius:

        */ 
       public static void iVilniu(int a, int b, int c)
        {
            int d = (a - c) / b;

            Console.WriteLine($"Vidutiniskai {d} keleiviu vaziuoja i Vilniu");


        }
        









    }

}

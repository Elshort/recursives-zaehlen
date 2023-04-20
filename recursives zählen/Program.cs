using System;
using System.ComponentModel.DataAnnotations;

namespace Recuzaehlen
{
    class programm
    {

         static void Main()
        {
            Console.WriteLine("bitte Position eingeben");
            int position = Convert.ToInt32(Console.ReadLine());
            if (position == 0)
            {

                Console.WriteLine("0");
            }
            else
            {

                Console.WriteLine(rezaehlen(position - 1));

            }        

            
        }
        // Alte Funktion mit zwei Variablen.
        /*static long rezaehlen(int repeater, long zahl)
        {
            if (repeater == 0)
            {
                return zahl;
                
            }
            else if (zahl == 0)
            {
                zahl++;
                repeater--;
                zahl = rezaehlen(repeater, zahl);

            }
            else //if(zahl == )
            {
                zahl = zahl + rezaehlen(--repeater,0);
                zahl = rezaehlen(repeater, zahl);

            }
            return zahl;

        }*/
        public static int rezaehlen(int position) {


            if (position <= 0)

            {

            return 1;

            }

            if (position == 0) {

            return 1; 

            }

            if(position == 1) {

            return 1;

            }
            
            else {

            return rezaehlen(position - 2) + rezaehlen(position - 1);

            }
        }
    }
}



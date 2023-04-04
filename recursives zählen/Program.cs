using System;
using System.ComponentModel.DataAnnotations;

namespace Recuzaehlen
{
    class programm
    {

        static void Main()
        { 
            

            Console.WriteLine(rezaehlen(20,0));

            
        }

        static long rezaehlen(int repeater, long zahl)
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

        }
    }
}



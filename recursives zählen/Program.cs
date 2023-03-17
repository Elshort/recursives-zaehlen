using System;

namespace Recuzaehlen
{
    class programm
    {

        static void Main()
        { 
            

            Console.WriteLine(rezaehlen(50,0,0));

            
        }

        static long rezaehlen(int repeater, long zahl, long altzahl)
        {
            if (repeater == 0)
            {
                return zahl;
                
            }
            else if (zahl == 0)
            {
                altzahl = zahl;
                zahl++;
                repeater--;
                zahl = rezaehlen(repeater, zahl, altzahl);

            }
            else 
            {
                
                zahl = zahl + altzahl;
                altzahl = zahl - altzahl;
                repeater--;
                zahl = rezaehlen(repeater, zahl, altzahl);

            }
            return zahl;

        }
    }
}



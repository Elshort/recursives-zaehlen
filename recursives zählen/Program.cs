using System;

namespace Recuzaehlen
{
    class programm
    {

        static void Main()
        { 
            

            Console.WriteLine(rezaehlen(10,0,0,0));

            
        }

        static int rezaehlen(int repeater, int zahl, int altzahl, int rundenzähler)
        {
            if (rundenzähler == repeater)
            {
                return zahl;
                
            }
            else if (zahl == 0)
            {
                altzahl = zahl;
                zahl++;
                rundenzähler++;
                rezaehlen(repeater, zahl, altzahl, rundenzähler);

            }
            else 
            {
                
                zahl = zahl + altzahl;
                altzahl = zahl - altzahl;
                rundenzähler++;
                rezaehlen(repeater, zahl, altzahl, rundenzähler);

            }
            return zahl;

        }
    }
}



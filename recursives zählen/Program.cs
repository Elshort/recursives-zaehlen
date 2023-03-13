using System;

namespace Recuzählen
{
    class programm
    {
        public static int zahl = 0;
        public static int altzahl = 0;
        public static int rundenzähler = 0;
        public static int repeater = 10;

        static void Main()
        { 
            

            Console.WriteLine(rezählen(repeater));

            
        }

        static int rezählen(int repeater)
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
                rezählen(repeater);
                return zahl;
            }
            else if (rundenzähler != repeater)
            {
                
                zahl = zahl + altzahl;
                altzahl = zahl - altzahl;
                rundenzähler++;
                rezählen(repeater);
                return zahl;
            }
            return zahl;

        }
    }
}



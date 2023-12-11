using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionC.Servicios
{
   
        internal class MenuImplementacion : MenuInterfaz
        {


            public void mostrarmeMensajeBienvenida()
            {
                string mensaje = "  My Lady te tengo una pequeña sorpresa.";
                Console.WriteLine(mensaje);
            }

            public int mostrarMenuYSeleccion()
            {
            Console.WriteLine("");
            Console.WriteLine("  Elige un nivel del 1 al 5 sobre cuanto me quieres.");

            int opcionIntroducida;
                Console.WriteLine("  *********************");
                Console.WriteLine("  0. Cerrar aplicación.");
                Console.WriteLine("  1. Nada o casi nada.");
                Console.WriteLine("  2. Realmente poco.");
                Console.WriteLine("  3. ¿Lo dejamos en un quizás?");
                Console.WriteLine("  4. Es bastante pero podía ser perfecto.");
                Console.WriteLine("  5. No me quieres.ME AMASS.");
         
                Console.WriteLine("*********************");

                opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

                return opcionIntroducida;

            }
        }
}

using EleccionC.Servicios;

namespace CajeroMenuC.Controladores
{
    class Program
    {
        static void Main(string[] args)

        {

     MenuInterfaz aka = new MenuImplementacion();
           

            aka.mostrarmeMensajeBienvenida();

      
            bool cerrarMenu = false;
 
            int opcionSelecionada;

    

            while (!cerrarMenu)
            {
                opcionSelecionada = aka.mostrarMenuYSeleccion();

                switch (opcionSelecionada)
                {
                    case 0:
                        Console.WriteLine("Hasta pronto guapa jejeje.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Enserio le has dado al 1 jooo");
                        break;
                    case 2:
                        Console.WriteLine("No hombre no si en verdad nos queremos mucho");
                        break;
                    case 3:
                        Console.WriteLine("Este es un si pero a la vez no");
                        break;
                    case 4:
                        Console.WriteLine("La próxima vez seguro que llegamos al 5.");
                        break;
                    case 5:
                        Console.WriteLine("Sabia que ibas a escoger este jejeje");
                        Console.WriteLine("    ♥♥    ♥♥    ");
                        Console.WriteLine("  ♥♥   ♥♥   ♥♥  ");
                        Console.WriteLine("   ♥♥      ♥♥   ");
                        Console.WriteLine("     ♥♥  ♥♥     ");
                        Console.WriteLine("       ♥♥       ");
                        break;
                    default:
                        Console.WriteLine("Son 5 números no es tan difícil JAJAJAJAJA");
                        break;
                }

            }
        }


    }


}

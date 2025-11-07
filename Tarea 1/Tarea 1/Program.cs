namespace Tarea_1
{
    internal class Program
    {


        public static int Revision()
        {
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int y);
                if (y == 0)
                {
                    Console.WriteLine("Ingrese un numero valido...");
                }
                else
                {
                    return y;
                    break;
                }
            }
        }


        static void Main(string[] args)
        {
            // Codigo que pregunte por numeros aleatorios y los ponga en una lista
            // luego se le solicita al usuario un el numero de la posiciones de la lista
            // Sumaria los nuemros de la posicion correspondiente

            // Tomar en cuenta errores como lestras, numeros fuera de rango, espacios vacios, etc.

            /*
            O tambien podemos preguntar por nombres, luego pedir las edades de cada uno y luego imprimrlas una por una.
            */



            /*
            Recordar el TryParse, Listas, manejo de errores con try catch, ciclos, condicionales, etc.
            */
            bool a = true;
            try
            {
                List<int> numeros = new List<int>();
                Console.WriteLine("Ingrese una lista de numeros...\n");

                // Ingreso de numeros
                Console.Write("Ingrese el primer numero: ");
                int num1 = Revision();
                numeros.Add(num1);

                Console.Write("Ingrese el segundo numero: ");
                int num2 = Revision();
                numeros.Add(num2);

                Console.Write("Ingrese el tercer numero: ");
                int num3 = Revision();
                numeros.Add(num3);

                // Mostrar lista inicial
                for (int i = 0; i < numeros.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {numeros[i]}");
                }

                // Modificacion de numeros
                while (a)
                {
                    Console.WriteLine("Ingrese la opcion deseada:");
                    Console.WriteLine("1. Cambiar un numero de la lista");
                    Console.WriteLine("2. Salir");
                    int opcion = Revision();
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\nIngrese la posicion del numero que desea cambiar (1, 2 o 3): \n");
                            int elmposicion = Revision();
                            if (elmposicion < 0 || elmposicion > 3)
                            {
                                Console.WriteLine("Posicion fuera de rango. Intente de nuevo.\n");
                            }
                            else
                            {
                                // Cambiar numero en la posicion indicada
                                Console.WriteLine("Numero eliminado... Ingrese el nuevo numero: ");
                                int.TryParse(Console.ReadLine(), out int nuevonumero);
                                while (true)
                                {
                                    if (nuevonumero == 0)
                                    {
                                        Console.WriteLine("Ingrese un numero valido...");
                                    }
                                    else
                                    {
                                        numeros[elmposicion - 1] = nuevonumero;
                                        break;
                                    }
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("Saliendo del programa...");
                            a = false;
                            break;


                            break;
                        default:
                            Console.WriteLine("Opcion no valida. Intente de nuevo.\n");
                            break;
                    }

                    for (int i = 0; i < numeros.Count(); i++)
                        {
                            Console.WriteLine($"{i + 1}. {numeros[i]}");
                        }
                    
                }
                // Lista Final
                Console.WriteLine("Lista final de numeros:");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{i + 1}. {numeros[i]}");
                }

            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error.");
                Console.WriteLine("Intente nuevamente...");
            }
            Console.WriteLine("Fin///");
        }
    }
}

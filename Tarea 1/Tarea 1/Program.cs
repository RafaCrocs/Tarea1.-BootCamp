namespace Tarea_1
{
    internal class Program
    {


        public static int Revision()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int y))
                {
                    Console.WriteLine("Ingrese un numero valido...");
                }
                else
                {
                    return y;
                }
            }
        }


        static void Main(string[] args)
        {
            bool a = true;
            try
            {
                List<int> numeros = new List<int>();
                Console.WriteLine("Ingrese la cantidad de numeros que desea...\n");
                int cantidad = Revision();
                // Ingreso de numeros
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"Ingrese el numero {i + 1}: ");
                    int numero = Revision();
                    numeros.Add(numero);
                }
                // Mostrar lista inicial
                Console.WriteLine("\nLista seleccionada:");
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
                            Console.WriteLine("\nIngrese la posicion del numero que desea cambiar:");
                            int elmposicion = Revision();
                            if (elmposicion < 0 || elmposicion > cantidad)
                            {
                                Console.WriteLine("Posicion fuera de rango. Intente de nuevo.\n");
                            }
                            else
                            {
                                // Cambiar numero en la posicion indicada
                                Console.WriteLine("Numero eliminado... Ingrese el nuevo numero: ");
                                while (true)
                                {
                                    
                                    if (!int.TryParse(Console.ReadLine(), out int nuevonumero))
                                    {
                                        Console.WriteLine("Ingrese un numero valido...");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        numeros[elmposicion - 1] = nuevonumero;
                                        Console.WriteLine("\nLista Modificada:");
                                        for (int i = 0; i < numeros.Count(); i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {numeros[i]}");
                                        }
                                        break;
                                    }
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("\nSaliendo del programa...");
                            a = false;
                            break;


                            break;
                        default:
                            Console.WriteLine("Opcion no valida. Intente de nuevo.\n");
                            break;
                    }
                }
                // Lista Final
                Console.Clear();
                Console.WriteLine("\nLista final de numeros:");
                for (int i = 0; i < numeros.Count; i++)
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

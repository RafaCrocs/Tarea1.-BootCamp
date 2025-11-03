namespace Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Codigo que pregunte por numeros aleatorios y los ponga en una lista
            // luego se le solicita al usuario un el numero de la posiciones de la lista
            // Sumaria los nuemros de la posicion correspondiente

            // Tomar en cuenta errores como lestras, numeros fuera de rango, espacios vacios, etc.

            /*
            * O tambien podemos preguntar por nombres, luego pedir las edades de cada uno y luego imprimrlas una por una.
            */



            /*
             * Recordar el TryParse, Listas, manejo de errores con try catch, ciclos, condicionales, etc.
             */
            bool a = true;
            try
            {
                do
                {
                    List<int> numeros = new List<int>();
                    Console.WriteLine("Ingrese una lista de numeros...\n");

                    Console.Write("Ingrese el primer numero: ");
                    int num1 = int.Parse(Console.ReadLine());
                    numeros.Add(num1);

                    Console.Write("Ingrese el segundo numero: ");
                    int num2 = int.Parse(Console.ReadLine());
                    numeros.Add(num2);

                    Console.Write("Ingrese el tercer numero: ");
                    int num3 = int.Parse(Console.ReadLine());
                    numeros.Add(num3);

                    
                    for (int i = 0;i < numeros.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {numeros[i]}");
                    }
                    
                    while (a)
                    {
                        Console.WriteLine("Ingrese la posicion del numero que desea cambiar (1, 2 o 3): \nENTER para omitir...");
                        int.TryParse(Console.ReadLine(), out int elmposicion);
                        if (elmposicion < 0 || elmposicion > 3)
                        {
                            Console.WriteLine("Posicion fuera de rango. Intente de nuevo.");
                        }
                        else if (elmposicion == 0)
                        {
                            Console.WriteLine("Saliendo del programa...");
                            a = false;
                        }
                        else
                        {
                            Console.WriteLine("Numero eliminado... Ingrese el nuevo numero: ");
                            int nuevonumero = int.Parse(Console.ReadLine());
                            numeros[elmposicion - 1] = nuevonumero;

                            for (int i = 0; i < numeros.Count(); i++)
                            {
                                Console.WriteLine($"{i + 1}. {numeros[i]}");
                            }
                        }
                    }

                }
                while (a);
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error.");
            }
            Console.WriteLine("Fin///");
        }
    }
}

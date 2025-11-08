namespace NombreEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proyecto para Nombres y Edades");
            List<string> nombres = new List<string>();
            List<int> edades = new List<int>();
            Console.Write("Ingrese la cantidad de personas por inscribir: ");
            int cantidad = Revision();
            //Obtencion de datos
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nIngrese los datos de la persona {i+1}: ");
                Console.Write("Nombre: ");
                string nombre = Convert.ToString(Revision());
                Console.Write("Edad: ");
                int edad = Revision();
                Console.Write(".\n.\n.\n");
                nombres.Add(nombre);
                edades.Add(edad);
            }
            bool a = true;
            while (a)
            {
                Console.WriteLine("Nombres en su lista: ");
                for (int i = 0; i < nombres.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {nombres[i]}");
                }

                Console.WriteLine("\nIngrese el nombre de la persona que quiere saber la edad: \nENTER para salir...");
                string opcion = Console.ReadLine();
                for (int i = 0; i < nombres.Count; i++)
                {
                    if (nombres[i] == opcion)
                    {
                        Console.WriteLine($"\nLa edad de {nombres[i]} es {edades[i]}\n");
                        break;
                     
                    }
                    else if (opcion == "")
                    {
                        a = false;
                    }
                    else if (i == nombres.Count - 1)
                    {
                        Console.WriteLine("\nNo se encontro la persona indicada. Intente nuevamente\n");
                    }
                }

            }

        }
    public static int Revision()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int cantidad))
                {
                    return cantidad;
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor verifique el dato");
                }
            }
        }
    }
}

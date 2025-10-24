using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> acciones = new Stack<string>();
            int opcion;

            do
            {
                Console.WriteLine("\n--- Sistema de Control de Versiones ---");
                Console.WriteLine("1. Agregar acción");
                Console.WriteLine("2. Ver última acción");
                Console.WriteLine("3. Deshacer última acción");
                Console.WriteLine("4. Mostrar historial");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la acción (ej. 'Agregar función'): ");
                        string accion = Console.ReadLine();
                        acciones.Push(accion);
                        Console.WriteLine("Acción agregada.");
                        break;

                    case 2:
                        if (acciones.Count > 0)
                            Console.WriteLine($"Última acción: {acciones.Peek()}");
                        else
                            Console.WriteLine("No hay acciones registradas.");
                        break;

                    case 3:
                        if (acciones.Count > 0)
                            Console.WriteLine($"Deshecha la acción: {acciones.Pop()}");
                        else
                            Console.WriteLine("No hay acciones para deshacer.");
                        break;

                    case 4:
                        if(acciones.Count == 0)                        
                            Console.WriteLine("\nNo hay acciones en el historial");                   
                        else
                        {                        
                            Console.WriteLine("\nHistorial de acciones:");
                            foreach (var a in acciones)
                            Console.WriteLine($"- {a}");
                        }
                        break;
                }

            } while (opcion != 5);
        }
    }
}



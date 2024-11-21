using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class winTask
    {
        static async Task Main(string[] args)
        {
            await RealizarTarea("Tarea 1", 1000); 
            await RealizarTarea("Tarea 2", 5000); 
            await RealizarTarea("Tarea 3", 10000); 

            Console.WriteLine("Todas las tareas han finalizado.");
        }

        static async Task RealizarTarea(string nombre, int tiempo)
        {
            Console.WriteLine($"-------------------------");

            Console.WriteLine($"{nombre} comenzada.");

            Console.WriteLine($"-------------------------");


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{nombre}: Escribiendo {i}/5...");
                await Task.Delay(tiempo / 5); 
            }

            Console.WriteLine($"{nombre} completada.");
        }
    }
}

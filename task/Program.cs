using System.Threading;
using System.Threading.Tasks;
namespace task
{
    class Program
    {
        static void Main()
        {
            // () => significa vas a ejecutar el metodo ...
            Task tarea = Task.Run( () => Saludos());
            // System.Console.WriteLine(tarea);
            tarea.Wait();

            // System.Console.WriteLine(tarea.Status);

            
        }
        public static void Saludos()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine($"Hola {i}");
            }
        }

    }
}
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace task3
{
    class Program
    {
        static void Main()
        {
            //Declaramos un vector de Task<int> y lo instanciamos
            Task<int>[] tareas = new Task<int>[5];

            //Esta línea-comentario vale por instanciar c/u de los elementos del vector con tareas sin iniciar.
            // Task<int> a = new Task<int>(() => numero());
            tareas[0] = new Task<int>(() => numero());
            tareas[1] = new Task<int>(() => 50);
            tareas[2] = new Task<int>(() => 100);
            tareas[3] = new Task<int>(() => 200);
            tareas[4] = new Task<int>(() => 80);

            //y aca ejecutamos los hilos que instanciamos, usando el método estático de la clase Array
            Array.ForEach(tareas, t => t.Start());
            Task<int>.WaitAll(tareas);
            System.Console.WriteLine(tareas[0]);
            // for (int i = 0; i < 5; i++)
            // {
            //     System.Console.WriteLine(tareas);
            // }
            
            
        }
        public static int numero()
        {
            return 2323;
        }
    }
}
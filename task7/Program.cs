using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace task4
{
    class Program
    {
        static void Main()
        {
            var hp = new Impresora(3000);
            var kodak = new Impresora(5000);
            var canon = new Impresora(4000);
            var texto = "Hola mundo asincronico";

            var hpTask = Task.( () => Console.WriteLine($"hp: {hp.imprimir(texto)}")); 
            var kodakTask = Task.Run(() => Console.WriteLine($"kodak: {kodak.imprimir(texto)}"));
            var canonTask = Task.Run( () => Console.WriteLine($"canon: {canon.imprimir(texto)}"));
            Task.WaitAll(hpTask, kodakTask, canon);
            Console.ReadKey();

            static async Task Imprimir(string texto, string nombreImpresora, Impresora impresora)
            {
                var impresion = await impresora.imprimirAsync(texto);
                Console.WriteLine($"{nombreImpresora}: {impresion}");
            }

        }
    }
    public class Impresora
    {
        public int Demora { get; set; }
        public Impresora(int demora) => Demora = demora;
        public async string imprimirAsync(string texto)
        {            
            //Magia oscura que detiene el proceso cierta cantidad de milisegundos
            await Task.Delay(1000);
            return texto;
        }
    }

}
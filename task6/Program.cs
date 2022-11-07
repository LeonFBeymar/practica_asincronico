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
            var hpTask = Task.Run( () => Console.WriteLine($"hp: {hp.imprimirAsync(texto)}")); 
            var kodakTask = Task.Run(() => Console.WriteLine($"kodak: {kodak.imprimirAsync(texto)}"));
            var canonTask = Task.Run( () => Console.WriteLine($"canon: {canon.imprimirAsync(texto)}"));
            Task.WaitAll(hpTask, kodakTask, canonTask);
            Console.ReadKey();
        }
    }
    public class Impresora
    {
        public int Demora { get; set; }
        public Impresora(int demora) => Demora = demora;
        public async Task<string> imprimirAsync(string texto)
        {            
            //Magia oscura que detiene el proceso cierta cantidad de milisegundos
            System.Threading.Thread.Sleep(Demora);
            return texto;
        }
    }

}
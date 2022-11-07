using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace task4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var hp = new Impresora(3000);
            var kodak = new Impresora(5000);
            var canon = new Impresora(4000);

            var texto = "Hola mundo asincronico";

            await Task.WhenAll(Imprimir(texto, "hp", hp),
                            Imprimir(texto, "kodak", kodak),
                            Imprimir(texto, "canon", canon));
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
        public async Task<string> imprimirAsync(string texto)
        {            
            //Magia oscura que detiene el proceso cierta cantidad de milisegundos
            await Task.Delay(1000);
            return texto;
        }
    }

}
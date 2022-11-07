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
            Console.WriteLine($"hp: {hp.imprimir(texto)}");
            Console.WriteLine($"kodak: {kodak.imprimir(texto)}");
            Console.WriteLine($"canon: {canon.imprimir(texto)}");
            Console.ReadKey();
        }
    }
    public class Impresora
    {
        public int Demora { get; set; }
        public Impresora(int demora) => Demora = demora;
        public string imprimir(string texto)
        {            
            //Magia oscura que detiene el proceso cierta cantidad de milisegundos
            System.Threading.Thread.Sleep(Demora);
            return texto;
        }
    }

}
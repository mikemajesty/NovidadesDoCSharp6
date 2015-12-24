using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Aula14
{
    class Program
    {
        //public class Boleto
        //{
        //    public void Pagar(double valor)
        //    {
        //        WriteLine($"Pago valor de {valor} no boleto");
        //    }
        //}
        public delegate void PagarEvent(double valor);
        public class Pedido
        {
            //public EventHandler<EventArgs> Pagar { get; set; }
            public string Cliente { get; set; }

            //public void Fechar(double valor)
            //{
            //    Pagar(this, new EventArgs());
            //}
            public void Fechar(double valor)
            {
                Pagar(valor);
            }

            public event PagarEvent Pagar;
            //public void Fechar(double valor) => new Boleto().Pagar(valor);
        }
        static void Main(string[] args)
        {
            WriteLine("Informe um valor.");
            var valor = Convert.ToDouble(ReadLine());
            var pedido = new Pedido
            {
                Cliente = "Mike"
            };       
            pedido.Pagar += (value) =>
            {
                WriteLine("O valor é: " + value);
            };
            pedido.Fechar(valor);
            //var pedido = new Pedido()
            //{
            //    Cliente = "Mike",
            //    Pagar = (sender,e) => { WriteLine("Pago no Boleto"); }

            //};
            //pedido.Fechar(valor);
            //WriteLine("Informe um valor.");
            //var valor = Convert.ToDouble(ReadLine());
            //pedido.Pagar += (double value) => { WriteLine("O valor é: "+valor); } ;
            ReadKey();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Aula11
{
    class Program
    {
        //public class Boleto
        //{
        //    public void Pagar(double valor)
        //    {
        //        WriteLine($"Pago valor de {valor} no Boleto");
        //    }
        //}
        public delegate void PagarEvent(double valor);
        public class Pedido
        {
            //Boleto boleto = new Boleto();
            public event PagarEvent Pagar;
            public void Fechar(double Valor)
            {
                //Delegação
                //boleto.Pagar(Valor);
                Pagar?.Invoke(Valor);
            }

        }
        static void Main(string[] args)
        {
            WriteLine("Informe o valor do peidido");
            var valor = Convert.ToDouble(ReadLine());
            var pedido = new Pedido();



            pedido.Pagar += (double value) =>
            {
                WriteLine($"Pago valor de {value} no Boleto");
            };
            //pedido.Pagar += Pedido_Pagar;
            pedido.Fechar(valor);
            ReadKey();
        }

        //private static void Pedido_Pagar(double valor)
        //{
        //    WriteLine($"Pago valor de {valor} no Boleto");
        //}
    }


}

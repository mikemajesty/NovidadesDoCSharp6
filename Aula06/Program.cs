using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Aula06
{
    //public delegate void PagarEvent(double valor);
    //public class Pedido
    //{
    //    public event PagarEvent Pagar;
    //    public void FecharPedido(double valor)
    //    {
    //        Pagar(valor);
    //    }
    //}
    public class Calculadora
    {
        public static string Nome => "Minha Calculadora";
        public static int Somar(int x, int y) => x + y;
        public static int Multiplicar(int x, int y) => x * y;
        //{
        //    return x + y;
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            //    var pedido = new Pedido();
            //    pedido.Pagar += valor => WriteLine($"Pago valor de {valor}") ;
            //    pedido.FecharPedido(2000);
            //    ReadKey();
            int x = 10, y = 1;
            var r1 = Calculadora.Somar(x, y);
            WriteLine($"Soma usando a calculadora {Calculadora.Nome} :{r1}");
            x = 10;
            y = 10;
            var r2 = Calculadora.Somar(x, y);
            WriteLine($"Usando {Calculadora.Nome}, a multiplicação :{x} e {y} = {r2}");
            ReadKey();
        }

        //private static void Pedido_Pagar(double valor)
        //{
        //    WriteLine($"Pago valor de {valor}");
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Aula13
{
    class Program
    {
        public class Conta
        {
            private double _saldo;

            //C#5
            //public double Saldo { get; private set; } = 1000;
            //Agora no c# 6
            public double Saldo { get { return _saldo; } }
                public string Cliente { get; set; }
            public void Sacar(double valor)
            {
                _saldo -= valor;

            }
            //public double GetSaldo()
            //{
            //    return Saldo;
            //}
            public void Depositar(double valor)
            {
                _saldo += valor;
            }
        
        }
        static void Main(string[] args)
        {
            var saldo = new Conta
            {                
                 Cliente = "Mike"
            };
            WriteLine($"Prezado {saldo.Cliente} seu saldo é {saldo.Saldo}");
            ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Aula12
{
    class Program
    {
        public class Conta
        {
            private double _saldo;
            private const double LIMITE = 500;
            public double GetSaldo() => _saldo;

            public void Desositar(double valor)
            {
                _saldo += valor;
            }
            public void Sacar(double valor)
            {
                if (valor > _saldo + LIMITE)
                    throw new ESaldoInsuficienteExecpion("Saldo Insuficiente") ;              
                    _saldo -= valor;
              
            }
        }
        static void Main(string[] args)
        {


            WriteLine("Informe o valor a Depositar");
            var v1 = Convert.ToDouble(ReadLine());
            WriteLine("Informe o valor a Sacar");
            var v2 = Convert.ToDouble(ReadLine());
            var conta = new Conta();
            conta.Desositar(v1);
            conta.Sacar(v2);
           
            WriteLine($"Sua conta em saldo de {conta.GetSaldo()}");
            ReadKey();
        }


    }
}

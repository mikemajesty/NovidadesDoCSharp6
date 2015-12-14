using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.DateTime;
namespace Aula02
{
    class Program
    {

        static void Main(string[] args)
        {
            var pessoa = new Pessoa { Nome = "Mike ", Matricula = 20, SobreNome = "Lima" };
            WriteLine("Bem vindo " + pessoa.Nome + " " + pessoa.SobreNome + " (" + pessoa.Matricula + ")"
                + " este é p c# 1");
            WriteLine(string.Format("Bem vindo {0} {1}({2}) este é p c# 2",pessoa.Nome,pessoa.SobreNome,pessoa.Matricula));
            WriteLine($"Bem vindo {pessoa.Nome} {pessoa.SobreNome}({pessoa.Matricula,10}) este é p c# 6");
            WriteLine($"Olá, agora são {Now.ToLongDateString()}, esta tarde!");
            ReadLine();
        }
    }
    public class Pessoa
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Matricula { get; set; }

    }

}

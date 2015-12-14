using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Aula03
{
    public class Aluno
    {

        public int Matricula { get; set; } = 333;
        public string Nome { get; set; } = "Limão";


    }
    class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Aluno();
            WriteLine($"Nome: {aluno.Nome} Matricula: {aluno.Matricula}");
            ReadKey();
        }
    }
}

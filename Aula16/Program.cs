using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
namespace Aula15
{
    class Program
    {
        public class ALuno
        {
            public int Matricula { get; set; }
            public string Nome { get; set; }
            public double Mensalidade { get; set; }
        }
        public static class Repositorio
        {
            public static List<ALuno> getAlunos()
            {
                return new List<ALuno>
                {
                    new ALuno { Matricula=100, Mensalidade=1000, Nome="Mike" },
                    new ALuno { Nome = "Sergio", Mensalidade=800, Matricula=500 }
                };
            }
        }
        static void Main(string[] args)
        {

            var alunos = Repositorio.getAlunos();
            WriteLine("Digite uma numero de matricula");
            var matricula = ReadLine();
            var aluno = alunos.FirstOrDefault(c=>c.Matricula == ToInt32(matricula));
            WriteLine($"O aluno {aluno.Matricula} tem o nome {aluno.Nome} paga uma mensalidade {aluno.Mensalidade} R$");
            ReadKey();
        }
    }
}

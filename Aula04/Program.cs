using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Aula04
{
    public class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Sem nome";
        public Curso Curso { get; set; }
    }

    public class Curso
    {
        public int Codigo { get; set; } = 0;
        public string Nome { get; set; } = "Não definido";
        public Area Area { get; set; }
    }

    public class Area
    {
        public string Nome { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Aluno
            {
                Matricula = 123,
                Nome = "Mike",
                Curso = new Curso
                {
                    Nome = "Sistemas de Informação",
                    Codigo = 100,
                    Area = new Area
                    {
                        Nome = "TI"
                    }
                }
            };
            WriteLine($"\nMatricula: {aluno.Matricula} \nNome: {aluno.Nome}");
            WriteLine($"\nCurso: {aluno?.Curso?.Nome ?? "Sem Curso"} \nNome: {aluno.Nome}");
            WriteLine($"\nArea: {aluno?.Curso?.Area?.Nome ?? "Sem Area"} \nNome: {aluno.Nome}");

            ReadKey();
        }
    }
}

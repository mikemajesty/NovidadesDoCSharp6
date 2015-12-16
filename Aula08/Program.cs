using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Aula08
{
    class Program
    {
        public class Aluno
        {
            public string Sobrenome { get; set; }
            public string Nome { get; set; }
            //public Aluno(string nome)
            //{
            //    this.Nome = nome;
            //}
        }
        static void Main(string[] args)
        {
            var alunos = new Dictionary<int, Aluno>()
            {
                [1] = new Aluno { Nome = "Mike", Sobrenome = "Lima" },
                [2] = new Aluno { Sobrenome = "Rogers", Nome = "Alan" },
                [3] = new Aluno { Sobrenome = "Zedeck", Nome = "Melki" }
            };
            //var a1 = new Aluno { Nome = "Mike", Sobrenome = "Lima" };
            //var a2 = new Aluno { Sobrenome = "Rogers", Nome = "Alan" };
            //var a3 = new Aluno { Sobrenome = "Zedeck", Nome = "Melki" };
            //var alunos = new Dictionary<int, Aluno>()
            //{
            //    { 1,a1 },
            //    { 2,a2 },
            //    { 3,a3 }

            //};
            WriteLine($"O {nameof(Aluno)}: com o nome {alunos[1].Nome} e o sobrenome {alunos[1].Sobrenome} existe");
            WriteLine($"O {nameof(Aluno)}: com o nome {alunos[2].Nome} e o sobrenome {alunos[2].Sobrenome} existe");
            WriteLine($"O {nameof(Aluno)}: com o nome {alunos[3].Nome} e o sobrenome {alunos[3].Sobrenome} existe");
            //var alunos = new Dictionary<int, Aluno>();
            //alunos.Add(1, new Aluno { Nome = "Mike", Sobrenome = "Lima" });
            //alunos.Add(2,new Aluno { Sobrenome = "Rogers", Nome = "Alan" });
            //var alunos = new List<Aluno>
            //{
            //    new Aluno { Sobrenome="Lima", Nome="Mike" },
            //     new Aluno { Sobrenome="Rogers", Nome="Alan" }
            //};
            //var aluno = new Aluno
            //{
            //    Nome = "Mike",
            //    Sobrenome = "Lima"
            //};
            ReadKey();
        }
    }
}

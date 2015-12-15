using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Aula05
{
    class Program
    {
        public class Professor
        {
            public string Matricula { get; set; } = "0";
            public string Nome { get; set; } = "Sem Nome";
            public DateTime Data { get; set; } = DateTime.Now;
            public override string ToString()
            {
                return $"Matricula:{Matricula}, Nome:{Nome}, Data: {Data}";
            }
            
        }
        public static class Relatorio{
            public static void Imprimir(Professor prof)
            {
                WriteLine("Relatotio\n"+prof?.ToString() ?? $" O Parametro do nome { nameof(prof)} não pode ser nulo");
            }
        }
        static void Main(string[] args)
        {
            Professor prof = null;
            Relatorio.Imprimir(prof);
            WriteLine(prof?.ToString() ?? $"Objeto {nameof(prof)} não Instanciado");
            prof = new Professor
            {
                Nome = "Mike Lima",
                Matricula = "100"
            };
            WriteLine(prof?.ToString() ?? $"Objeto {nameof(prof)} não Instanciado");
            Relatorio.Imprimir(prof);
            ReadKey();
        }
    }
}

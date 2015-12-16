using static System.Console;

namespace Aula10
{
    class Program
    {
        static void Mostrar(string obj)
        {
            WriteLine($"Mostrar(String: {obj})");
        }
        static void Mostrar(int obj)
        {
            WriteLine($"Mostrar(Int: {obj})");
        }
        static void Mostrar(bool obj)
        {
            WriteLine($"Mostrar(Bool: {obj})");
        }
        static void Mostrar(object obj)
        {
            WriteLine($"Mostrar(Object: {obj})");
        }
        static void Mostrar(Aluno obj)
        {
            WriteLine($"Mostrar(Aluno: {obj})");
        }
        static void Mostrar(AlunoEspecial obj)
        {
            WriteLine($"Mostrar(AlunoEspecial: {obj})");
        }
        static void Main(string[] args)
        {
            Mostrar("Olá Mundo");
            Mostrar(666);
            Mostrar(true);
            Mostrar(new Aluno());
            Mostrar(new AlunoEspecial { Nome="Alan", Situacao = "Especial", Matricula=69 });
            ReadKey();
        }
    }
    public class Aluno
    {
        public string Nome { get; set; } = "Sem Nome";
        public int Matricula { get; set; } = 0;

        public override string ToString() 
                        => $"Nome: {Nome} e matricula: {Matricula}";

    }
    public class AlunoEspecial : Aluno
    {
        public string Situacao { get; set; } = "Especial";
        public override string ToString()
                      => $"Nome: {Nome} e matricula: {Matricula} e situação: {Situacao}";
    }
}

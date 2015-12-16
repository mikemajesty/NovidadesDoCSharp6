using System;
using static System.Console;
namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 999999999;
            int y = 999999999;
            try
            {
                int r1 = x / y;
                int r2 = checked(x * y * x);
                WriteLine($"{x} dividido por {y} e igual a {r1}");
                WriteLine($"{x} multiplicado por {y} e igual a {r2}");
            }               
            catch (Exception erro) when (erro.Message.ToLower().Contains("divide"))
            {
                WriteLine($"Error:{erro.Message}");
            }
            catch (Exception erro) when (erro.Message.ToLower().Contains("overflow"))
            {
                WriteLine($"Error:{erro.Message}");
            }
            ReadKey();

        }

    }
}

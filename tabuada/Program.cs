using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tabuada {
class Tabuada
{
    static void Main(string[] args)
    {
        int num;

            Console.Write("Digite vosso número entre 1 a 10: ");
            num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 10)
            {
                Console.WriteLine("Número invalido, insira um número de 1 a 10");
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    {
                        Console.WriteLine($" {num} x {i} = {num * i}");
                    }
                }
            }

    }
}
}

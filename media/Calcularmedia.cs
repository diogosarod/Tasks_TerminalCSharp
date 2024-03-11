namespace CalcularMedia
{
    public class CalcularMedia
    {
        static void Main(string[] args)
        {

            double num1;
            double num2;
            double media;
            string msg;

            Console.WriteLine("Digite vossa nota na primeira avaliação:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite vossa nota na segunda avaliação:");
            num2 = double.Parse(Console.ReadLine());

            media = (num1 + num2) / 2;

            if (media >= 6)
            {
                msg = "Aprovado!";
            }
            else
            {
                msg = $"Reprovado!";
            }

            Console.WriteLine($"Você foi {msg} Com a média de {media:F2}.");
        }
    }
}

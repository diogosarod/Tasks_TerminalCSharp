namespace positiveOrNegative
{
    public class positiveOrNegative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número para saber se ele é positivo ou negativo:");
            num = int.Parse(Console.ReadLine());

            if (num < 0 ) {
                Console.WriteLine($"O número {num} é um valor negativo");
            }
            else
            {
                Console.WriteLine($"O número {num} é um valor positivo");
            }
        }
    }
}
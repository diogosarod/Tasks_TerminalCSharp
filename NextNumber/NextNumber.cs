namespace NextNumber
{
    public class NextNumber
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite vosso número para a sequência de 10 itens:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) { 
                Console.WriteLine(n + i);
            }
        }
    }
}
namespace Apple
{
    public class Apple
    {
        static void Main(string[] args)
        {
            int maca;
            double preco;

            Console.Write("Quantas maças você comprou? ");
            maca = int.Parse(Console.ReadLine());

            if (maca >= 12) {
                preco = 1;
            }
            else
            {
                preco = 1.3;
            }

            double custo = maca * preco;

            Console.WriteLine($"O custo total da compra é de {custo:F2}");

        }
    }
}
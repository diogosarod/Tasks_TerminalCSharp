namespace PairNumber
{
    public class PairNumber
    {
        public static void Main(string[] args)
        {
            int num;
            int pairCount = 0;
            int position;
            int numPar;

            Console.WriteLine("Digite algum número maior que 50:");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    pairCount++;
                }
            }

            Console.Write($"Digite a posição do número par que você deseja imprimir (entre 1 e {pairCount}): ");
            position = int.Parse(Console.ReadLine());

            if (position >= 1 && position <= pairCount)
            {
                numPar = (position * 2) - 2;

                Console.WriteLine($"A quantidade de números pares entre 1 e {num} é: {pairCount}");

                Console.WriteLine($"O número par na posição {position}° é: {numPar}");
            }
        }
    }
}
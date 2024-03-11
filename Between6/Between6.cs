namespace Between6
{
    public class Between6
    {
        static void Main(string[] args)
        {
            int num;
            int count = 0;
            bool next = true;

            do
            {
                Console.WriteLine("Digite algum número entre 10 e 20: ");
                num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 20)
                {
                    count++;

                    Console.WriteLine("Número válido!");

                    if (count == 6)
                    {
                        next = false;
                    }
                }
                else
                {
                    Console.WriteLine("número inválido! Digite algum número entre 10 e 20.");
                }
            }
            while (next);

            Console.WriteLine("Você digitou os 6 números esperados.");
        }
    }
}
namespace ascendingList
{
    public class ascendingList
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int menorNum;
            int maiorNum;

            Console.WriteLine("Digite vossoo primeiro valor:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite vosso segundo valor:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                menorNum = num1;
                maiorNum = num2;
            }
            else
            {
                menorNum = num2;
                maiorNum = num1;
            }

            Console.WriteLine($"A ordem crescente dos valores é: {menorNum}, {maiorNum}");

        }
    }
}
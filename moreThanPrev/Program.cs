namespace moreThanPrev
{
    public class moreThanPrev
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int maiorNum;

            Console.Write("Digite vosso primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite vosso segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                maiorNum = num1;
            }
            else
            {
                maiorNum = num2;
            }

            Console.WriteLine($"O maior número é: {maiorNum}. Dentre os números {num1} e {num2}");


        }
    }
}
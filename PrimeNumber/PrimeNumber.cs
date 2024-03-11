namespace PrimeNumber
{   
    public class PrimeNumber
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Verifique se um número é prime ou não:");
            num = int.Parse(Console.ReadLine());

            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                Console.WriteLine($"{num} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{num} não é um número primo.");
            }
        } 
    } 
}
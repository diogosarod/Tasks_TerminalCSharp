namespace LessThan0
{
    public class LessThan0
    {
        static void Main(string[] args)
        {
            double num;
            int count = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Digite {i}° número: ");
                num = double.Parse(Console.ReadLine());

                if (num < 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Tem {count} números menores que 0");
        }
    }
}
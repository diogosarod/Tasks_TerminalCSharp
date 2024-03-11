namespace area
{
    class area
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Digite a base do rentângulo(em cm):");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do rentângulo(em cm):");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"A area do retângulo é {a * b} centimetros");
        }
    }
}
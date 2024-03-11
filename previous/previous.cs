namespace antecessor
{
    class Tabuada
    {
        static void Main(string[] args)
        {

            int num;

            Console.Write("Digite vosso número: ");
            num = int.Parse(Console.ReadLine());

            int antecessor = num - 1;

            Console.WriteLine($"O número antecessor do que foi posto é {antecessor}");
        }
    }
}
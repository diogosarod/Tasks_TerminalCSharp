namespace maiorque10
{
    public class maiorque10 {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número para saber se ele é maior que 10:"); ;
            num = int.Parse(Console.ReadLine());
            if (num == 10 ) {
                Console.WriteLine("Esse número é igual a 10");
            }
            else if (num > 10 ) { 
                Console.WriteLine($"{num} é maior que 10");
            }
            else {
                Console.WriteLine($"{num} é menor que 10");
            }
        }
    }
}
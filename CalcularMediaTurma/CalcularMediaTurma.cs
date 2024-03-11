namespace Calcularmedia
{
    public class Calcularmedia
    {
        public void Main(string[] args)
        {
            int numStudents;
            float sumGrade = 0;
            float media;

            Console.WriteLine("Digite a quantidade de alunos da turma escolhida:");
            numStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Digite a nota do aluno {i + 1}°:");
                sumGrade += float.Parse(Console.ReadLine());
            }

            media = sumGrade / numStudents;

            Console.WriteLine($"A média da turma escolhida é: {media:F2}");
        }
    }
    }
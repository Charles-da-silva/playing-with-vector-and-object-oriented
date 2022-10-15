using Projeto;

internal class Program
{
    private static void Main(string[] args)
    {
        Quartos[] Quarto = new Quartos[10];

        Console.Write("Quantos alunos irão alugar quartos? ");
        int numeroEstudantes = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < numeroEstudantes; i++)
        {
            Console.Write("Informe o nome do " + (i + 1) + "º aluno: ");
            string nomeEstudante = Console.ReadLine();

            Console.Write("Informe o email do mesmo: ");
            string emailEstudante = Console.ReadLine();

            Console.Write("Informe qual o número (0-9) do quarto que você deseja alugar: ");
            int quartoDesejado = int.Parse(Console.ReadLine());

            while (quartoDesejado > 9)
            {
                Console.Write("Quarto indisponível. Favor informe um número de 0 a 9: ");
                quartoDesejado = int.Parse(Console.ReadLine());
            }

            while (Quarto[quartoDesejado] != null) 
            {
                Console.Write("Quarto já ocupado. Favor informe outro número (0-9): ");
                quartoDesejado = int.Parse(Console.ReadLine());
            }

            Quarto[quartoDesejado] = new Quartos (nomeEstudante, emailEstudante);
            Console.WriteLine();
        }

        Console.WriteLine("Relatório de quartos alugados:");
        Console.WriteLine("----------------------------------------");

        for (int i = 0; i < Quarto.Length; i++)
        {
            if (Quarto[i] != null)
            {
                Console.WriteLine($"Quarto nº {i}: {Quarto[i].NomeLocatario}, {Quarto[i].Email}");
            }
        }

        Console.WriteLine("----------------------------------------");


    }
}
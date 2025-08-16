using System;

class ex003
{
    static double menorVet(double[] vet)
    {
        double menor = 0;
        for (int i = 0; i < vet.Length; i++)
        {
            if (i == 0)
            {
                menor = vet[i];
            }
            else
            {
                if (vet[i] < menor)
                {
                    menor = vet[i];
                }
            }
        }
        return menor;
    }

    static void Main()
    {
        int n;
        double menor;

        Console.WriteLine("Digite a quantidade de elementos do vetor:");
        n = int.Parse(Console.ReadLine());

        double[] vetMenor = new double[n];

        for (int i = 0; i < vetMenor.Length; i++)
        {
            Console.Write($"Digite o elemento #{i}: ");
            vetMenor[i] = double.Parse(Console.ReadLine());
        }

        menor = menorVet(vetMenor);

        Console.WriteLine("");
        Console.WriteLine($"O menor elemento do vetor é: {menor:F2}");
    }
}
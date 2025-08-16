using System;

class ex001
{
    static void lerVetor(int[] vet)
    {
        Console.WriteLine("Digite os elementos do vetor:");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write($"Elemento #{i}: ");
            vet[i] = int.Parse(Console.ReadLine());
        }
    }
    static int somaVet(int[] vet)
    {
        int soma = 0;
        for (int i = 0; i < vet.Length; i++)
        {
            soma += vet[i];
        }
        return soma;
    }

    static void Main()
    {
        int n, resultado;
        Console.WriteLine("Digite a quantidade de elementos do vetor: ");
        n = int.Parse(Console.ReadLine()); //pergunta ao usuário o tamanho do vetor

        int[] vet = new int[n];
        lerVetor(vet); //usa a função lerVet para preencher o vetor

        resultado = somaVet(vet); //usa a função somaVet para percorrer e somar os elementos do vetor

        Console.WriteLine($"A soma dos elementos do vetor é: {resultado}"); // printa o resultado
    }
}
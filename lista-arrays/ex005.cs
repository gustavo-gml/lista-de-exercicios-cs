using System;

class ex005
{
    /*Escreva um programa que leia ou gere um vetor de N elementos inteiros (N deve ser informado pelo 
usuário) e passe o mesmo como parâmetro para uma função que retorne a soma de seus elementos. */

    //função que pega um vetor e retorna a soma
    static int somaVetor(int[] vet)
    {
        int soma = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            soma = soma + vet[i];
        }
        return soma;
    }

    //função principal: cria um vetor
    static void Main()
    {
        int n, soma;

        Console.WriteLine("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());

        int[] vvetor = new int[n];

        for (int i = 0; i < vvetor.Length; i++)
        {
            Console.Write("Digite o elemento " + i + "do vetor");
            vvetor[i] = int.Parse(Console.ReadLine());
        }

        soma = somaVetor(vvetor);

        Console.WriteLine($"O resultado da soma dos elementos do vetor é: {soma}");
    }

}
﻿int[] vetA = new int[5];
int[] vetB = new int[5];

int[] vetC = new int[5];

for (int i = 0; i < vetA.Length; i++)
{
    Console.WriteLine("Informa um valor para o vetor A: ");
    vetA[i] = int.Parse(Console.ReadLine());

    Console.WriteLine("Informa um valor para o vetor B: ");
    vetB[i] = int.Parse(Console.ReadLine());

}

for (int i = 0;i < vetC.Length;i++)
{
    vetC[i] = vetA[i] - vetB[i];
}

foreach (int n in vetC)
{
    Console.Write(n + " ");
}

Console.ReadLine();
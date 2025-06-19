// Quinta atividade - Jogo do Primeiro Caractere
// Objetivo: Ler uma palavra e exibir o primeiro caractere dela.

Console.Write("Escreva uma palavra:");
string palavra = Console.ReadLine();

char letra = palavra[0];

Console.WriteLine($"A primeira letra da palavra {palavra} é {letra}");

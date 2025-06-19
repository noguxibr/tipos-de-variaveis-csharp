// Terceira Atividade - Verificação de Número Par ou Ímpar
// Objetivo: Verificar se um número inteiro é par ou ímpar.

Console.Write("Escolha um número:");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero}, é par");
}
else
{
    Console.WriteLine($"O número {numero}, é ímpar");
}
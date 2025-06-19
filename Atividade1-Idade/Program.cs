// Primeira Atividade - Calculadora de Idade
// Objetivo: Ler o nome do usuário e o ano de nascimento. Calcular e exibir a idade atual.

Console.Write("Escreva seu nome:");
string name = Console.ReadLine();

Console.Write("Digite em que ano você nasceu:");
int anoNascimento = int.Parse(Console.ReadLine());

int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;

Console.WriteLine($"Olá, {name}! Você tem {idade} anos.");
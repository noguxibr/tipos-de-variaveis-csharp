// Segunda Atividade - Conversor de Temperatura
// Objetivo: Converter uma temperatura em Celsius para Fahrenheit.

Console.Write("Determine a temperatura em Celsius:");
float C = float.Parse(Console.ReadLine());

double formula = C * 1.8 + 32;

Console.WriteLine($"A sua temperatura em Fahrenheit é: {formula}°F");
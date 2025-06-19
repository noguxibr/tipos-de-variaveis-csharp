// Quarta Atividade - Verificador de Acesso
// Objetivo: Receber o nome de usuário e se ele está autentidicado (bool). Exibir uma mensagem apropriada.

Console.Write("Digite seu usuário: ");
string usuarioDigitado = Console.ReadLine();

string[] users = new string[] { "Lucas", "Rebeca", "Betuel", "Lúcia", "Mari" };
bool status = false;

foreach (string nome in users)
{
    if (usuarioDigitado == nome)
    {
        status = true;
        break;
    }
}

if (status)
{
    Console.WriteLine("Acesso autorizado.");
}
else
{
    Console.WriteLine("Acesso negado.");
}

Console.WriteLine($"Status: {status}");
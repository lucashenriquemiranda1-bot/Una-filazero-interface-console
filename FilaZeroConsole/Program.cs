using System.Drawing;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Title = " Fila Zero - Sistema de Login ";

Console.ReadLine();
DesenharTela();
ExecutarLogin();
static void DesenharTela()
{

    Console.Clear();
    Console.WriteLine("=====================================");
    Console.WriteLine("         Fila Zero - Login           ");
    Console.WriteLine("=====================================");
}

static void ExecutarLogin()
{
    
    Console.Write("Digite seu nome de usuário: ");
    string username = Console.ReadLine();

    Console.Write("Digite sua senha: ");
    string password = Console.ReadLine();

    // Simulação de validação de login
    if (username == "admin" && password == "senha123")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nLogin bem-sucedido! Bem-vindo, admin.");
        
    }
    else
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nLogin falhou! Nome de usuário ou senha incorretos.");
        
    }
    Console.ResetColor();
} 

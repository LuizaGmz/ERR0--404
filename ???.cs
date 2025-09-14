using System;
using System.Threading;

class FestaDeAniversario
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine(" (^-^) BEM-VINDO(A) (^-^) ");
        Console.WriteLine("===================================\n");

        Console.Write("Digite seu nome para começar: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"\n Olá {nome}! Preparando o presente...\n");
        Thread.Sleep(1200);

        MostrarMenu(nome);
    }

    static void MostrarMenu(string nome)
    {
        Console.WriteLine("Escolha seu presente  (apenas UMA opção):");
        Console.WriteLine("1 - Receber uma mensagem especial ");
        Console.WriteLine("2 - Um presente lógico");
        Console.WriteLine("3 - ERRO -404 ");

        Console.Write("Digite o número da opção: ");
        
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                MensagemEspecial(nome);
                break;
            case "2":
                PresenteSurpresa();
                break;
            case "3":
                TocarParabens();
                break;
            default:
                Console.WriteLine("\n Opção inválida! Mas você ainda ganha carinho e bolo! ");
                break;
        }

        EncerrarFesta(nome);
    }

    static void MensagemEspecial(string nome)
    {
        Console.WriteLine($"\n Mensagem para você, {nome}:");
        Console.WriteLine("Hehe feliz aniversaio! ");
        Console.WriteLine("Continue brilhando como a estrela que você é \n");
    }

    static void PresenteSurpresa()
    {
        string[] presentes = {
            " Um bolo gigante de chocolate!",
            "Uma picanha suculenta só pra você!",
            " 3 gatinhos fofinhos só pra você!",
            "uma viagem para coreia"
           
        };

        Random rnd = new Random();
        string presente = presentes[rnd.Next(presentes.Length)];

        Console.WriteLine($"\n Você abriu o presente e encontrou: {presente}\n");
    }

    static void TocarParabens()
    {
        Console.Write("\n Tocando: 'Parabéns pra você'");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine(" \n");
    }

    static void EncerrarFesta(string nome)
    {
        Console.WriteLine("===================================");
        Console.WriteLine($" Obrigado por participar, {nome}! ");
        Console.WriteLine("Que seu novo ano seja épico, bug-free e cheio de alegria! ");
        Console.WriteLine("===================================\n");

        string confete = "*******";
        for (int i = 0; i < 60; i++)
        {
            Console.Write(confete[i % confete.Length]);
            Thread.Sleep(50);
        }
        Console.WriteLine("\n\n Festa encerrada com sucesso!");
    }
}

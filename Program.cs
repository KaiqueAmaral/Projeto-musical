//Screen Sound

using System.Runtime.ExceptionServices;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> bandas = new List<string>();


void ExibirLogo()
{

    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostra todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;

        case 2:
            MostrarBandasRegistradas();
            break;

        case 3:
            break;

        case 4:
            break;

        case -1:
            break;

        default:
            break;
    }
}


void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("***********************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("***********************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    bandas.Add(nomeDaBanda);

    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}


void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("Exibindo bandas registradas");
    Console.WriteLine("********************************\n");


    foreach(string banda in bandas)
    {
        Console.WriteLine(banda);
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();

    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
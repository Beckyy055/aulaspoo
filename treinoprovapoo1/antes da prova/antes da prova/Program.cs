using treinoprovapoo1;
using System;
    Estoque estoque = new Estoque();

while (true)
{
    Console.WriteLine("\n=== MEU CONTROLE DE ESTOQUE ===");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Adicionar produto ao estoque");
    Console.WriteLine("3 - Vender produto");
    Console.WriteLine("4 - Ver status do estoque");
    Console.WriteLine("5 - Ver dinheiro em caixa");
    Console.WriteLine("6 - Sair");
    Console.WriteLine("================================");

    Console.Write("Escolha uma opção: ");
    string input = Console.ReadLine();

    // Tenta converter a entrada do usuário para um número
    if (!int.TryParse(input, out int opcao))
    {
        Console.WriteLine("\nOpção inválida. Digite um número de 1 a 6.");
        continue; // Volta para o início do loop
    }

    // O switch chama o método correto baseado na escolha do usuário
    switch (opcao)
    {
        case 1:
            estoque.Cadastrar();
            break;
        case 2:
            estoque.Adicionar();
            break;
        case 3:
            estoque.Vender();
            break;
        case 4:
            estoque.Status();
            break;
        case 5:
            estoque.VerDinheiro(); // Chamando o método que mostra o caixa
            break;
        case 6:
            Console.WriteLine("\nSaindo do programa. Até mais!");
            return; // Sai do método Main e encerra o programa
        default:
            Console.WriteLine("\nOpção não encontrada. Tente novamente.");
            break;
    }
}

    


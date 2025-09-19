using provapootreino2;

//Exercicio1
//Funcionario funcionario = new Funcionario();

//Console.WriteLine("Bem vindo ao cadastro de funcionário!");
//Console.WriteLine("Por favor, digite o nome do novo funcionário: ");

//funcionario.Nome = Console.ReadLine();

//Console.WriteLine("Agora, digite o salário do funcionário seguindo o modelo XXXX,XX: ");

//funcionario.Salario = decimal.Parse(Console.ReadLine());

//Console.WriteLine($"Certinho! O/A funcionário/a {funcionario.Nome} está cadastrado e ganha R${funcionario.Salario}");

//Exercicio2

//List<Forma> formas = new List<Forma>();
//Circulo circulo = new Circulo();
//Retangulo retangulo = new Retangulo();

//retangulo.Altura = 10;
//retangulo.Largura = 20;
//circulo.Raio = 3;

//formas.Add(circulo);
//formas.Add(retangulo);

//foreach (Forma forma in formas)
//{
//    forma.CalcularArea();
//}


//Exercicio 3

List<IPagavel> pagaveis = new List<IPagavel>();

Carro carro = new("abcderf", "vermelho");
Caminhao caminhao = new("wndiqnsi", "azul");
Caixa gerenciador = new Caixa();

pagaveis.Add(carro);
pagaveis.Add(caminhao);


foreach (IPagavel p in pagaveis)
{
    p.PagarPedagio();

    // Processa os pagamentos
    gerenciador.ProcessarPagamento(carro);
    gerenciador.ProcessarPagamento(caminhao);

    // Exibe o total
    gerenciador.ExibirTotalArrecadado();
}


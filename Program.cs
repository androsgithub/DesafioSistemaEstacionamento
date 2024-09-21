using DesafioSistemaEstacionamento.Models;

Estacionamento estacionamento = new();





int opcao = -1;
while (opcao != 0)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Remover Veiculo");
    Console.WriteLine("3 - Listar Veiculos");
    Console.WriteLine("0 - Sair");
    int.TryParse(Console.ReadLine(), out opcao);
    switch (opcao)
    {
        case 1:
            estacionamento.CadastrarVeiculo();
            break;
        case 2:
            estacionamento.RemoverVeiculo();
            break;
        case 3:
            estacionamento.ListarVeiculos();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opcao invalida!");
            break;
    }

}

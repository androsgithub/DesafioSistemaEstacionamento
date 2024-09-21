using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSistemaEstacionamento.Models
{
    public class Estacionamento
    {
        List<Veiculo> VeiculosCadastrados = [];
        public double PrecoInicial { get; set; } = 0;
        public double PrecoHora { get; set; } = 0;

        public Estacionamento()
        {
            Console.WriteLine("Digite o preco inicial: ");
            double.TryParse(Console.ReadLine(), out double precoInicial);
            PrecoInicial = precoInicial;


            Console.WriteLine("Digite o preco por hora: ");
            double.TryParse(Console.ReadLine(), out double precoHora);
            PrecoHora = precoHora;

            Console.WriteLine($"Preco Inicial:{PrecoInicial}");
            Console.WriteLine($"Preco P/Hora:{PrecoHora}");
        }

        public void CadastrarVeiculo()
        {
            string? placa = null;
            while (placa == null)
            {
                Console.WriteLine("Digite a placa: ");
                placa = Console.ReadLine();
            }
            Veiculo novoVeiculo = new(placa);
            VeiculosCadastrados.Add(novoVeiculo);
        }
        public void RemoverVeiculo()
        {
            string? placa = null;
            while (placa == null)
            {
                Console.WriteLine("Digite a placa para remover: ");
                placa = Console.ReadLine();
            }
            Veiculo veiculo = new(placa);
            VeiculosCadastrados.Remove(veiculo);

            Console.WriteLine("Horas que o veiculo permaneceu estacionado: ");
            int.TryParse(Console.ReadLine(), out int horasEstacionado);

            double total = (horasEstacionado * PrecoHora) + PrecoInicial;

            Console.WriteLine($"O veiculo ${placa} foi removido, o total foi de: R${total}");
        }
        public void ListarVeiculos()
        {

            Console.WriteLine($"--- Veiculos Cadastrados ---");
            foreach (Veiculo veiculo in VeiculosCadastrados)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}");
            }
            Console.WriteLine($"----------------------------");
        }
    }
}
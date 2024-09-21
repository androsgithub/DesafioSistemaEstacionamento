using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSistemaEstacionamento.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public Veiculo(string placa)
        {
            Placa = placa;
        }
    }
}
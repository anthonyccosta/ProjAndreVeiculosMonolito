using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Venda
    {
        public readonly static string INSERT = " INSERT INTO Venda (PlacaVeiculo, DataVenda, ValorVenda, IdCliente, IdFuncionario, IdPagamento) " +
        "VALUES (@PlacaVeiculo, @DataVenda, @ValorVenda, @IdCliente, @IdFuncionario, @IdPagamento); SELECT SCOPE_IDENTITY(); ";

        public int Id { get; set; }
        public Carro Carro { get; set; }
        public DateTime DataVenda { get; set; }
        public Decimal ValorVenda { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Pagamento Pagamento { get; set; }

    }
}

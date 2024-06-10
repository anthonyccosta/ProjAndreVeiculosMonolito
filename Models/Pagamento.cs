using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pagamento
    {
        public readonly static string INSERT = " INSERT INTO PAGAMENTO (IdCartao, IdBoleto, IdPix, DataPagamento) VALUES (@IdCartao, @IdBoleto, @IdPix, @DataPagamento); SELECT SCOPE_IDENTITY(); ";

        public int Id { get; set; }
        public Cartao Cartao { get; set; }
        public Boleto Boleto { get; set; }
        public Pix Pix { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}

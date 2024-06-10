using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionario : Pessoa
    {

        public Cargo Cargo { get; set; }
        [Required] 
        public decimal ValorComissao { get; set; }
        public decimal Comissao { get; set; }
        public static readonly string INSERT_SQL = " INSERT INTO Funcionario (Documento, CargoId, ValorComissao, Comissao, Nome, DataNascimento, EnderecoId, Telefone, Email) VALUES (@Documento, @CargoId, @ValorComissao, @Comissao, @Nome, @DataNascimento, @EnderecoId, @Telefone, @Email); SELECT SCOPE_IDENTITY(); ";
    }
}

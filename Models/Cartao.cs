using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cartao
    {
        [Key]
        public string NumeroCartao { get; set; }

        [MaxLength(3)] // limite de 3 digitos
        public string CodigoSeguranca { get; set; }

        [DataType(DataType.Date)] 
        public string DataValidade { get; set; }

        public string NomeCartao { get; set; }

        public static readonly string INSERT_SQL = "INSERT INTO Cartao (NumeroCartao, CodigoSeguranca, DataValidade, NomeCartao) VALUES (@NumeroCartao, @CodigoSeguranca, @DataValidade, @NomeCartao); SELECT SCOPE_IDENTITY();";
    }
}

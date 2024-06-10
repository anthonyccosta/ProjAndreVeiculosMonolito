using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CarroServico
    {
        public int Id { get; set; }
        public Carro Carro { get; set; }

        public Servico Servico { get; set; }
        public bool? Status { get; set; } 

        public static readonly string INSERT_SQL = "INSERT INTO CarroServico (CarroId, ServicoId, Status) VALUES (@CarroId, @ServicoId, @Status); SELECT SCOPE_IDENTITY();";

        public static readonly string UPDATE_SQL = "UPDATE CarroServico SET Status = @Status WHERE Id = @Id; SELECT SCOPE_IDENTITY();";
    }
}

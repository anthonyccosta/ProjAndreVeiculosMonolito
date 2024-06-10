using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cargo
    {
        public readonly static string INSERT_SQL = "INSERT INTO Cargo (Descricao) VALUES (@descricao)";
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override string ToString() 
        {
            return $"Cargo: Id={Id}, Descricao={Descricao}";
        }
    }
}

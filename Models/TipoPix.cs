using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TipoPix
    {
        public readonly static string INSERT = " INSERT INTO PIXTYPE (Nome) VALUES (@Nome); SELECT cast(scope_identity() as int) ";

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pix
    {
        public readonly static string INSERT = " INSERT INTO PIX (IdTipoPix, ChavePix) VALUES (@IdTipoPix, @ChavePix); SELECT SCOPE_IDENTITY(); ";

        public int Id { get; set; }
        public TipoPix Tipo { get; set; }
        public string ChavePix { get; set; }
    }
}

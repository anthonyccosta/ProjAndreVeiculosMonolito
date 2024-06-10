using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }

        public Carro Carro { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [DataType(DataType.Date)] // Optional for validation (assuming date)
        public DateTime DataCompra { get; set; }

        public static readonly string INSERT_SQL = "INSERT INTO Compra (PlacaVeiculo, Preco, DataCompra) VALUES (@PlacaVeiculo, @Preco, @DataCompra); SELECT SCOPE_IDENTITY();";
    }
}
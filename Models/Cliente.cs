using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente : Pessoa
    {
        [Required] 
        public decimal Renda { get; set; }

        [DataType(DataType.Url)] 
        public string DocumentoPDF { get; set; }

        public static readonly string INSERT_SQL = "INSERT INTO Cliente (Documento, Renda, DocumentoPDF, Nome, DataNascimento, EnderecoId, Telefone, Email) VALUES (@Documento, @Renda, @DocumentoPDF, @Nome, @DataNascimento, @EnderecoId, @Telefone, @Email); SELECT SCOPE_IDENTITY();";
    }
}

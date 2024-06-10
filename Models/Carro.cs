using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Models
{
    public class Carro
    {
        public static readonly string INSERT_SQL = "INSERT INTO Carro (Placa, Nome, AnoModelo, AnoFabricacao, Cor, Vendido) VALUES (@Placa, @Nome, @AnoModelo, @AnoFabricacao, @Cor, @Vendido)";

        [Key]
        [JsonProperty("licensePlate")] 
        public string Placa { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("modelYear")]
        public int AnoModelo { get; set; }

        [JsonProperty("fabricationYear")]
        public int AnoFabricacao { get; set; }

        [JsonProperty("cor")]
        public string Cor { get; set; }

        [JsonProperty("sold")]
        public bool Vendido { get; set; }

        public XElement? GetXMLDocument() 
        {
            return new XElement("carro",
                new XElement("placa", Placa),
                new XElement("nome", Nome),
                new XElement("anoModelo", AnoModelo),
                new XElement("anoFabricacao", AnoFabricacao),
                new XElement("cor", Cor)
            );
        }

        public override string ToString()
        {
            return $"Placa: {Placa}, Nome: {Nome}, Ano Modelo: {AnoModelo}, Ano Fabricação: {AnoFabricacao}, Cor: {Cor}";
        }
    }
}

using ExcelApi.Enums;

namespace ExcelApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string  Sobrenome { get; set; }
        public string Email { get; set; }
        public OrigemCadastro Origem { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}

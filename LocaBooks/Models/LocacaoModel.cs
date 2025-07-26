using System.ComponentModel.DataAnnotations.Schema;

namespace LocaBooks.Models
{
    public class LocacaoModel
    {
        public int Id { get; set; }
        public string LivroID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime DataRetirada { get; set; } = DateTime.Now;
        public DateTime DataDevolucaoPrevista { get; set; }
        public DateTime? DataDevolucaoReal { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Multa { get; set; }

    }
}

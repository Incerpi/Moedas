using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grupoAtlas.Model

{
    [Table("MOEDA")]
    public class Moeda
    {
        [Key]
        public int IdMoeda { get; set; }

        [Required]
        public string Codigo { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public float Valor { get; set; }

        [Required]
        public float Variacao { get; set; }

        [Required]
        public double PctVariacao { get; set; }

        [Required]
        public DateTime Data { get; set;}

    }
}

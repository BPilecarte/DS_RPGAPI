using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace RpgApi.Models
{
    //using System.ComponentModel.DataAnnotations.Schema;
    [Table("TB_DISPUTAS")]
    public class Disputa
    {
        [Key] //using System.ComponentModel.DataAnnotations;
        [Column("Id")]
        public int Id { get; set; }

        [Column("Dt_Disputa")]
        public DateTime? DataDisputa { get; set; }

        [Column("AtacanteId")]
        public int AtacanteId { get; set; }

        [Column("OponenteId")]
        public int OponenteId { get; set; }

        [Column("Tx_Narracao")]
        public string Narracao { get; set; } = string.Empty;

        [NotMapped]
        public int? HabilidadeId { get; set; }

        [NotMapped]
        public List<int>? ListaIdPersonagens { get; set; }

        [NotMapped]
        public List<string>? Resultados { get; set; }




    }

      














}
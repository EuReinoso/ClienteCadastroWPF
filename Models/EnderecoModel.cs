using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClienteCadastroWPF.Models
{
    public class EnderecoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int END_CODIGO { get; set; }

        [StringLength(8)]
        public string? END_CEP { get; set; }

        [StringLength(70)]
        public string? END_ENDERECO { get; set; }

        [StringLength(5)]
        public string? END_NUMERO { get; set; }

        [StringLength(40)]
        public string? END_BAIRRO { get; set; }

        [StringLength(50)]
        public string? END_CIDADE { get; set; }
    }
}

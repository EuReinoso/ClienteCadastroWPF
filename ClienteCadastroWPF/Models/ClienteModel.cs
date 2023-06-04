using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ClienteCadastroWPF.Models
{
    public class ClienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CLI_CODIGO { get; set; }

        [StringLength(14)]
        public string? CLI_CGC { get; set; }

        [StringLength(50)]
        public string? CLI_NOME { get; set; }

        public int? CLI_ENDERECO { get; set; }

        [StringLength(11)]
        public string? CLI_CELULAR { get; set; }

        [StringLength(50)]
        public string? CLI_EMAIL { get; set; }

        public char? CLI_SEXO { get; set; }

        public DateTime? CLI_NASCIMENTO { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CLI_CADASTRO { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CLI_ATUALIZACAO { get; set; }

        public Boolean? CLI_ATIVO { get; set; }

        [StringLength(25)]
        public string? CLI_CODIGO_EXTERNO { get; set; }

    }
}

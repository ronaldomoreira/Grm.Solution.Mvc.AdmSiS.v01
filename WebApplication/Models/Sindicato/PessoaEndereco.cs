using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_PESSOA_END")]
    public class PessoaEndereco: GrmCustomEntity 
    {
        [Key]
        [Column("ID_PESSOA", Order = 0)]
        public int IdPessoa { get; set; }

        [Key]
        [Column("ID_ENDERECO", Order = 1)]
        public int IdEndereco { get; set; }
        //public virtual Endereco EnderecoEnd { get; set; }

        [Column("END_SEDE")]
        [Required]
        [StringLength(1)]
        [Display(Name = "End. sede")]
        public string EnderecoSede { get; set; }

        [Column("END_COBRANCA")]
        [Required]
        [StringLength(1)]
        [Display(Name = "End. cobrança")]
        public string EnderecoCobranca { get; set; }

        [Column("END_ENTREGA")]
        [Required]
        [StringLength(1)]
        [Display(Name = "End. entrega")]
        public string EnderecoEntrega  { get; set; }

        [Column("END_CORRESP")]
        [Required]
        [StringLength(1)]
        [Display(Name = "End. correspondência")]
        public string EnderecoCorresp { get; set; }

        [Column("END_VISITA")]
        [Required]
        [StringLength(1)]
        [Display(Name = "End. visita")]
        public string EnderecoVisita { get; set; }
    }
}

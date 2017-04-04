using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_TEL_PESSOA")]
    public class TelefonePessoa
    {
        [Key]
        [Column("ID_TEL_PESSOA")]
        [Display(Name = "Código")]
        public int IdTelefonePessoa { get; set; }

        [Column("ID_PESSOA")]
        [Display(Name = "Pessoa")]
        public int IdPessoa { get; set; }
        public virtual Pessoa TelefonePessoaPessoa { get; set; }

        [Column("ID_OPERADORA")]
        [Display(Name = "Operadora")]
        public int? IdOperadoraTel { get; set; }
        public virtual OperadoraTel TelefonePessoaOperadoraTel { get; set; }

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }

        [Column("TIPO_TEL")]
        [Display(Name = "Tipo telefone")]
        [Required]
        [StringLength(1)]
        public string TipoTel { get; set; }

        [Column("DDI_TEL")]
        [Display(Name = "DDI")]
        [StringLength(5)]
        [DisplayFormat(DataFormatString = "{0:##}", ApplyFormatInEditMode = true)]
        public string DDITel  { get; set; }

        [Column("DDD_TEL")]
        [Display(Name = "DDD")]
        [DisplayFormat(DataFormatString = "{0:##}", ApplyFormatInEditMode = true)]
        [StringLength(2)]
        public string  DDDTel { get; set; }

        [Column("TELEFONE")]
        [Display(Name = "Telefone")]
        [StringLength(15)]
        //[DisplayFormat(DataFormatString = "{0:(##) #####-####}", ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = "{0:#####-####}", ApplyFormatInEditMode = true)]
        public string Telefone { get; set; }

        [Column("RAMAL_TEL")]
        [Display(Name = "Ramal")]
        [StringLength(10)]
        public string Ramal { get; set; }

        [Column("SETOR")]
        [Display(Name = "Setor")]
        [StringLength(100)]
        public string Setor { get; set; }

        [Column("NOM_CONT_TEL")]
        [Display(Name = "Contato")]
        [StringLength(100)]
        public string MonContTel { get; set; }

        [Column("OBS")]
        [Display(Name = "Observação")]
        [StringLength(100)]
        public string Observacao { get; set; }
    }
}

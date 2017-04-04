using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_CFG_CTA_A_SIST")]
    public partial class ConfigContaAcessoSistema: GrmCustomEntity
    { 
        [Key]
        [Column("ID_CFG_CTA_A_SIST")]
        public int IdConfigContaAcessoSistema { get; set; }

        [Column("ID_CTA_ACESSO_SIST")]
        [ForeignKey("ConfigContaAcessoSistemaContaAcessoSistema")]
        public int? IdContaAcessoSistema { get; set; }
        public virtual ContaAcessoSistema ConfigContaAcessoSistemaContaAcessoSistema { get; set; } //TB_CTA_ACESSO_SIST

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }

        [Column("MODULO")]
        [Required]
        [StringLength(50)]
        public string Modulo { get; set; }

        [Column("NOME")]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("VALOR")]
        [StringLength(255)]
        public string Valor { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_O_CLA")]
    public class OrientacaoClausula: GrmCustomEntity
    {
        [Key]
        [Column("ID_O_CLA")]
        [Display(Name = "Código")]
        public int IdOrientacaoClausula { get; set; }

        [Column("ID_CLAUSULA")]
        //[ForeignKey(nameof(OrientacaoClausulaClausula))]
        [Display(Name = "Cláusula")]
        public int IdClausula { get; set; }
        //public virtual Clausula OrientacaoClausulaClausula { get; set; }

        [Column("SIGLA")]
        [Required]
        [StringLength(5)]
        [Display(Name = "Sigla")]
        public string Sigla { get; set; }

        [Column("ORIENTACAO")]
        [StringLength(1024)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Orientação")]
        public string Orientacao { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
    }
}

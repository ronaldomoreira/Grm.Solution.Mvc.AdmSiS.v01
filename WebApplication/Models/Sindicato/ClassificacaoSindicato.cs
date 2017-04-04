using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_CLASS_SIND")]
    public class ClassificacaoSindicato: GrmCustomEntity
    {
        public ClassificacaoSindicato()
        {
            //TB_SIND = new HashSet<TB_SIND>();
        }

        [Key]
        [Column("ID_CLASS_SIND")]
        [Display(Name = "Código")]
        public int IdClassificacaoSindicato { get; set; }

        [Column("DESCRICAO")]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}

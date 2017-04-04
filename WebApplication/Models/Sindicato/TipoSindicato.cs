using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_TIPO_SIND")]
    public class TipoSindicato
    {
        public TipoSindicato()
        {
            //Sindicatos = new HashSet<Sindicato>();
        }

        [Key]
        [Column("ID_TIPO_SIND")]
        [Display(Name = "Código")]
        public int IdTipoSindicato { get; set; }

        [Column("DESCRICAO")]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        //public virtual ICollection<TB_CFG_USUARIO> TB_CFG_USUARIO { get; set; }
    }
}

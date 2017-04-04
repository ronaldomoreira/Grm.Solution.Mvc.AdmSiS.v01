using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_TIPO_ACORDO")]
    public class TipoAcordo
    {
        public TipoAcordo()
        {
            //this.AcordosSindicais = new HashSet<AcordoSindical>();
        }

        [Key]
        [Column("ID_TIPO_ACORDO")]
        [Display(Name = "C�d. tipo")]
        public int IdTipoAcordo { get; set; }

        [Column("DESCRICAO")]
        [Display(Name = "Descri��o")]
        [StringLength(100)]
        public string Descricao { get; set; }

        //public virtual ICollection<AcordoSindical> AcordosSindicais { get; set; }
    }
}

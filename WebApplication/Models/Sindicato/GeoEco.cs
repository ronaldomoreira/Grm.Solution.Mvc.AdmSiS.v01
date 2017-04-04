using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_GEO_ECO")]
    public class GeoEco: GrmCustomEntity
    {
        public GeoEco()
        {
            //Sindicatos = new HashSet<Sindicato>();
        }

        [Key]
        [Column("ID_GEO_ECO")]
        [Display(Name = "Código")]
        public int IdGeoEco { get; set; }

        [Column("DESCRICAO")]
        [StringLength(100)]
        [Display(Name = "Descrição", Prompt = "", Description = "")]
        public string Descricao { get; set; }

        //public virtual ICollection<Sindicato> Sindicatos { get; set; }
    }
}

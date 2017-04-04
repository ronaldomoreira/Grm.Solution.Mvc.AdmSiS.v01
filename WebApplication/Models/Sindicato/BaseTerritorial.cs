using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_BASE_TERR")]
    public partial class BaseTerritorial: GrmCustomEntity
    {
        [Key]
        [Column("ID_BASE_TERR")]
        [Display(Name = "Cód. base territorial")]
        public int IdBaseTerritorial { get; set; }

        [Column("ID_SIND")]
        [Display(Name = "Sindicato")]
        public int? IdSindicato { get; set; }

        [Column("TIPO_BASE")]
        [StringLength(1)]
        [Display(Name = "Tipo base territorial")]
        public string TipoBase { get; set; }
    }
}

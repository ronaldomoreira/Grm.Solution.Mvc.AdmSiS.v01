using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_BASE_TERR_UF")]
    public partial class BaseTerritorialUf: GrmCustomEntity
    {
        [Key]
        [Column("ID_BASE_TERR")]
        public int IdBaseTerritorial { get; set; }

        [Key]
        [Column("ID_UF")]
        public int IdUf { get; set; }
    }
}

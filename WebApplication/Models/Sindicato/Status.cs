using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_STATUS")]
    public class Status
    {
        public Status()
        {
            //TB_ST_VALOR = new HashSet<TB_ST_VALOR>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string TABELA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string CAMPO { get; set; }

        //public int? ID_CTA_ACESSO_SIST { get; set; }
    }
}

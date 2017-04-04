using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_ST_VALOR")]
    public class StatusValor
    {
        [Key]
        public int ID_ST_VALOR { get; set; }

        [Required]
        [StringLength(32)]
        public string TABELA { get; set; }

        [Required]
        [StringLength(32)]
        public string CAMPO { get; set; }

        [StringLength(1)]
        public string VALOR { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_CURTA { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string FLAG_VAL_INI { get; set; }

        [StringLength(1)]
        public string FLAG_VAL_FIM { get; set; }

        //public virtual Status StatusValorStatus { get; set; }
    }
}

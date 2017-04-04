using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_NAT_OP")]
    public class NaturezaOperacao: GrmCustomEntity
    {
        [Key]
        public int ID_NAT_OP { get; set; }

        public int ID_EMP_SIST { get; set; }

        [Required]
        [StringLength(20)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCRICAO { get; set; }

        [Required]
        [StringLength(1)]
        public string STATUS { get; set; }

        [StringLength(1)]
        public string TIPO_OPERACAO { get; set; }

    }
}

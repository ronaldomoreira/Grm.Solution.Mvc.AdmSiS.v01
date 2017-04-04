using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_LOG_ERRO")]
    public class LogErro
    {
        [Key]
        public int ID_LOG_ERRO { get; set; }

        public int? ID_CTA_ACESSO_SIST { get; set; }

        public int? ID_USUARIO { get; set; }

        public DateTime? DT_LOG { get; set; }

        [StringLength(1024)]
        public string COMANDO { get; set; }

        [StringLength(32)]
        public string IP { get; set; }

        [StringLength(1024)]
        public string MSG_ERRO { get; set; }
    }
}

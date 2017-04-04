using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_LOG_EVENTO")]
    public class LogEvento
    {
        [Key]
        public int ID_LOG_EVENTO { get; set; }

        public int ID_EMP_SIST { get; set; }

        public int ID_USUARIO { get; set; }

        public DateTime? DT_INI { get; set; }

        public DateTime? DT_FIM { get; set; }

        [StringLength(255)]
        public string DESCRICAO { get; set; }

        [StringLength(255)]
        public string VAL_INI { get; set; }

        [StringLength(255)]
        public string VAL_FIM { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        [StringLength(255)]
        public string OBS { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_REG_LIC")]
    public class RegistroLicenca: GrmCustomEntity
    {
        [Key]
        [Column("ID_REG_LIC")]
        public int IdRegistroLicenca { get; set; }
        
        [Column("ID_CTA_ACESSO_SIST")]
        public int IdContaAcessoSistema { get; set; }

        [Column("ID_USR_CAD")]
        public int? IdUsuarioCad { get; set; }

        [Column("ID_USR_ALTER")]
        public int? IdUsuarioAlter { get; set; }

        [Column("DT_CAD")]
        public DateTime? DataCad { get; set; }

        [Column("DT_ALTER")]
        public DateTime? DataAlter { get; set; }

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }

        [Column("END_IP")]
        [StringLength(100)]
        public string EnderecoIP { get; set; }

        [Column("NOME_MAQ")]
        [StringLength(100)]
        public string NomeMaquina { get; set; }

        [Column("DESCRICAO")]
        [StringLength(100)]
        public string descricao { get; set; }

        [Column("END_MAC")]
        [StringLength(100)]
        public string EnderecoMAC { get; set; }

        [Column("DT_REG")]
        public DateTime? DataRegistro { get; set; }

        [Column("NUM_REG")]
        [StringLength(128)]
        public string NumRegistro { get; set; }

        [Column("SERIAL_CPU")]
        [StringLength(128)]
        public string SerialCPU  { get; set; }

        [Column("SERIAL_HD")]
        [StringLength(128)]
        public string SerialHD { get; set; }

        [Column("STATUS_REG")]
        [StringLength(1)]
        public string StatusREgistro { get; set; }

        //public virtual TB_USUARIO TB_USUARIO { get; set; }

        //public virtual TB_USUARIO TB_USUARIO1 { get; set; }
    }
}

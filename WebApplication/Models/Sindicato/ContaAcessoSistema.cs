using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_CTA_ACESSO_SIST")]
    public class ContaAcessoSistema: GrmCustomEntity
    {
        public ContaAcessoSistema()
        {
            //TB_CFG_CTA_A_SIST = new HashSet<TB_CFG_CTA_A_SIST>();
            //TB_EMP_SIST       = new HashSet<TB_EMP_SIST>();
            //TB_LOG_ERRO       = new HashSet<TB_LOG_ERRO>();
            //TB_REG_LIC        = new HashSet<TB_REG_LIC>();
            //ContaAcessoSistemaStatus = new HashSet<Status>();
            //Usuarios        = new HashSet<TB_USUARIO>();
        }

        [Key]
        [Column("ID_CTA_ACESSO_SIST")]
        public int IdContaAcessoSistema { get; set; }

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }

        [Column("NUM_LICENCA")]
        [StringLength(128)]
        public string NumLicenca { get; set; }

        [Column("CHAVE_LIC")]
        [StringLength(128)]
        public string ChaveLicenca { get; set; }

        [Column("STATUS_LIC")]
        [Required]
        [StringLength(1)]
        public string StatusLic { get; set; }

        [Column("DT_CAD")]
        public DateTime DataCad { get; set; }

        [Column("DT_ALTER")]
        public DateTime? DataAlter { get; set; }

        [Column("NOME_SISTEMA")]
        [Required]
        [StringLength(100)]
        public string NomeSistema { get; set; }

        [Column("NOME_VERSAO")]
        [StringLength(100)]
        public string NomeVersao { get; set; }

        [Column("NUM_VERSAO")]
        [StringLength(100)]
        public string NumVersao { get; set; }

        [Column("NOME_FANTASIA")]
        [StringLength(100)]
        public string NomeFantasia { get; set; }

        [Column("RAZAO_SOCIAL")]
        [StringLength(100)]
        public string RazaoSocial { get; set; }

        [Column("DT_NASC")]
        public DateTime DataNasc { get; set; }

        [Column("FLAG_FIS_JUR")]
        [StringLength(1)]
        public string FlagFisJur { get; set; }

        [Column("CPF")]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Column("RG")]
        [StringLength(15)]
        public string Rg { get; set; }

        [Column("RG_ORGAO_EMISSOR")]
        [StringLength(10)]
        public string RgOrgaoEmissor { get; set; }

        [Column("RG_EMISSAO")]
        public DateTime? RgEmissao { get; set; }

        [Column("CNPJ")]
        [StringLength(15)]
        public string Cnpj { get; set; }

        [Column("INSC_EST")]
        [StringLength(20)]
        public string InscEstadual { get; set; }

        [Column("INSC_MUN")]
        [StringLength(20)]
        public string InscMunicipal { get; set; }

        //public virtual ICollection<TB_EMP_SIST> TB_EMP_SIST { get; set; }
        //public virtual ICollection<TB_USUARIO> TB_USUARIO { get; set; }

        //public virtual ICollection<ConfigContaAcessoSistema> ConfigContaAcessoSistemas { get; set; }
        //public virtual ICollection<Status> ContaAcessoSistemaStatus { get; set; }
    }
}

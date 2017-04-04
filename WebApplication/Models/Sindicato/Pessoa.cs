using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_PESSOA")]
    public class Pessoa: GrmCustomEntity 
    {
        public Pessoa()
        {
            //TB_PESSOA_END = new HashSet<TB_PESSOA_END>();
            //TB_TEL_PESSOA = new HashSet<TB_TEL_PESSOA>();
            //TB_EMP_SIST   = new HashSet<TB_EMP_SIST>();
            // nao em display ----------------------------------------
        }
        [Key]
        [Column("ID_PESSOA")]
        public int IdPessoa { get; set; }

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }

        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Column("COD_EXT1")]
        [StringLength(20)]
        public string CodExterno1 { get; set; }

        [Column("DT_IMPORT")]
        public DateTime? DataImport { get; set; }

        [Column("FLAG_IMPORT")]
        [StringLength(1)]
        public string FlagImport { get; set; }

        [Column("STATUS_PESSOA")]
        [Required]
        [StringLength(1)]
        public string StatusPessoa { get; set; }

        [Column("NOME_PESSOA")]
        [Required]
        [StringLength(100)]
        public string NomePessoa { get; set; }

        [Column("RAZAO_SOCIAL")]
        [StringLength(100)]
        public string RazaoSocial { get; set; }

        [Column("NATURALIDADE")]
        [StringLength(255)]
        public string Naturalidade { get; set; }

        [Column("DT_NASC")]
        public DateTime? DataNasc { get; set; }

        [Column("FLAG_FIS_JUR")]
        [StringLength(1)]
        public string FlagFisJur { get; set; }

        [Column("SEXO")]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Column("PAI")]
        [StringLength(100)]
        public string Pai { get; set; }

        [Column("MAE")]
        [StringLength(100)]
        public string Mae { get; set; }

        [Column("CPF")]
        [StringLength(11)]
        public string Cpf  { get; set; }

        [Column("RG")]
        [StringLength(15)]
        public string Rg { get; set; }

        [Column("RG_ORGAO_EMISSOR")]
        [StringLength(10)]
        public string RgOrgaoEmissor { get; set; }

        [Column("RG_EMISSAO")]
        public DateTime? RgEmissao { get; set; }

        [Column("PASSAPORTE")]
        [StringLength(32)]
        public string Passaport { get; set; }

        [Column("CNPJ")]
        [StringLength(15)]
        public string Cnpj { get; set; }

        [Column("INSC_EST")]
        [StringLength(20)]
        public string InscricaoEstadual { get; set; }

        [Column("INSC_MUN")]
        [StringLength(20)]
        public string InscricaoMunicipal { get; set; }

        [Column("OPT_SIMPLES_NAC")]
        [StringLength(1)]
        public string OptanteSimplesNacional { get; set; }

        //public virtual ICollection<TB_PESSOA_END> TB_PESSOA_END { get; set; }
        //public virtual ICollection<TB_TEL_PESSOA> TB_TEL_PESSOA { get; set; }
        //public virtual ICollection<TB_EMP_SIST> TB_EMP_SIST { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_EMP_SIST")]  //dados da empresa versao multiusuario
    public class EmpresaSistema: GrmCustomEntity
    {
        public EmpresaSistema()
        {
            //TB_AG_BANCO     = new HashSet<TB_AG_BANCO>();
            //TB_BANCO        = new HashSet<Banco>();
            //TB_CFG_EMP_SIST = new HashSet<TB_CFG_EMP_SIST>();
            //TB_CTA_CORRENTE = new HashSet<TB_CTA_CORRENTE>();
            //TB_FUNCAO       = new HashSet<TB_FUNCAO>();
            //TB_FUNCIONARIO  = new HashSet<TB_FUNCIONARIO>();
            //TB_LOG_EVENTO   = new HashSet<TB_LOG_EVENTO>();
            //TB_NAT_OP       = new HashSet<TB_NAT_OP>();
            //TB_UNIDADE      = new HashSet<TB_UNIDADE>();
            //TB_SIND1        = new HashSet<TB_SIND>();
            //TB_PESSOA       = new HashSet<TB_PESSOA>();
            //TB_USUARIO2     = new HashSet<TB_USUARIO>();
        }

        [Key]
        [Column("ID_EMP_SIST")]
        public int IdEmpresaSistema { get; set; }
        
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
        
        [Column("CODIGO")]        
        [StringLength(20)]
        public string Codigo { get; set; }

        [Column("COD_EXT1")]
        [StringLength(20)]
        public string CodExt1 { get; set; }

        [Column("DT_IMPORT")]
        public DateTime? DataImport { get; set; }

        [Column("FLAG_IMPORT")]            
        [StringLength(1)]
        public string FlagImport { get; set; }
                
        [Column("STATUS_EMP_SIST")]            
        [Required]
        [StringLength(1)]
        public string StatusEmpSist { get; set; }

        [Column("NOME")]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

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
        public string Passaporte { get; set; }

        [Column("CNPJ")]
        [StringLength(15)]
        public string Cnpj { get; set; }

        [Column("INSC_EST")]
        [StringLength(20)]
        public string InscEst { get; set; }

        [Column("INSC_MUN")]
        [StringLength(20)]
        public string InscMun { get; set; }

        [Column("OPT_SIMPLES_NAC")]
        [StringLength(1)]
        public string OptSimplesNac { get; set; }

        [Column("TIPO_LOG")]
        [StringLength(10)]
        public string TipoLog { get; set; }

        [Column("LOGRADOURO")]
        [StringLength(100)]
        public string Logradouro { get; set; }

        [Column("NUMERO")]
        [StringLength(10)]
        public string Numero { get; set; }

        [Column("COMPLEMENTO")]
        [StringLength(20)]
        public string Complemento { get; set; }

        [Column("BAIRRO")]
        [StringLength(100)]
        public string Bairro { get; set; }

        [Column("MUNICIPIO")]
        [StringLength(100)]
        public string Municipio { get; set; }

        [Column("CEP")]
        [StringLength(10)]
        public string Cep { get; set; }

        [Column("SIGLA_UF")]
        [StringLength(2)]
        public string SiglaUf { get; set; }

        [Column("SIGLA_PAIS")]
        [StringLength(5)]
        public string SiglaPais { get; set; }

        [Column("COD_POSTAL_EXT")]
        [StringLength(32)]
        public string CodPostalExt { get; set; }

        [Column("ENDERECO_EXT")]
        [StringLength(100)]
        public string EnderecoExt { get; set; }

        [Column("COMPLEMENTO_EXT")]
        [StringLength(255)]
        public string ComplementoExt { get; set; }

        [Column("CIDADE_EXT")]
        [StringLength(100)]
        public string CidadeExt { get; set; }

        [Column("ESTADO_EXT")]
        [StringLength(100)]
        public string EstadoExt { get; set; }

        // Telefone  Comercial 1
        [Column("DDI_TEL_COM1")]
        [StringLength(5)]
        public string DDITelCom1 { get; set; }

        [Column("DDD_TEL_COM1")]
        [StringLength(2)]
        public string DDDTelCom1 { get; set; }

        [Column("TELEFONE_COM1")]
        [StringLength(15)]
        public string TelefoneCom1 { get; set; }

        [Column("RAMAL_TEL_COM1")]
        [StringLength(10)]
        public string RamalTelCom1 { get; set; }

        [Column("NOM_CONT_TEL_COM1")]
        [StringLength(100)]
        public string NomContTelCom1 { get; set; }

        // Telefone  Comercial 2
        [Column("DDI_TEL_COM2")]
        [StringLength(5)]
        public string DDITelCom2 { get; set; }

        [Column("DDD_TEL_COM2")]
        [StringLength(2)]
        public string DDDTelCom2 { get; set; }

        [Column("TELEFONE_COM2")]
        [StringLength(15)]
        public string TelefoneCom2 { get; set; }

        [Column("RAMAL_TEL_COM2")]
        [StringLength(10)]
        public string RamalTelCom2 { get; set; }

        [Column("NOM_CONT_TEL_COM2")]
        [StringLength(100)]
        public string NomContTelCom2 { get; set; }
        
        //  Telefone Celular
        [Column("DDI_TEL_CEL")]
        [StringLength(5)]
        public string DDITelCel { get; set; }

        [Column("DDD_TEL_CEL")]
        [StringLength(2)]
        public string DDDTelCel { get; set; }

        [Column("TELEFONE_CEL")]
        [StringLength(15)]
        public string TelefoneCel { get; set; }

        [Column("NOM_CONT_TEL_CEL")]
        [StringLength(100)]
        public string NomContTelCel { get; set; }

        [Column("LOGOTIPO")]
        [MaxLength(1)]
        public byte[] LogoTipo { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        public string Observacao { get; set; }

        //public virtual ContaAcessoSistema EmpresaSistemaContaAcessoSistema { get; set; } //TB_CTA_ACESSO_SIST

        //public virtual Sindicato EmpresaSistemaSindicato { get; set; } //TB_SIND

        //public virtual Usuario EmpresaSistemaUsuarioCad { get; set; } //TB_USUARIO

        //public virtual Usuario EmpresaSistemaUsuarioAlter { get; set; } //TB_USUARIO

        //public virtual ICollection<TB_AG_BANCO> TB_AG_BANCO { get; set; }

        //public virtual ICollection<Banco> TB_BANCO { get; set; }

        //public virtual ICollection<TB_CFG_EMP_SIST> TB_CFG_EMP_SIST { get; set; }

        //public virtual ICollection<TB_CTA_CORRENTE> TB_CTA_CORRENTE { get; set; }

        //public virtual ICollection<TB_FUNCAO> TB_FUNCAO { get; set; }

        //public virtual ICollection<TB_FUNCIONARIO> TB_FUNCIONARIO { get; set; }

        //public virtual ICollection<TB_LOG_EVENTO> TB_LOG_EVENTO { get; set; }

        //public virtual ICollection<TB_NAT_OP> TB_NAT_OP { get; set; }

        //public virtual ICollection<TB_UNIDADE> TB_UNIDADE { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND1 { get; set; }

        //public virtual ICollection<TB_PESSOA> TB_PESSOA { get; set; }

        //public virtual ICollection<TB_USUARIO> TB_USUARIO2 { get; set; }
    }
}

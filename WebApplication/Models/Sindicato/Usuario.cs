using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_USUARIO")]
    public class Usuario: GrmCustomEntity
    {
        public Usuario()
        {
            //TB_CFG_USUARIO = new HashSet<TB_CFG_USUARIO>();
            //TB_EMP_SIST    = new HashSet<TB_EMP_SIST>();
            //TB_EMP_SIST1   = new HashSet<TB_EMP_SIST>();
            //TB_LOG_ERRO    = new HashSet<TB_LOG_ERRO>();
            //TB_LOG_EVENTO  = new HashSet<TB_LOG_EVENTO>();
            //TB_REG_LIC     = new HashSet<TB_REG_LIC>();
            //TB_REG_LIC1    = new HashSet<TB_REG_LIC>();
            //TB_SIND        = new HashSet<TB_SIND>();
            //TB_SIND1       = new HashSet<TB_SIND>();
            //TB_SIND2       = new HashSet<TB_SIND>();
            //TB_EMP_SIST2   = new HashSet<TB_EMP_SIST>();
        }

        [Key]
        [Column("ID_USUARIO")]        
        public int IdUsuario { get; set; }

        [Column("ID_GRUPO_USER")]
        //[ForeignKey("UsuarioGrupoUsuario")]
        public int IdGrupoUsuario { get; set; }
        //public virtual GrupoUsuario UsuarioGrupoUsuario { get; set; } //TB_GRUPO_USER

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

        [Column("STATUS_USER")]
        [Required]
        [StringLength(1)]
        public string FlagUsuario { get; set; }

        [Column("LOGIN_NAME")]
        [Required]
        [StringLength(20)]
        public string LoginName { get; set; }

        [Column("PASSWD")]
        [Required]
        [StringLength(128)]
        [MinLength(6, ErrorMessage = "O tamanho mínimo do nome são 5 caracteres.")]
        public string PassWd { get; set; }

        [Column("LOGIN_DB")]
        [StringLength(20)]
        public string LoginDb { get; set; }

        [Column("PASSWD_DB")]
        [StringLength(128)]
        public string PasswdDb { get; set; }

        [Column("NOME_USER")]
        [Required]
        [StringLength(100)]
        public string NomeUser { get; set; }

        [Column("CPF")]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Column("DDD_CEL")]
        [StringLength(2)]
        public string DddCelular { get; set; }

        [Column("TEL_CEL")]
        [StringLength(20)]
        public string TelCelular { get; set; }

        [Column("DDD_COM")]
        [StringLength(2)]
        public string DDDComercial { get; set; }

        [Column("TEL_COM")]
        [StringLength(20)]
        public string Telcomercial { get; set; }

        [Column("RAMAL")]
        [StringLength(10)]
        public string Ramal { get; set; }

        [Column("SETOR")]
        [StringLength(255)]
        public string Setor { get; set; }

        [Column("CARGO")]
        [StringLength(255)]
        public string Cargo { get; set; }

        [Column("EMAIL")]
        [StringLength(255)]
        public string Email { get; set; }

        [Column("VALIDADE")]
        public DateTime? Validade { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        public string Observacao { get; set; }


        //public virtual ICollection<TB_CFG_USUARIO> TB_CFG_USUARIO { get; set; }

        //public virtual ICollection<TB_EMP_SIST> TB_EMP_SIST { get; set; }

        //public virtual ICollection<TB_EMP_SIST> TB_EMP_SIST1 { get; set; }

        //public virtual ICollection<TB_LOG_ERRO> TB_LOG_ERRO { get; set; }

        //public virtual ICollection<TB_LOG_EVENTO> TB_LOG_EVENTO { get; set; }

        //public virtual ICollection<TB_REG_LIC> TB_REG_LIC { get; set; }

        //public virtual ICollection<TB_REG_LIC> TB_REG_LIC1 { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND1 { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND2 { get; set; }

        //public virtual ICollection<TB_EMP_SIST> TB_EMP_SIST2 { get; set; }

    }
}

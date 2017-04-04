using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_SIND")]
    public class Sindicato: Pessoa
    {
        public Sindicato()
        {
            //TB_ACORDO_SIND  = new HashSet<TB_ACORDO_SIND>();
            //TB_ACORDO_SIND1 = new HashSet<TB_ACORDO_SIND>();
            //TB_BASE_TERR    = new HashSet<BaseTerritorial>();
            //TB_EMP_SIST     = new HashSet<TB_EMP_SIST>();
            //TB_EMP_SIST1    = new HashSet<TB_EMP_SIST>();
        }

        [Key]
        [Column("ID_SINDICATO")]
        [Display(Name = "Cod. sindicato")]
        public int IdSindicato { get; set; }

        [Column("ID_TIPO_SIND")]
        //[ForeignKey(nameof(SindicatoTipoSindicato))]
        [Display(Name = "Tipo sindicato")]
        public int? IdTipoSindicato { get; set; } //public virtual Sindicato { get; set; }
        //public virtual TipoSindicato SindicatoTipoSindicato { get; set; }

        [Column("ID_CLASSIF")]
        //[ForeignKey(nameof(SindicatoClassificacaoSindicato))]
        [Display(Name = "Classificação")]
        public int IdClassificacaoSindicato { get; set; }
        //public virtual ClassificacaoSindicato SindicatoClassificacaoSindicato { get; set; }

        [Column("ID_GEO_ECO")]
        //[ForeignKey(nameof(SindicatoGeoEco))]
        [Display(Name = "Geo eco")]
        public int? IdGeoEco { get; set; }
        //public virtual GeoEco SindicatoGeoEco { get; set; }

        [Column("ID_USR_REL")]
        //[ForeignKey(nameof(SindicatoUsuarioRelacionamento))]
        [Display(Name = "Usuário relacionamento")]
        public int? IdUsuarioRelacionamento { get; set; }
        //public virtual Usuario SindicatoUsuarioRelacionamento { get; set; }

        [Column("ID_CONF")]
        [ForeignKey(nameof(SindicatoConfederacao))]
        [Display(Name = "Confederação")]
        public int? IdConfederecao { get; set; }
        public virtual OrganizacaoSindical SindicatoConfederacao { get; set; }

        [Column("ID_FED")]
        [ForeignKey(nameof(SindicatoFederacao))]
        [Display(Name = "Federaão")]
        public int? IdFederecao { get; set; }
        public virtual OrganizacaoSindical SindicatoFederacao { get; set; }
        
        [Column("ID_CENTRAL")]
        [ForeignKey(nameof(SindicatoCentralSindical))]
        [Display(Name = "Central")]
        public int? IdCentral { get; set; }
        public virtual OrganizacaoSindical SindicatoCentralSindical { get; set; }

        [Column("ID_USR_CAD")]
        public int? IdUsuarioCad { get; set; }

        [Column("ID_USR_ALTER")]
        public int? IdUsuarioAlter { get; set; }

        [Column("DT_CAD")]
        public DateTime? DataCad { get; set; }

        [Column("DT_ALTER")]
        public DateTime? DataAlter { get; set; }

        [Column("FLAG_CONF")]
        [StringLength(1)]
        [Display(Name = "Confederado")]
        public string FlagConf { get; set; }

        [Column("FLAG_FED")]
        [StringLength(1)]
        [Display(Name = "Federado")]
        public string FlagFed { get; set; }

        [Column("FLAG_CENTRAL")]
        [StringLength(1)]
        [Display(Name = "Central")]
        public string FlagCentral { get; set; }

        [Column("BASE_TERR")]
        [StringLength(1)]
        [Display(Name = "Base territorial")]
        public string BaseTerritorial { get; set; }

        [Column("STATUS_SIND")]
        [Required]
        [StringLength(1)]
        [Display(Name = "Status")]
        public string StatusSindicato { get; set; }

        [Column("TIPO_DIR")]
        [StringLength(1)]
        [Display(Name = "Tipo direção")]
        public string TipoDir { get; set; }

        [Column("SIGLA")]
        [StringLength(20)]
        [Display(Name = "Sigla")]
        public string Sigla { get; set; }

        [Column("PRES")]
        [StringLength(100)]
        [Display(Name = "Presidente")]
        public string Presidente { get; set; }

        [Column("CPF_PRES")]
        [StringLength(11)]
        [Display(Name = "CPF Presidente")]
        public string CpfPresidente { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        //public virtual ICollection<BaseTerritorial> TB_BASE_TERR { get; set; }
    }
}

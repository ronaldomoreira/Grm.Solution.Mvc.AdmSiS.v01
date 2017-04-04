using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{

    [Table("TB_CTA_CORRENTE")]
    public class ContaCorrente: GrmCustomEntity
    {
        public ContaCorrente()
        {
           //Funcionarios = new HashSet<Funcionario>();
        }
        
        [Key]
        [Column("ID_CTA_CORRENTE")]
        [Display(Name = "Código")]
        public int idContaCorrente { get; set; }

        [Column("ID_AG_BANCO")]
        [Display(Name = "Agência")]
        public int IdAgenciaBanco { get; set; }
        public virtual AgenciaBanco ContaCorrenteAgenciaBanco { get; set; }

        [Column("ID_EMP_SIST")]
        [Required]
        public int IdEmpresaSistema { get; set; }

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }

        [Column("COD_OP")]
        [Display(Name = "Cód. operação")]
        [StringLength(10)]
        public string CodigoOperacao { get; set; }

        [Column("NRO_CTA")]
        [Display(Name = "Nr. conta")]
        [StringLength(20)]
        public string NroConta { get; set; }

        [Column("DV_CTA")]
        [Display(Name = "DV")]
        [StringLength(2)]
        public string  DvConta { get; set; }

        [Column("STATUS_CTA")]
        [Display(Name = "Status")]
        [Required]
        [StringLength(1)]
        public string StatusConta { get; set; }

        [Column("FLAG_CONCILIAVEL")]
        [Display(Name = "Conciliável")]
        [StringLength(1)]
        public string FlagConciliavel  { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        //public virtual EmpresaSistema ContaCorrenteEmpresaSistema { get; set; }
        //public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}

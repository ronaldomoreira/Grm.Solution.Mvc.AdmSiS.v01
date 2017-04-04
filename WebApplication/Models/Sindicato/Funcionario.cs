using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_FUNCIONARIO")]
    public class Funcionario: Pessoa
    {
        [Key]
        [Column("ID_FUNCIONARIO")]
        [Display(Name = "Código")]
        public int IdFuncionario { get; set; }
        
        [Column("ID_EMP_SIST")]
        public int? IdEmpresaSistema { get; set; }

        [Column("ID_CTA_CORRENTE")]
        [Display(Name = "C/C", Prompt = "", Description = "")]
        [ForeignKey(nameof(FuncionarioContaCorrente))]
        public int? IdContaCorrente { get; set; }
        public virtual ContaCorrente FuncionarioContaCorrente { get; set; }

        [Column("ID_CARGO")]
        [Display(Name = "Cargo", Prompt = "", Description = "")]
        [ForeignKey(nameof(FuncionarioCargo))]
        public int? IdCargo { get; set; }
        public virtual Cargo FuncionarioCargo { get; set; }

        [Column("ID_FUNCAO")]
        [Display(Name = "Função", Prompt = "", Description = "")]
        [ForeignKey(nameof(FuncionarioFuncao))]
        public int? Idfuncao { get; set; }
        public virtual Funcao FuncionarioFuncao { get; set; }

        [Column("CTPS")]
        [StringLength(20)]
        [Display(Name = "CTPS", Prompt = "", Description = "")]
        public string Ctps { get; set; }

        [Column("PIS_PASEP")]
        [StringLength(20)]
        [Display(Name = "NIS (PIS/PASEP)", Prompt = "", Description = "")]
        public string PisPasep { get; set; }

        [Column("NUN_CRACHA")]
        [StringLength(10)]
        [Display(Name = "Num. crachá", Prompt = "", Description = "")]
        public string NumCracha { get; set; }

        [Column("DT_ADMISSAO")]
        [Display(Name = "Data admissão", Prompt = "", Description = "")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataAdmissao { get; set; }

        [Column("DT_DEMISSAO")]
        [Display(Name = "Data Demissao", Prompt = "", Description = "")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataDemissao { get; set; }

        [Column("STATUS_FUNC")]
        [Required]
        [StringLength(1)]
        [Display(Name = "Status", Prompt = "", Description = "")]
        public string StatusFunc { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Observações", Prompt = "", Description = "")]
        public string Observacao { get; set; }
    }
}
 
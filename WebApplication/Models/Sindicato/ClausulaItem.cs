using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_CLA_ITEM")] 
    public class ClausulaItem: GrmCustomEntity
    {
        [Key]
        [Column("ID_CLA_ITEM")]
        [Display(Name = "Cód. Item")]
        public int IdClausulaItem { get; set; }

        [Column("ID_CLAUSULA")]
        [Display(Name = "Cláusula")]
        public int Idclausula { get; set; }
        public virtual Clausula ClausulaItemClausula { get; set; }

        [Column("ID_REGRA_CLA")]
        [Display(Name = "Regra")]
        public int IdRegraclausula { get; set; }
        public virtual Regraclausula ClausulaItemRegraclausula { get; set; }

        [Column("ID_CARGO")]
        [Display(Name = "Cargo")]
        public int IdCargo { get; set; }
        public virtual Cargo ClausulaItemCargo { get; set; }

        [Column("DT_INI")]
        [Display(Name = "Data inicial")]
        public DateTime DataIni  { get; set; }

        [Column("DT_FIM")]
        [Display(Name = "Data final")]
        public DateTime? DataFim { get; set; }

        [Column("DESCRICAO")]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("OBS")] 
        [StringLength(255)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        
        [Column("SAL_BASE_ANT", TypeName = "numeric")]
        //[DisplayFormat(DataFormatString = "{0:C0}")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [Display(Name = "Salário base anterior", Prompt = "", Description = "Salário base anterior")]
        public decimal SalBaseAnterio  { get; set; }

        [Column("VALOR_INI", TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [Display(Name = "valor inicial", Prompt = "", Description = "")]
        public decimal? ValorIni  { get; set; }

        [Column("VALOR_FIM", TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [Display(Name = "valor final", Prompt = "", Description = "")]
        public decimal? ValorFim  { get; set; }

        [Column("PERC_INI", TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [Range(0, 100, ErrorMessage = "Percentual inválido!")]
        [Display(Name = "Perc. Inicial (%)", Prompt = "Percentual inicial (%)", Description = "Percentual inicial (%)")]
        public decimal? PercentualIni  { get; set; }

        [Column("PERC_FIM", TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [Range(0, 100, ErrorMessage = "Percentual inválido!")]
        [Display(Name = "Perc. final (%)", Prompt = "Percentual final (%)", Description = "Percentual final (%)")]
        public decimal? PercentualFim { get; set; }
    }
}

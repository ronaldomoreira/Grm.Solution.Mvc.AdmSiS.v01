using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_UNIDADE")]
    public class Unidade: GrmCustomEntity 
    {
        [Key]
        [Column("ID_UNIDADE")]
        [Display(Name = "Código")]
        public int IdUnidade { get; set; }

        [Column("ID_EMP_SIST")]
        public int IdEmpresaSistema { get; set; }

        [Column("Nome")]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("SIGLA")]
        [Required]
        [StringLength(5)]
        [Display(Name = "Sigla")]
        public string Sigla  { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_FUNCAO")]
    public class Funcao: GrmCustomEntity 
    {
        public Funcao()
        {
            //Funcionarios = new HashSet<Funcionario>();
        }

        [Key]
        [Column("ID_FUNCAO")]
        [Display(Name = "Código")]
        public int IdFuncao { get; set; }

        [Column("ID_EMP_SIST")]
        public int? IdEmpresaSistema { get; set; }

        [Column("NOME_FUNCAO")]
        [Display(Name = "Nome função", Prompt = "", Description = "")]
        [StringLength(100)]
        public string NomeFuncao { get; set; }

        //public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_GRUPO_CLA")]
    public class GrupoClausula: GrmCustomEntity
    {
        public GrupoClausula()
        {
            //Clausulas = new HashSet<Clausula>();
        }

        [Key]
        [Column("ID_GRUPO_CLA")]
        [Display(Name = "Código")]
        public int IdGrupoClausula { get; set; }
        
        [Column("DESCRICAO")]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        //public virtual ICollection<Clausula> Clausulas { get; set; }
    }
}

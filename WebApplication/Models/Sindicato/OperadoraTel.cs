using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    //Operadora Telefonica
    [Table("TB_OPERADORA")]
    public class OperadoraTel: GrmCustomEntity
    {
        public OperadoraTel()
        {
            //TB_TEL_PESSOA = new HashSet<TB_TEL_PESSOA>();
        }

        [Key]
        [Column("ID_OPERADORA")]
        [Display(Name = "Código")]
        public int IdOperadoraTel { get; set; }

        [Column("NOM_OPE")]
        [StringLength(100)]
        [Display(Name = "Nome operadora")]
        public string NomeOperadoraTel { get; set; }
    }
}

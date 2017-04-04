using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_CLAUSULA")]
    public class Clausula: GrmCustomEntity
    {
        public Clausula()
        {
            // item clausula
            //ClausulaItens = new HashSet<ClausulaItem>();

            // orintacao clausula
            //OrientacaoClausulas = new HashSet<OrientacaoClausula>();
        }

        [Key]
        [Column("ID_CLAUSULA")]
        [Display(Name = "Código")]
        public int IdClausula { get; set; }

        [Column("ID_GRUPO_CLA")]
        [Display(Name = "Grupo")]
        public int IdGrupoClausula { get; set; }
        public virtual GrupoClausula ClausulaGrupoClausula { get; set; }

        [Column("ID_ACORDO_SIND")]
        [Display(Name = "Acordo")]
        public int IdAcordoSindical { get; set; }
        public virtual AcordoSindical ClausulaAcordoSindical { get; set; }

        [Column("DT_INI")]
        [Display(Name = "Data inicio")]
        public DateTime? DataIni { get; set; }

        [Column("DT_FIM")]
        [Display(Name = "Data fim")]
        public DateTime? DataFim { get; set; }

        [Column("TEXTO")]
        [StringLength(1024)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Texto da Cláusula")]
        public string Texto { get; set; }
        
        //public virtual ICollection<ClausulaItem> ClausulaItens { get; set; }
        //public virtual ICollection<OrientacaoClausula> OrientacaoClausulas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_UF")]
    public class Uf: GrmCustomEntity
    {
        public Uf()
        {
            //TB_ACORDO_SIND = new HashSet<TB_ACORDO_SIND>();
            //Enderecos    = new HashSet<Endereco>();
            //Municipios   = new HashSet<Municipio>();
        }

        [Key]
        [Column("ID_UF")]
        [Display(Name = "Código")]
        public int IdUf { get; set; }

        [Column("ID_PAIS")]
        //[ForeignKey(nameof(UfPais))]
        [Display(Name = "País")]
        public int IdPais { get; set; }
        //public virtual Pais UfPais { get; set; }
        
        [Column("COD_IBGE")]
        [StringLength(5)]
        [Display(Name = "Cód. IBGE")]
        public string CodIbge { get; set; }

        [Column("SIGLA")]
        [StringLength(2)]
        [Display(Name = "Sigla")]
        public string Sigla { get; set; }

        [Column("NOME_UF")]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string NomeUf { get; set; }

        //public virtual ICollection<Municipio> Municipios { get; set; }
    }
}

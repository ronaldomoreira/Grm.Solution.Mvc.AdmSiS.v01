using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_MUNICIPIO")]
    public class Municipio: GrmCustomEntity 
    {
        public Municipio()
        {
            //
        }

        [Key]
        [Column("ID_MUNICIPIO")]
        [Display(Name = "Código")]
        public int IdMunicipio { get; set; }

        [Column("ID_UF")]
        [ForeignKey(nameof(MunicipioUf))]
        [Display(Name = "Estado")]
        public int IdUf { get; set; }
        public virtual Uf MunicipioUf { get; set; }

        [Column("COD_IBGE")]
        [StringLength(10)]
        [Display(Name = "Cód. IBGE")]
        public string CodIbge { get; set; }

        [Column("NOME_MUN")]
        [StringLength(100)]
        [Display(Name = "Nome município")]
        public string NomeMunicipio { get; set; }
    }
}

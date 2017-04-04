using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_PAIS")]
    public class Pais: GrmCustomEntity 
    {
        public Pais()
        {
            //Enderecos = new HashSet<Endereco>();
        }

        [Key]
        [Column("ID_PAIS")]
        [Display(Name = "Código")]
        public int IdPais { get; set; }

        [Column("COD_IBGE")]
        [StringLength(10)]
        [Display(Name = "Cód. IBGE")]
        public string CodIbge { get; set; }

        [Column("SIGLA_PAIS")]
        [StringLength(5)]
        [Display(Name = "Sigla")]
        public string SiglaPais { get; set; }

        [Column("NOME_PAIS")]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string NomePais { get; set; }
    }
}

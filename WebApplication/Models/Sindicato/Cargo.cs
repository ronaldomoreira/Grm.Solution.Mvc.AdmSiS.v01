using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_CARGO")]
    public class Cargo: GrmCustomEntity
    {
        public Cargo()
        {
            //CargosPai = new HashSet<Cargo>();
        }

        [Key]
        [Column("ID_CARGO")]
        [Display(Name = "Código")]
        public int IdCargo { get; set; }

        [Column("ID_CARGO_PAI")]
        [ForeignKey(nameof(CargoCargoPai))]
        [Display(Name = "Cargo pai")]
        public int? IdCargoPai { get; set; }
        public virtual Cargo CargoCargoPai { get; set; }

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao{ get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }
    
        [Column("COD_CBO")]
        [StringLength(15)]
        [Display(Name = "Cód. CBO")]
        public string CodigoCBO { get; set; }

        [Column("NOME_CARGO")]
        [StringLength(100)]
        [Display(Name = "Nome cargo")]
        public string NomeCargo { get; set; }

        //public virtual ICollection<Cargo> CargosPai { get; set; }
    }
}

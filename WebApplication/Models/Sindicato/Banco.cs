using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_BANCO")]
    public partial class Banco: GrmCustomEntity
    {
        public Banco()
        {
            //this.AgenciaBancos = new HashSet<AgenciaBanco>();
        }

        [Key]
        [Column("ID_BANCO")]
        [Display(Name = "Código")]
        public int IdBanco  { get; set; }

        [Column("ID_EMP_SIST")]
        public int IdEmpresaSistema { get; set; }

        [Column("NUM_BANCO")]
        [Display(Name = "Nr. banco")]
        [StringLength(10)]
        public string NumBanco { get; set; }

        [Column("NOME_CURTO")]
        [StringLength(50)]
        [Display(Name = "Nome curto")]
        public string NomeCurto { get; set; }

        [Column("NOME")]
        [StringLength(100)]
        [Display(Name = "Nome banco")]
        public string Nome { get; set; }

        [Column("STATUS_BANCO")]
        [StringLength(1)]
        [Display(Name = "Status")]
        public string StatusBanco { get; set; }

        //public virtual ICollection<AgenciaBanco> AgenciaBancos { get; set; }

    }
}

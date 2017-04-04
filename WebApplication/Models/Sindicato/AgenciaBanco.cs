using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_AG_BANCO")]
    public class AgenciaBanco: GrmCustomEntity
    {
        public AgenciaBanco()
        {
            //ContaCorrentes = new HashSet<ContaCorrente>();
        }

        [Key]
        [Column("ID_AG_BANCO")]
        [Display(Name = "Cod. acordo")]
        public int IdAgenciaBanco{ get; set; }

        [Column("ID_EMP_SIST")]
        public int IdEmpresaSistema { get; set; }

        // Bano
        [Column("ID_BANCO")]
        public int IdBanco { get; set; }
        public virtual Banco AgenciaBancoBanco { get; set; }

        [Display(Name = "Ag. Número")]
        [Column("NRO_AGENCIA")]
        [StringLength(20)]
        public string NroAgencia { get; set; }

        [Column("DV_AGENCIA")]
        [StringLength(2)]
        [Display(Name = "Dv")]
        public string DvAgencia { get; set; }

        [Column("GERENTE")]
        [StringLength(100)]
        [Display(Name = "Gerente")]
        public string Gerente { get; set; }

        [Column("GERENTE_REL")]
        [StringLength(100)]
        [Display(Name = "Gerente de Relacionamento")]
        public string GerenteRelacionamento { get; set; }

        [Column("STATUS_AG_BANCO")]
        [Required]
        [StringLength(1)]
        [Display(Name = "Status")]
        public string StatusAgenciaBanco { get; set; }

        //public virtual ICollection<ContaCorrente> ContaCorrentes { get; set; }
    }
}

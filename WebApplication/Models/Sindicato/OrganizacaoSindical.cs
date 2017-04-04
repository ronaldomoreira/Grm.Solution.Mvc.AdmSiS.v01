using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_ORG_SIND")]
    public class OrganizacaoSindical: GrmCustomEntity
    {
        public OrganizacaoSindical()
        {
            //this.ConfederaaoSindicais = new HashSet<OrganizacaoSindical>();
            //this.TB_SIND  = new HashSet<TB_SIND>();
            //this.TB_SIND1 = new HashSet<TB_SIND>();
            //this.TB_SIND2 = new HashSet<TB_SIND>();
        }

        [Key]
        [Column("ID_ORG_SIND")]
        [Display(Name = "Código")]
        public int IdOrganizacaoSindical { get; set; }

        [Column("ID_CONF_SIND")]
        [ForeignKey(nameof(OrganizacaoSindicalConfederacaoSindical))]
        [Display(Name = "Conferedeção sindical")]
        public int? ConfederacaoSindical { get; set; }
        public virtual OrganizacaoSindical OrganizacaoSindicalConfederacaoSindical { get; set; }
        
        [Column("SIGLA")]
        [StringLength(20)]
        [Display(Name = "Sigla")]
        public string Sigla { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("RAZAO_SOCIAL")]
        [Display(Name = "Razão Social")]
        [StringLength(100)]
        public string RazaoSocial { get; set; }

        [Column("TIPO")]
        [Display(Name = "Tipo")]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Column("DT_NASC")]
        [Display(Name = "Data Fundação")]
        public DateTime? DataNasc  { get; set; }

        [Column("CNPJ")]
        [StringLength(15)]
        [Display(Name = "CNPJ")]
        public string Cnpj  { get; set; }

        [Column("STATUS_ORG")]
        [StringLength(1)]
        [Display(Name = "Status")]
        public string StatusOrg { get; set; }

        [Column("NOME_CONTATO")]
        [StringLength(100)]
        [Display(Name = "Contato")]
        public string NomeContato { get; set; }

        [Column("DDD_TEL")]
        [StringLength(2)]
        [Display(Name = "Código")]
        public string DDDTel { get; set; }

        [Column("TELEFONE")]
        [StringLength(15)]
        [Display(Name = "Código")]
        public string Telefone { get; set; }

        [Column("EMAIL")]
        [StringLength(100)]
        [Display(Name = "Código")]
        public string Email { get; set; }

        [Column("SITE")]
        [StringLength(100)]
        [Url(ErrorMessage = "Entre com um endereço web válido!")]
        [Display(Name = "Site")]
        public string Site { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        //public virtual ICollection<OrganizacaoSindical> ConfederaaoSindicais { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND1 { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND2 { get; set; }
    }
}

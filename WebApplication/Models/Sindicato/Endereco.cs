using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_ENDERECO")]
    public class Endereco: GrmCustomEntity
    {
        public Endereco()
        {
            //PessoaEnderecos = new HashSet<PessoaEndereco>();
            //Sindicatos      = new HashSet<Sindicato>();
        }
        
        [Key]
        [Column("ID_ENDERECO")]
        [Display(Name = "Código")]
        public int IdEndereco { get; set; }

        [Column("ID_PAIS")]
        [ForeignKey(nameof(EnderecoPais))]
        [Display(Name = "País")]
        public int? IdPais { get; set; }
        public virtual Pais EnderecoPais { get; set; }

        [Column("ID_UF")]
        [ForeignKey(nameof(EnderecoUf))]
        [Display(Name = "Estado")]
        public int? IdUf { get; set; }
        public virtual Uf EnderecoUf { get; set; }

        [Column("ID_MUNICIPIO")]
        [ForeignKey(nameof(EnderecoMunicipio))]
        [Display(Name = "Município")]
        public int? IdMunicipio { get; set; }
        public virtual Municipio EnderecoMunicipio { get; set; }

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }

        [Column("TIPO_END")]
        [Required]
        [StringLength(1)]
        [Display(Name = "Tipo endereço")]
        public string TipoEndereco { get; set; }

        [Column("TIPO_LOG")]
        [StringLength(10)]
        [Display(Name = "Tipo logradouro")]
        public string TipoLogradouro { get; set; }     //tipo logradouro

        [Column("LOGRADOURO")]
        [StringLength(100)]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Column("NUMERO")]
        [StringLength(10)]
        [Display(Name = "Num.")]
        public string Numero { get; set; }

        [Column("COMPLEMENTO")]
        [StringLength(20)]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Column("BAIRRO")]
        [StringLength(100)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Column("CEP")]
        [StringLength(10)]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Column("COD_POSTAL_EXT")]
        [StringLength(32)]
        [Display(Name = "Caixa postal")]
        public string CodPostalExterior { get; set; }

        [Column("ENDERECO_EXT")]
        [StringLength(100)]
        [Display(Name = "Endereço exterior")]
        public string EnderecoExterior { get; set; }

        [Column("COMPLEMENTO_EXT")]
        [StringLength(255)]
        [Display(Name = "Complemento")]
        public string ComplementoExterior { get; set; }

        [Column("CIDADE_EXT")]
        [StringLength(100)]
        [Display(Name = "Cidade exterior")]
        public string CidadeExterior { get; set; }

        [Column("ESTADO_EXT")]
        [StringLength(100)]
        [Display(Name = "Estado exterior")]
        public string EstadoExterior { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        public string Observacao { get; set; }

        //public virtual ICollection<PessoaEndereco> PessoaEnderecos { get; set; }
        //public virtual ICollection<Sindicato> Sindicatos { get; set; }
    }
}

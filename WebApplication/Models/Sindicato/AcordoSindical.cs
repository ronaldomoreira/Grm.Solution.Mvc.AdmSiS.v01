using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GrmWebAppAdmSiSv01.Models.Sindicato.GrmEntity;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{
    [Table("TB_ACORDO_SIND")]
    public class AcordoSindical: GrmCustomEntity
    {
        public AcordoSindical()
        {
            //this.Clausulas = new HashSet<Clausula>();
        }

        [Key]
        [Column("ID_ACORDO_SIND")]
        [Display(Name = "Cod. acordo")]
        public int IdAcondoSindial { get; set; }

        // Sindicato Patronal
        [Column("ID_SIND_PAT")]
        [ForeignKey(nameof(SindicatoPatronal))]
        [Required(ErrorMessage = "Sindicato patronal é obrigatório")]
        [Display(Name = "Sindicato patronal", Prompt = "Selecione o sindicato patronal", Description = "Selecione o sindicato patronal")]
        public int IdSindicatoPatronal { get; set; }
        public virtual Sindicato SindicatoPatronal { get; set; }

        // Sindicato Laboral
        [Column("ID_SIND_LAB")]
        [ForeignKey(nameof(SindicatoLaboral))]
        [Required(ErrorMessage = "Sindicato laboral é obrigatório")]
        [Display(Name = "Sindicato laboral", Prompt = "Selecione o sindicato laboral", Description = "Selecione o sindicato laboral")]
        public int IdSindicatoLaboral { get; set; }
        public virtual Sindicato SindicatoLaboral { get; set; }

        //Municipio
        [Column("ID_MUNICIPIO")]
        [ForeignKey(nameof(AcordoSindicalMunicipio))]
        [Required(ErrorMessage = "Município é obrigatório")]
        [Display(Name = "Município")]
        public int IdMunicipio { get; set; }
        public virtual Municipio AcordoSindicalMunicipio { get; set; }

        //Uf
        [Column("ID_UF")]
        [ForeignKey(nameof(AcordoSindicalUf))]
        [Required(ErrorMessage = "Estado é obrigatório")]
        [Display(Name = "Estado")]
        public int IdUf { get; set; }
        public virtual Uf AcordoSindicalUf { get; set; }

        //TipoAcordo
        [Column("ID_TIPO_ACORDO")]
        [ForeignKey(nameof(AcordoSindicalTipoAcordo))]
        [Required(ErrorMessage = "Tipo de Acordo é obrigatório")]
        [Display(Name = "Tipo acordo")]
        public int IdTipoAcordo { get; set; }
        public virtual TipoAcordo AcordoSindicalTipoAcordo { get; set; }

        [Column("MES_DT_BASE")]
        [Range(1, 12, ErrorMessage = "Mes deve ser ente 01 e 12")]
        [Display(Name = "Mes Base", Prompt = "Mes Data Base", Description = "Mes Data Base")]
        public int MesDataBase { get; set; }

        [Column("ANO_DT_BASE")]
        [Range(1900, 2030, ErrorMessage = "Ano inválido")]
        [Display(Name = "Ano Base", Prompt = "Ano Data Base", Description = "Ano Data Base")]
        public int AnoDataBase { get; set; }

        [Column("DT_INI")]
        [Required(ErrorMessage = "Data Inicio é obrigatório")]
        [Display(Name = "Dt. Inicio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataInicio { get; set; }

        [Column("DT_FIM")]
        [Display(Name = "Dt. Inicio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataFim { get; set; }

        [Column("OBS")]
        [StringLength(1024)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        //public virtual ICollection<Clausula> Clausulas { get; set; }
    }
}




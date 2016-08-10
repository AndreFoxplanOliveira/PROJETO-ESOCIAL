using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Web.Security;
using MySql.Data.Entity;
using System.Data.Entity;
using System.Data.Common;

namespace Portal.Business.Models
{

    [Table("time")]
    public class Time
    {
        [Key]
        public Int32 id_time { get; set; }
           
        [Required]     
        public DateTime dh_cad_time { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Nome Completo inv�lido.")]
        public string nome_time_completo { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Nome inv�lido.")]
        public string nome_time { get; set; }

        [Display(Name = "Descri��o")]
        public string descricao_time { get; set; }

        [Required(ErrorMessage = "Escudo inv�lido.")]
        [Display(Name = "Escudo")]
        public string escudo_time { get; set; }

        [Required(ErrorMessage = "Status do Time inv�lido.")]
        [Display(Name = "Status do Time")]
        public bool ativo_time { get; set; }

        [Display(Name = "Data da Funda��o")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", NullDisplayText="N�o dispon�vel")]
        [DataType(DataType.Date)]
        public Nullable<DateTime> d_fundacao_time { get; set; }

        [Display(Name = "Mascote")]
        public string nome_mascote_time { get; set; }

        [Display(Name = "Foto")]
        public string foto_mascote_time { get; set; }

        [Required(ErrorMessage = "Cidade inv�lido.")]
        [Display(Name = "Cidade")]
        public string cidade_time { get; set; }

        [Required(ErrorMessage = "Estado inv�lido.")]
        [Display(Name = "Estado")]
        public string uf_time { get; set; }        

    }
}
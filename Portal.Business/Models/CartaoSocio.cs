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

    [Table("cartao_socio")]
    public class CartaoSocio
    {
        [Key]
        public int id_cartao_socio { get; set; }

        [Required]
        public Int32 id_usuario { get; set; }

        [Required]
        public Int32 id_time { get; set; }

        [Required]
        public DateTime dh_cad_cartao_socio { get; set; }

        [Required(ErrorMessage = "N�mero do Cart�o inv�lido.")]
        [Display(Name = "N�mero do Cart�o")]
        public string numero_cartao_socio { get; set; }

        [Required(ErrorMessage = "Modalidade do Cart�o inv�lida.")]
        [Display(Name = "Modalidade do Cart�o")]
        public string modalidade_cartao_socio { get; set; }

        [Display(Name = "Setor do Cart�o")]
        public string setor_cartao_socio { get; set; }

        [Display(Name = "Observa��o")]
        public string obs_cartao_socio { get; set; }

        [Required(ErrorMessage = "Status do Cart�o inv�lido.")]
        [Display(Name = "Status do Cart�o")]
        public bool ativo_cartao_socio { get; set; }        

    }
}
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

    [Table("anuncio")]
    public class Anuncio
    {
        public enum TypeStatusAnuncio { Disponivel, Bloqueado, Reservado, Finalizado }

        [Key]
        public Int64 id_anuncio { get; set; }

        [Required]        
        public Int32 id_usuario { get; set; }

        public Nullable<Int32> id_usuario_comprador { get; set; }

        [Required]        
        public Int32 id_time { get; set; }

        [Required]        
        public Int32 id_cartao_socio { get; set; }

        [Required]  
        public DateTime dh_cadastro_anuncio { get; set; }

        [Required(ErrorMessage = "Data do Jogo inv�lida.")]
        [Display(Name = "Data do Jogo")]        
        public DateTime d_jogo { get; set; }

        [Required(ErrorMessage = "Descri��o do An�ncio.")]
        [Display(Name = "Descri��o do An�ncio")]
        public string descricao_anuncio { get; set; }

        [Display(Name = "Valor do An�ncio")]
        public Decimal valor_anuncio { get; set; }

        [Display(Name = "Cobra Cau��o")]        
        public bool cobra_caucao_anuncio { get; set; }

        [Display(Name = "Valor do Cau��o")]        
        public Decimal valor_caucao_anuncio { get; set; }

        [Required(ErrorMessage = "Status do An�ncio inv�lido.")]
        [Display(Name = "Status do An�ncio")]        
        public TypeStatusAnuncio status_anuncio { get; set; }

        [Display(Name = "Publicar An�ncio")]
        public bool publicado_anuncio { get; set; }
        
        [Display(Name = "Motivo de Bloqueio")]
        public string motivo_bloqueio_anuncio { get; set; }

        [Display(Name = "Informa��es Adicionais Vendedor")]
        public string informacao_entrega_vendedor_anuncio { get; set; }

        [Display(Name = "Informa��es Adicionais Comprador")]
        public string informacao_entrega_comprador_anuncio { get; set; }

        public Nullable<DateTime> dh_compra_anuncio { get; set; }
    }
}
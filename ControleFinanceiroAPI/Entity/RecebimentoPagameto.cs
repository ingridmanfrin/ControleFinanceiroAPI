
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiroAPI.Entity
{
    [Table("RECEBIMENTOS_PAGAMENTOS")]
    public class RecebimentoPagameto
    {
        [Column("id_recebimentos_pagamentos")]
        [Key]
        public int Id { get; set; }

        [Column("id_usuario")]
        public int UsuarioId { get; set; }

        [Column("id_categoria_despesa")]
        public int CategoriaDespesaId { get; set; }

        [Column("id_conta")]
        public int ContaId { get; set; }

        [Column("valor")]
        public decimal Valor { get; set; }

        [Column("valor_liquidado")]
        public decimal ValorLiquidado { get; set; }

        [Column("descricao")]
        public string? Descricao { get; set; }

        [Column("data_operacao")]
        public DateTime DataOperacao { get; set; }

        [Column("data_criacao")]
        public DateTime DataCriacao { get; set; }

        [Column("data_alteracao")]
        public DateTime DataAlteracao { get; set; }

        [Column("usuario_criacao")]
        public string UsuarioCriacao { get; set; }

        [Column("usuario_alteracao")]
        public string UsuarioAlteracao { get; set; }


    }
}

namespace ControleFinanceiroAPI.Models
{
    public class RecebimentosPagamentosViewModel
    {
        public int IdCategoriaDespesa { get; set; }
        public int IdConta { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorLiquidado { get; set; }
        public DateTime DataOperacao { get; set; }
    }
}

using ControleFinanceiroAPI.Entity;
using ControleFinanceiroAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ControleFinanceiroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecebimentoPagamentoController : ControllerBase
    {
        private AppDbContext _context;
        private string _usuarioNome = "teste";
        private int _usuarioId = 1;
        public RecebimentoPagamentoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CadastrarRecimentoPagamento(RecebimentosPagamentosViewModel entradaDado)
        {

            var databaseItem = new RecebimentoPagameto()
            {
                ContaId = entradaDado.IdConta,
                DataOperacao = entradaDado.DataOperacao,
                Valor = entradaDado.Valor,
                ValorLiquidado = entradaDado.ValorLiquidado,
                UsuarioCriacao = _usuarioNome,
                UsuarioAlteracao = _usuarioNome,
                UsuarioId = _usuarioId,
                CategoriaDespesaId = entradaDado.IdCategoriaDespesa,
                Descricao = entradaDado.Descricao,
                DataAlteracao = DateTime.Now,
                DataCriacao = DateTime.Now
            };

            _context.RecebimentosPagamentos.Add(databaseItem);
            _context.SaveChanges();

            return Ok(databaseItem);
        }

        [HttpGet]
        public IActionResult RecuperarRecimentoPagamentoLista()
        {
            var databaseLista = _context.RecebimentosPagamentos.OrderByDescending(x => x.Id).Take(10).ToList(); //ToList gera a lista, como?

            return Ok(databaseLista);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Models;
using MinhaPrimeiraApi.Data;
using Microsoft.EntityFrameworkCore;

namespace MinhaPrimeiraApi.Controllers {

    [ApiController]
    [Route("api/[controller]")]

    public class ProdutosController : ControllerBase {

        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos() {

            var Produtos = await _context.Produtos.ToListAsync();
            return Ok(Produtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId(int id) {

            if (id <= 0) {
                return BadRequest("O id deve ser maior que zero.");
            }

            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null) {
                return NotFound($"Produto com ID {id} não encontrado.");
            }

            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] Produto produto) {

            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return Ok($"Produto '{produto.Nome}' criado com sucesso!");
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(int id, [FromBody] Produto produtoAtualizado) {

            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null) {
                return NotFound($"Produto com ID {id} não encontrado.");
            }

            produto.Nome = produtoAtualizado.Nome;
            produto.Preco = produtoAtualizado.Preco;

            await _context.SaveChangesAsync();

            return Ok($"Produto '{produto.Nome}' atualizado com sucesso!");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Deletar(int id) {

            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null) {
                return NotFound($"Produto com ID {id} não encontrado.");
            }

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return Ok($"Produto '{produto.Nome}' deletado com sucesso!");
        }
    }
}

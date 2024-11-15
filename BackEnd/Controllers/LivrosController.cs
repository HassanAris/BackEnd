using   Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using BackEnd.Models;
using AutoMapper;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivroService _livroService;
        private readonly IMapper _mapper;

        public LivrosController(LivroService livroService, IMapper mapper)
        {
            _mapper = mapper;
            _livroService = livroService;
        }


        [HttpGet("")]
        public async Task<IActionResult> GetLivros()
        {
            var livros = await _livroService.GetLivros();
            return Ok(livros);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLivroPorId(int id)
        {
            var livro = await _livroService.GetById(id);

            if (livro == null) return NotFound();

            var livroDTO = _mapper.Map<LivroDTO>(livro);
            return Ok(livroDTO);
        }

        [HttpPost("")]
        public async Task<IActionResult> AdicionarLivro(Livro livro)
        {
            var novoLivro = await _livroService.Adicionar(livro);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarLivro([FromBody] Livro livro)
        {
            await _livroService.Atualizar(livro);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletaLivro(int id)
        {
            await _livroService.Delete(id);
            return NoContent();
        }
    }
}



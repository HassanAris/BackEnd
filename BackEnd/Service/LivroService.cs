using BackEnd.Models;
using EventosAPI.Models;

public class LivroService
{
    private readonly ILivroRepository _livroRepository;

    public LivroService(ILivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    public async Task<Livro> Adicionar(Livro livro)
    {
        return await _livroRepository.Adiciona(livro);
    }

    public async Task<IEnumerable<Livro>> GetLivros()
    {
        return await _livroRepository.GetLivros();
    }

    public async Task<Livro> GetById(int id)
    {
        return await _livroRepository.GetById(id);
    }

    public async Task Atualizar(Livro evento)
    {
        await _livroRepository.Atualiza(evento);
    }

    public async Task Delete(int id)
    {
        await _livroRepository.Delete(id);
    }
}

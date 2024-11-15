using BackEnd.Models;
using EventosAPI.Models;

public interface ILivroRepository
{
    Task<IEnumerable<Livro>> GetLivros();
    Task<Livro> GetById(int id);
    Task<Livro> Adiciona(Livro livro);
    Task Atualiza(Livro evento);
    Task Delete(int id);
}

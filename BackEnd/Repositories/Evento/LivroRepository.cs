using BackEnd.Models;
using EventosAPI.Models;
using Microsoft.EntityFrameworkCore;

public class LivroRepository : ILivroRepository
{
    private readonly ApplicationDbContext _context;

    public LivroRepository(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Livro>> GetLivros()
    {
        return await _context.Livro.ToListAsync();
    }

    public async Task<Livro> GetById(int id)
    {
        return await _context.Livro.FindAsync(id);
    }

    public async Task<Livro> Adiciona(Livro livro)
    {
        _context.Livro.Add(livro);
        await _context.SaveChangesAsync();
        return livro;
    }

    public async Task Atualiza(Livro livro)
    {
        _context.Livro.Update(livro);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var evento = await _context.Livro.FindAsync(id);
        if (evento != null)
        {
            _context.Livro.Remove(evento);
            await _context.SaveChangesAsync();
        }
    }


}

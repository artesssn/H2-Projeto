using Microsoft.EntityFrameworkCore;

public class CursoRepository : ICursoRepository
{
    private readonly AppDbContext _context;

    public CursoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Curso>> GetAll()
    {
        return await _context.Cursos.ToListAsync();
    }

    public async Task<Curso> GetById(int id)
    {
        return await _context.Cursos.FindAsync(id);
    }

    public async Task<Curso> Add(Curso curso)
    {
        _context.Cursos.Add(curso);
        await _context.SaveChangesAsync();
        return curso;
    }

    public async Task<Curso> Update(Curso curso)
    {
        _context.Cursos.Update(curso);
        await _context.SaveChangesAsync();
        return curso;
    }

    public async Task<bool> Delete(int id)
    {
        var curso = await _context.Cursos.FindAsync(id);
        if (curso == null) return false;

        _context.Cursos.Remove(curso);
        await _context.SaveChangesAsync();
        return true;
    }
}
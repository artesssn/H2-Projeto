public class CursoService : ICursoService
{
    private readonly AppDbContext _context;

    public CursoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Curso>> GetAll()
        => await _context.Cursos.ToListAsync();

    public async Task<Curso> GetById(int id)
        => await _context.Cursos.FindAsync(id);

    public async Task<Curso> Add(CursoDTO dto)
    {
        var curso = new Curso
        {
            Nome = dto.Nome,
            CargaHoraria = dto.CargaHoraria
        };

        _context.Cursos.Add(curso);
        await _context.SaveChangesAsync();
        return curso;
    }

    public async Task<Curso> Update(int id, CursoDTO dto)
    {
        var curso = await _context.Cursos.FindAsync(id);
        if (curso == null) return null;

        curso.Nome = dto.Nome;
        curso.CargaHoraria = dto.CargaHoraria;

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
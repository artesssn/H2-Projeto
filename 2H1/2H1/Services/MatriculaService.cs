public class MatriculaService : IMatriculaService
{
    private readonly AppDbContext _context;

    public MatriculaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Matricula>> GetAll()
        => await _context.Matriculas.Include(m => m.Curso).ToListAsync();

    public async Task<Matricula> Add(MatriculaDTO dto)
    {
        var matricula = new Matricula
        {
            IdCurso = dto.IdCurso,
            NomeAluno = dto.NomeAluno
        };

        _context.Matriculas.Add(matricula);
        await _context.SaveChangesAsync();

        return matricula;
    }
}
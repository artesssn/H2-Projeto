public interface ICursoService
{
    Task<IEnumerable<Curso>> GetAll();
    Task<Curso> GetById(int id);
    Task<Curso> Add(CursoDTO dto);
    Task<Curso> Update(int id, CursoDTO dto);
    Task<bool> Delete(int id);
}
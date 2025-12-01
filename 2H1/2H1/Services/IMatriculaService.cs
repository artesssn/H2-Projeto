public interface IMatriculaService
{
    Task<IEnumerable<Matricula>> GetAll();
    Task<Matricula> Add(MatriculaDTO dto);
}
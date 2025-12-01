public class Matricula
{
    public int Id { get; set; }
    public int IdCurso { get; set; }
    public string NomeAluno { get; set; }

    public Curso Curso { get; set; }
}
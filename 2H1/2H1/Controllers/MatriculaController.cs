using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MatriculaController : ControllerBase
{
    private readonly IMatriculaService _service;

    public MatriculaController(IMatriculaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAll());

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] MatriculaDTO dto)
        => Ok(await _service.Add(dto));
}
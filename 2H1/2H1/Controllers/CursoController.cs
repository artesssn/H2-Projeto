using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CursoController : ControllerBase
{
    private readonly ICursoService _service;

    public CursoController(ICursoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAll());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
        => Ok(await _service.GetById(id));

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CursoDTO dto)
        => Ok(await _service.Add(dto));

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] CursoDTO dto)
        => Ok(await _service.Update(id, dto));

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(await _service.Delete(id));
}
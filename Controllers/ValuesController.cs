using ApiPeliculas.Repositorio.IRepositorio;
using ApiPeliculas.Modelos.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPeliculas.Controllers;
//[Route("api/[controller]")] -- Una opción
[Route("api/categorias")] // otra opción
[ApiController]
public class ValuesController : ControllerBase {

    private readonly ICategoriaRepositorio _ctRepo;
    private readonly IMapper _mapper;

    public ValuesController(ICategoriaRepositorio ctRepo, IMapper mapper)
    {
        _ctRepo = ctRepo;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetCategorias() {
        var listaCategorias = _ctRepo.GetCategorias();
        var listaCategoriasDto = new List<CategoriaDto>();

        foreach(var categoria in listaCategorias) {
            listaCategoriasDto.Add(_mapper.Map<CategoriaDto>(categoria));
        }

        return Ok(listaCategoriasDto);

    }

}

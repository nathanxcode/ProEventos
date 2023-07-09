using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public EventoController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    /* Resolver isso
    public string Post( [FromQuery]Evento request, ApplicationDbContext context){
        
        var obj = new Evento(){

            EventoId = request.EventoId,
            CapacidadeEvento = request.CapacidadeEvento,
            Name = request.Name,
            Palestrante = request.Palestrante,
        };

        context.Add(obj);
        context.SaveChanges();

        return "ok";

    }
    */

}

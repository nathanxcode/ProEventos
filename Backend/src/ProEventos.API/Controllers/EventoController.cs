using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento[] {

        new Evento() {
            EventoId = 1,
            Name = "ChatGPT 4",
            CapacidadeEvento = 150,
            Palestrante = "Nathan"
        },
        new Evento() {
            EventoId = 2,
            Name = "Perigo das IA's",
            CapacidadeEvento = 1500,
            Palestrante = "Nathan"
        }


    };

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    public string Post(){
        return "post method";
    }

}

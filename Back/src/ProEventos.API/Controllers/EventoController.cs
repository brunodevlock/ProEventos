using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       
        public EventoController()
        {
           
        } 

        public IEnumerable<Evento> _evento = new Evento[] {

            new Evento() {
                EventoId = 1,
                Tema = "Aula 1",
                Local = "online",
                Lote = "1",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            },

            new Evento() {
                EventoId = 2,
                Tema = "Aula 2",
                Local = "online",
                Lote = "1",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto2.png"
            }


        };

        
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByid(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

    }

    
}

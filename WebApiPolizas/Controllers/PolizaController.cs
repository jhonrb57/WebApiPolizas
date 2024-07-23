using WebApiPolizas.Data;
using WebApiPolizas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApiPolizas.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PolizaController : ControllerBase
    {
        private readonly Conexion conexionBd = new Conexion();

        // GET: api/<PolizaController>
        [HttpGet]
        public List<Poliza> Get()
        {
            return PolizaData.Listar(conexionBd);
        }

        // GET api/<PolizaController>/5
        [HttpGet("{id}")]
        public Poliza Get(int id)
        {
            return PolizaData.Obtener(conexionBd, id);
        }

        // POST api/<PolizaController>
        [HttpPost]
        public bool Post([FromBody] Poliza poliza)
        {
            return PolizaData.Registrar(conexionBd,poliza);
        }

        // PUT api/<PolizaController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Poliza poliza)
        {
            return PolizaData.Modificar(conexionBd, poliza);
        }

        // DELETE api/<PolizaController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return PolizaData.Eliminar(conexionBd,id);
        }
    }
}

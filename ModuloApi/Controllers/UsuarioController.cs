using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {   
        [HttpGet("ObterDataHora")]
        public IActionResult ObterDataHora(){
            var obj = new{
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortDateString()
            };

            return Ok(obj);
        }

        [HttpGet("RetornaOla")]
        public IActionResult Ola(){
            var obj = "Ola mundo";

            return Ok(obj);
        }
        

        [HttpGet("Apresentar/{Nome}")]
        public IActionResult Apresentar(string Nome){
            
            var mensagem = $"Olá {Nome.ToUpper()}, seja bem vindo";

            return Ok(mensagem);
        }
    }
}
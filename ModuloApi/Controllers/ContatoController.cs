using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloApi.Context;
using ModuloApi.Entities;

namespace ModuloApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context){
            _context = context;
        }

        //Cria um novo contato
        [HttpPost]
        public IActionResult Create(Contato contato){
            
            _context.Add(contato);
            _context.SaveChanges();
            
            return CreatedAtAction(nameof(ObterPorID), new { id = contato.Id }, contato);

        }

        //Pesquisa um contato usando um id
        [HttpGet("{id}")]
        public IActionResult ObterPorID(int id){
            var contato = _context.Contatos.Find(id);

            if(contato == null)
                return NotFound();

            return Ok(contato);
        }

        //Retorna por nome
        [HttpGet("ObertPorNome")]
        public IActionResult ObterPorNome(string nome){

            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        //Atualiza um contato, usa o id para procuralo
        [HttpPost("Id")]
        public IActionResult Atualizar(int id, Contato contato){
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;
            
            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            
            return Ok(contatoBanco);

        }


        //Remove um contato por Id
        [HttpDelete("Id")]
        public IActionResult Deletar(int id){
            
            var contatoBanco = _context.Contatos.Find(id);
            
            if(contatoBanco == null)
                return NotFound();
            
            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            
            
            return NoContent();
        }

    }
}
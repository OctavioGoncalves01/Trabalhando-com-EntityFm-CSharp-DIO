using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloApi.Entities;

namespace ModuloApi.Context
{
    public class AgendaContext : DbContext
    {

        //Faz o contato com o banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){

        }

        //Esta referenciando a classe contatos em Entitis
        public DbSet<Contato> Contatos {get; set;}
    }
}
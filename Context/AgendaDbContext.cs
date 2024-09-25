using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloApi.Entities;

namespace ModuloApi.Context
{
  public class AgendaDbContext : DbContext
  {
    public AgendaDbContext(DbContextOptions<AgendaDbContext> options) : base(options)
    {
      
    }

    public DbSet<Contato> Contatos { get; set; }
  }
}
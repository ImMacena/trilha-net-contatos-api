using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ModuloApi.Context;
using ModuloApi.Entities;

namespace ModuloApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ContatoController : ControllerBase
  {
    private readonly AgendaDbContext _agendaDbContext;

    public ContatoController(AgendaDbContext agendaDbContext)
    {
      _agendaDbContext = agendaDbContext;
    }

    [HttpPost]
    public IActionResult Create([FromBody] Contato contato)
    {
      _agendaDbContext.Contatos.Add(contato);
      _agendaDbContext.SaveChanges();

      return CreatedAtAction(nameof(FindById), new {id = contato.Id}, contato);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> FindById(int id)
    {
      var contato = await _agendaDbContext.Contatos.FindAsync(id);

      if (contato == null)
        return NotFound();

      return Ok(contato);
    }

    [HttpGet("GetByName")]
    public IActionResult GetByName(string nome)
    {
      var contatos = _agendaDbContext.Contatos.Where(c => c.Nome.Contains(nome));

      return Ok(contatos);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Contato contato)
    {
      var contatoToUpdate = await _agendaDbContext.Contatos.FindAsync(id);

      if (contatoToUpdate == null)
        return NotFound();

      contatoToUpdate.Nome = contato.Nome;
      contatoToUpdate.Telefone = contato.Telefone;
      contatoToUpdate.Ativo = contato.Ativo;

      _agendaDbContext.Contatos.Update(contatoToUpdate);
      _agendaDbContext.SaveChanges();

      return Ok(contatoToUpdate);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(int id)
    {
      var contatoToRemove = await _agendaDbContext.Contatos.FindAsync(id);

      if (contatoToRemove == null)
        return NotFound();

      _agendaDbContext.Contatos.Remove(contatoToRemove);
      _agendaDbContext.SaveChanges();

      return Ok(contatoToRemove);
    }
  }
}
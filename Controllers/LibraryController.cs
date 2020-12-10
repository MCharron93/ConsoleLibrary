using System.Collections.Generic;
using ConsoleLibrary.Models;
using ConsoleLibrary.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleLibrary.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class LibraryController : ControllerBase
  {
    private readonly LibraryService _ls;

    public LibraryController(LibraryService ls)
    {
      _ls = ls;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetBooks()
    {
      try
      {
        return Ok(_ls.GetBooks());
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpGet("{index}")]
    public ActionResult<Book> GetOneBook(int index)
    {
      try
      {
        return Ok(_ls.GetOneBook(index));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Book> Create([FromBody] Book newBook)
    {
      try
      {
        return Ok(_ls.Create(newBook));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{index}")]
    public ActionResult<string> Delete(int index)
    {
      try
      {
        return Ok(_ls.Delete(index));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPut("{index}")]
    public ActionResult<Book> EditBook(int index, [FromBody] Book editedBook)
    {
      try
      {
        return Ok(_ls.EditBook(index, editedBook));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}

using System;
using System.Collections.Generic;
using ConsoleLibrary.DB;
using ConsoleLibrary.Models;

namespace ConsoleLibrary.Services
{
  public class LibraryService
  {
    public IEnumerable<Book> GetBooks()
    {
      return FakeDB.Books;
    }

    public Book Create(Book newBook)
    {
      FakeDB.Books.Add(newBook);
      return newBook;
    }

    public string Delete(int index)
    {
      FakeDB.Books.RemoveAt(index);
      return "Book has been removed from the library!";
    }
  }
}
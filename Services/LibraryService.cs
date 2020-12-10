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

    public Book EditBook(int index, Book editedBook)
    {
      Book oldVersionBook = FakeDB.Books[index];

      FakeDB.Books[index].Title = editedBook.Title == null ? oldVersionBook.Title : editedBook.Title;
      FakeDB.Books[index].Author = editedBook.Author == null ? oldVersionBook.Author : editedBook.Author;
      FakeDB.Books[index].Description = editedBook.Description == null ? oldVersionBook.Description : editedBook.Description;
      FakeDB.Books[index].IsAvailable = editedBook.IsAvailable == null ? oldVersionBook.IsAvailable : editedBook.IsAvailable;

      return FakeDB.Books[index];
    }

    public Book GetOneBook(int index)
    {
      return FakeDB.Books[index];
    }
  }
}
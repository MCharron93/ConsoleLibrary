using System.Collections.Generic;
using ConsoleLibrary.Models;

namespace ConsoleLibrary.DB
{
  public static class FakeDB
  {
    public static List<Book> Books { get; set; } = new List<Book>()
    {
      new Book("Arcana for Dummies", "Harry the Hobo Wizard", "Perfect for total idiots to learn the basics of arcana magic; without melting your face off!", true),
      new Book("How to Gain Followers AND Respect in the Community", "Samara the Sadist", "A leadership guide for builiding up your following while also gaining a good reputation among the town leaders.", true),
      new Book("Raising the Dead and the Roof!", "Zoro the Zombie Whisperer", "A complete history of cool necromancy spells, how the dead rising changed the decade, and some sick parties that ensued after victory!", true),
      new Book("Divination and Light Spells", "Jora of Piety", "A collection of divine magic. A perfect addition to any clerics library, with tips and tricks on how to become one with the divine Gods(A signed photo of myself will be included with every purchase).", true)
    };
  }
}
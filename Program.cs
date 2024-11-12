using Spectre.Console;
using TCSA.OOP.LibraryManagementSystem;

// var menuChoices = new string[3] { "View Books", "Add Book", "Delete Book" };

// var books = new List<string>()
// {
//     "The Great Gatsby", "To Kill a Mockingbird", "1984", "Pride and Prejudice", "The Catcher in the Rye", "The Hobbit", "Moby-Dick", "War and Peace", "The Odyssey", "The Lord of the Rings", "Jane Eyre", "Animal Farm", "Brave New World", "The Chronicles of Narnia", "The Diary of a Young Girl", "The Alchemist", "Wuthering Heights", "Fahrenheit 451", "Catch-22", "The Hitchhiker's Guide to the Galaxy"
// };

while (true)
{
  Console.Clear();

  var choice = AnsiConsole.Prompt(
  new SelectionPrompt<MenuOption>()
  .Title("What menu item next?")
  .AddChoices(Enum.GetValues<MenuOption>())
  );



  switch (choice)
  {
    case MenuOption.ViewBooks:
      BooksController.ViewBooks();
      break;

    case MenuOption.AddBook:
      BooksController.AddBook();
      break;

    case MenuOption.DeleteBook:
      BooksController.DeleteBook();
      break;
  }
}

enum MenuOption
{
  ViewBooks,
  AddBook,
  DeleteBook
}


using Spectre.Console;
using static TCSA.OOP.LibraryManagementSystem.Enums;

namespace TCSA.OOP.LibraryManagementSystem
{
    public class UserInterface
    {
        internal static void MainMenu()
        {
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
        }
    }
}
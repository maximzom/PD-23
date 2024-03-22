using System;

public class Title
{
    private string titleOfBook;

    public Title(string title)
    {
        titleOfBook = title;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Назва книги: {titleOfBook}.");
        Console.ResetColor();
    }
}
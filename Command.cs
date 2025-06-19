namespace UndoDemo;

class Command : ICommand
{
    public void Redo()
    {
        Console.WriteLine("Do");
    }

    public void Undo()
    {
        Console.WriteLine("Undo");
    }
}


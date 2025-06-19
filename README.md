# Undo Redo Stack Implementation

Simple implementation

## ICommand

```csharp
interface ICommand
{
    void Redo();    // Rename: Do() or Excute()
    void Undo();
}
```

## Command

```csharp
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
```

## CommandService

```csharp
class CommandService
{
    readonly Stack<ICommand> _undoStack = new();
    readonly Stack<ICommand> _redoStack = new();

    public void Do(ICommand item)
    {
        item.Redo();
        _undoStack.Push(item);
        _redoStack.Clear();
    }

    public void Redo()
    {
        _redoStack.TryPop(out ICommand? item);

        if(item is not null)
        {
            item.Redo();
            _undoStack.Push(item);
        }
    }

    public void Undo()
    {
        _undoStack.TryPop(out ICommand? item);

        if(item is not null)
        {
            item.Undo();
            _redoStack.Push(item);
        }
    }
}
```

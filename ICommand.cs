namespace UndoDemo;

interface ICommand
{
    void Redo();    // Rename: Do() or Excute()
    void Undo();
}

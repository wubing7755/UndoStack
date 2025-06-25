namespace UndoDemo;

public interface ICloneable<out T>
{
    T Clone();
}


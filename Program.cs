namespace UndoDemo;

internal class Program
{
    static void Main(string[] args)
    {
        CommandService service = new CommandService();

        Console.WriteLine("1: redo & 2: undo & 3: Do");

        while (true)
        {
            string? input = Console.ReadLine();

            if (input is null || string.IsNullOrEmpty(input))
                continue;

            if (!int.TryParse(input, out int key))
                continue;

            switch (key)
            {
                case 1:
                    service.Redo();
                    break;
                case 2:
                    service.Undo();
                    break;
                case 3:
                    Command command = new Command();
                    service.Do(command);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                    break;

            }
        }

    }
}

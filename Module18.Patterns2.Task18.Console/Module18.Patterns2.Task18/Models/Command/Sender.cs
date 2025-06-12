namespace Module18.Patterns2.Task18;

/// <summary>
/// Отправитель команды
/// </summary>
public class Sender
{
    Command _command;

    public void SetCommand(Command command)
    {
        _command = command;
    }

    // Выполнить
    public void Run()
    {
        _command.Run();
    }

    // Отменить
    public void Cancel()
    {
        _command.Cancel();
    }
}

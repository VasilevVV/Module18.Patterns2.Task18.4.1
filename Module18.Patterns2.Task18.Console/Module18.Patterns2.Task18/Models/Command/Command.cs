namespace Module18.Patterns2.Task18;

/// <summary>
/// Базовый класс команды
/// </summary>
public abstract class Command
{
    public abstract void Run();
    public abstract void Cancel();
}

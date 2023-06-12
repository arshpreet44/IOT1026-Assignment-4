using Assignment.InterfaceCommand;

namespace Assignment;

public class Robot
{
    public int NumCommands { get; }
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }

    private const int DefaultCommands = 6;
    private readonly Queue<RobotCommand> _commands; 
    private int _commandsLoaded = 0;

    public override string ToString()
    {
        return $"[{X} {Y} {IsPowered}]";
    }

    public Robot() : this(DefaultCommands) { }

    public Robot(int numCommands)
    {
        _commands = new Queue<RobotCommand>();
        NumCommands = numCommands;
    }

    public void Run()
    {
        while (_commands.Count > 0){
            RobotCommand command = _commands.Dequeue();
            command.Run(this);
            --_commandsLoaded;
            Console.WriteLine(this);
        }
    }
    public bool LoadCommand(RobotCommand command)
    {
        if (_commandsLoaded >= NumCommands)
            return false;
        _commands.Enqueue(command);
        _commandsLoaded++;
        return true;
    }
}
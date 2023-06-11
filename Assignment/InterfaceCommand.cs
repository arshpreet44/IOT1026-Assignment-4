namespace Assignment.interfaceCommand;

public interface RobotCommand
{
    void Run(Robot robot);
}
public interface Robot
{
    void TurnOn();
    void TurnOff();
    void MoveWest();
    void MoveEast();
    void MoveSouth();
    void MoveNorth();

}
public class OnCommand : RobotCommand
{
    private readonly Robot _robot;

    public OnCommand(Robot robot)
    {
        _robot = robot;
    }

    public void Run()
    {
        _robot.TurnOn();
    }
}

public class OffCommand : RobotCommand
{
    private readonly Robot _robot;

    public OffCommand(Robot robot)
    {
        _robot = robot;
    }

    public void Run()
    {
        _robot.TurnOff();
    }
}
public class WestCommand : RobotCommand
{
    private readonly Robot _robot;

    public WestCommand(Robot robot)
    {
        _robot = robot;
    }

    public void Run()
    {
                    // Implementation of WestCommand's Run method
        _robot.MoveWest();
                           // Add any other logic specific to the WestCommand
    }
}
public class EastCommand : RobotCommand
{
    private readonly Robot _robot;

    public EastCommand(Robot robot)
    {
        _robot = robot;
    }

    public void Run()
    {
                    // Implementation of WestCommand's Run method
        _robot.MoveEast();
                           // Add any other logic specific to the WestCommand
    }
}
public class SouthCommand : RobotCommand
{
    private readonly Robot _robot;

    public SouthCommand(Robot robot)
    {
        _robot = robot;
    }

    public void Run()
    {
                    // Implementation of WestCommand's Run method
        _robot.MoveSouth();
                           // Add any other logic specific to the WestCommand
    }
}
public class NorthCommand : RobotCommand
{
    private readonly Robot _robot;

    public NorthCommand(Robot robot)
    {
        _robot = robot;
    }

    public void Run()
    {
                    // Implementation of WestCommand's Run method
        _robot.MoveNorth();
                           // Add any other logic specific to the WestCommand
    }
}


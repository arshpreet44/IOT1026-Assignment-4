using Assignment.InterfaceCommand;

namespace Assignment;

static class RobotTester
{
    public static void TestRobot()
    {
        int totalCommands = 1;
        Robot robot = new Robot();
        Console.WriteLine("Choose 6 Commands : \nON\nOFF\nNORTH\nSOUTH\nEAST\nSOUTH\nWEST\nREBOOT\n");
        Console.WriteLine("Choose from the given commands : \n");
        Console.WriteLine("ON\n");
        Console.WriteLine("OFF\n");
        Console.WriteLine("WEST\n");
        Console.WriteLine("EAST\n");
        Console.WriteLine("NORTH\n");
        Console.WriteLine("SOUTH\n");
        do
        {
            if (totalCommands == 1)
            {
                Console.Write($"Enter {totalCommands}st command : ");
            }
            else if (totalCommands == 2)
            {
                Console.Write($"Enter {totalCommands}nd command : ");
            }
            else if (totalCommands == 3)
            {
                Console.Write($"Enter {totalCommands}rd command : ");
            }
            else if (totalCommands >= 4)
            {
                Console.Write($"Enter {totalCommands}th command : ");
            }


            string? choice = Console.ReadLine()?.ToUpper();
            RobotCommand? command = choice switch
            {
                "ON" => new OnCommand(),
                "OFF" => new OffCommand(),
                "NORTH" => new NorthCommand(),
                "SOUTH" => new SouthCommand(),
                "EAST" => new EastCommand(),
                "WEST" => new WestCommand(),
                "REBOOT" => new RebootCommand(),
                _ => null
            };
            if (command != null)
            {
                robot.LoadCommand(command);
                totalCommands++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR This is not a valid command");
                Console.ResetColor();
            }
        } while (totalCommands <= 6);
        Console.WriteLine();
        robot.Run();
        Console.ReadLine();
    }
}

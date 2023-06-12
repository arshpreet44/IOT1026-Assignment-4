using Assignment.InterfaceCommand;

namespace Assignment
{
    public class Robot
    {
        public int NumCommands { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }

        private const int DefaultCommands = 6;

        private readonly Queue<RobotCommand> _commands;
        private int _commandsLoaded;

        public override string ToString()
        {
            return $"[current x : {X} | current y : {Y} | power status : {IsPowered}]";
        }

        public Robot() : this(DefaultCommands) { }

        /// <summary>
        /// this constructor will declare the que in robot object so that it can store commands
        /// </summary>
        /// <param name="numCommands"></param>
        public Robot(int numCommands)
        {
            _commands = new Queue<RobotCommand>(numCommands);
            NumCommands = numCommands;
        }

        /// <summary>
        /// this function is responsible for executing the commands present in robot's que
        /// this will return true if the command is executed correctly and false if not
        /// </summary>
        /// <returns></returns>
        public bool Run()
        {
            if (_commands.Count == 0 || _commands.Count < 0)
            {
                return false;
            }
            while (_commands.Count > 0)
            {
                RobotCommand c = _commands.Dequeue();
                c.Run(this);
                Console.WriteLine(this);
            }
            return true;
        }

        public bool LoadCommand(RobotCommand command)
        {
            if (_commandsLoaded >= NumCommands)
            {
                return false;
            }
            else
            {
                _commands.Enqueue(command);
                _commandsLoaded += 1;
                return true;
            }
        }
    }
}
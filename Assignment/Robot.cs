using System;
using Assignment.interfaceCommand;

namespace Assignment
{
    public class Robot
    {
        // These are properties, you can replace these with traditional getters/setters if you prefer.
        public int NumCommands { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }

        private const int DefaultCommands = 6;
        // An array is not the preferred data structure here.
        // You will get bonus marks if you replace the array with the preferred data structure
        // Hint: It is NOT a list either,
        private readonly RobotCommand[] _commands;
        private int _commandsLoaded = 0;

        public override string ToString()
        {
            return $"[{X} {Y} {IsPowered}]";
        }

        // Constructor named "Robot" with no parameters. It has an initializer that calls another constructor.
        public Robot() : this(DefaultCommands) { }

        /// <summary>
        /// Initializes the robot with the capacity to store a user specified
        /// number of commands
        /// </summary>
        /// <param name="numCommands">The maximum number of commands the robot can store</param>
        public Robot(int numCommands)
        {
            _commands = new RobotCommand[numCommands];
            NumCommands = numCommands;
        }

        /// <summary>
        /// Runs the loaded commands on the robot
        /// </summary>
        public void Run()
        {
            for (var i = 0; i < _commandsLoaded; ++i)
            {
                _commands[i].Run(this);
                Console.WriteLine(this);
            }
        }

        /// <summary>
        /// Loads a command into the robot's command list
        /// </summary>
        /// <param name="command">The command to load</param>
        /// <returns>True if the command was successfully loaded, false otherwise</returns>
        public bool LoadCommand(RobotCommand command)
        {
            if (_commandsLoaded >= NumCommands)
                return false;
            _commands[_commandsLoaded++] = command;
            return true;
        }
    }
}

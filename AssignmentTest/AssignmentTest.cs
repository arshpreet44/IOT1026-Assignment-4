using Assignment;
using Assignment.AbstractCommand;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void PropertiesTest()
        {
            Robot robot1 = new();
            Assert.AreEqual(robot1.NumCommands, 6);
            const int expectedCommands = 10;
            Robot robot2 = new(expectedCommands);
            Assert.AreEqual(robot1.NumCommands, expectedCommands);

            Assert.AreEqual(robot1.IsPowered, false);
            //robot1.IsPowered = true;
            //Assert.AreEqual(robot1.IsPowered, true);

            Assert.AreEqual(robot1.X, 0);
            robot1.X = -5;
            Assert.AreEqual(robot1.X, -5);

            Assert.AreEqual(robot1.Y, 0);
            robot1.Y = -5;
            Assert.AreEqual(robot1.Y, -5);
        }

        [TestMethod]
        public void CommandTest()
        {
            Robot testRobot = new();

            Assert.AreEqual(testRobot.IsPowered, false);
            testRobot.LoadCommand(new OnCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.IsPowered, true);
        }
    }
}


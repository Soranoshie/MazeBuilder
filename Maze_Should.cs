using NUnit.Framework;

namespace Generics.MazeBuilder
{
    [TestFixture]
    public class Maze_Should
    {
        [Test]
        public void TestBuilder_Ok()
        {
            var builder = new ScaryMazeBuilder();
            var maze = builder
                .AddGhost(5, 5)
                .AddGhost(15, 5)
                .AddRock(5, 6)
                .AddRock(5, 4)
                .AddRock(4, 5)
                .Build();
        }
        
        [Test]
        public void TestBuilder_ShouldBeOk()
        {
            var builder = new ScaryMazeBuilder();
            var maze = builder
                .AddRock(5, 6)
                .AddRock(5, 4)
                .AddRock(4, 5)
                .AddGhost(5, 5) // работает :)
                .AddGhost(15, 5)  // работает :)
                .Build();
        }
    }
}

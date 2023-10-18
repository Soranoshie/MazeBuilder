namespace Generics.MazeBuilder
{
    public class Maze
    {
    }

    public class MazeBuilder<T> where T : MazeBuilder<T>
    {
        private Maze maze = new Maze();

        public T AddRock(int x, int y)
        {
            return (T)this;
        }

        public T AddWater(int x, int y)
        {
            return (T)this;
        }

        public Maze Build()
        {
            return maze;
        }
    }

    public class ScaryMazeBuilder : MazeBuilder<ScaryMazeBuilder>
    {
        public ScaryMazeBuilder AddGhost(int x, int y)
        {
            return this;
        }
    }
}
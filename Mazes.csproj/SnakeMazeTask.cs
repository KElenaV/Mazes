namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			height -= 2;
			while(height > 1)
            {
				MoveOneCicle(robot, width, height);
				height -= 3;
				if (height > 0)
					MoveDown(robot, ref height);
			}
		}

		public static void MoveOneCicle(Robot robot, int width, int height)
        {
			MoveXDirection(robot, width, Direction.Right);
			MoveDown(robot, ref height);
			MoveXDirection(robot, width, Direction.Left);
        }

		public static void MoveXDirection(Robot robot, int width, Direction direction)
        {
			for (int i = 0; i < width - 3; i++)
				robot.MoveTo(direction);
		}
		
		public static void MoveDown(Robot robot, ref int height)
        {
            for (int i = 0; i < 2; i++)
				robot.MoveTo(Direction.Down);
			height--;
        }
	}
}
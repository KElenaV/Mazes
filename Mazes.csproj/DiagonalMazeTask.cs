namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int widthStep = 1;
			int heihthStep = 1;
			if (width > height) widthStep =(int)System.Math.Round((double)width / height);
			else heihthStep = (int)System.Math.Round((double)height / width);
		}

		public static void MoveOneStep(Robot robot,Direction direction, int step)
        {
            for (int i = 0; i < step; i++)
            {
				robot.MoveTo(direction);
            }
        }
	}
}
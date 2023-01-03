namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            int i = 0, j = 0;
			while (j < height - 2)
			{
				i = 0;
                if (j / 2 % 2 == 0) while (i < width - 3) { robot.MoveTo(Direction.Right); i++; }
				else while (i < width - 3) { robot.MoveTo(Direction.Left); i++; }
                j += 2;
                if (j < height - 2)
                {
                    robot.MoveTo(Direction.Down);
                    robot.MoveTo(Direction.Down);
                }
                
            }
        }
	}
}
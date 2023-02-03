using System;

namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int j = width + 3, k = height;

            if (width > height) while (j >= 0)
			{
				if (width > height) for (int i = 0; i <= width / height; i++) { robot.MoveTo(Direction.Right); j--; }
				if (j >= 0) { robot.MoveTo(Direction.Down); j--;}
			}
            if (height > width) while (k > 0)
                {
                    if (height > width) for (int i = 0; i < Math.Floor((double)height / width); i++) { robot.MoveTo(Direction.Down); k--; }
                    if (k > 0) { robot.MoveTo(Direction.Right); k--; }
                }
        }
	}
}
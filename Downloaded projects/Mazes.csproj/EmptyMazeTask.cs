using System;

namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int i = width - 3, j = height - 3;
			while (i > 0) { robot.MoveTo(Direction.Right); i--; }
			while (j > 0) { robot.MoveTo(Direction.Down); j--; }
		}
	}
}
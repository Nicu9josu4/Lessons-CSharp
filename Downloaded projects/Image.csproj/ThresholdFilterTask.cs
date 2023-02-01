namespace Recognizer
{
	public static class ThresholdFilterTask
	{
		public static double[,] ThresholdFilter(double[,] original, double whitePixelsFraction)
		{
            var ThretsholdetImage = new double[original.GetLength(0), original.GetLength(1)];

            for (int i = 0; i < original.GetLength(0); i++)
            {
                for (int j = 0; j < original.GetLength(1); j++)
                {
                    if (original[i,j] < whitePixelsFraction)
                    {
                        ThretsholdetImage[i, j] = 0;
                    }else ThretsholdetImage[i, j] = 1;

                }
            }

            return ThretsholdetImage;
		}
	}
}
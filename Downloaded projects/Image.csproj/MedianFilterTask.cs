using System;
using System.Drawing;
using System.Linq;

namespace Recognizer
{
	internal static class MedianFilterTask
	{
		/* 
		 * Для борьбы с пиксельным шумом, подобным тому, что на изображении,
		 * обычно применяют медианный фильтр, в котором цвет каждого пикселя, 
		 * заменяется на медиану всех цветов в некоторой окрестности пикселя.
		 * https://en.wikipedia.org/wiki/Median_filter
		 * 
		 * Используйте окно размером 3х3 для не граничных пикселей,
		 * Окно размером 2х2 для угловых и 3х2 или 2х3 для граничных.
		 */
		public static double[,] MedianFilter(double[,] original)
		{
            int ienumerator = 0;
			while (ienumerator < 2)
			{
                var image = new double[original.GetLength(0), original.GetLength(1)];

                for (int i = 0; i < original.GetLength(0); i++)
                {
                    for (int j = 0; j < original.GetLength(1); j++)
                    {
                        if (original[i, j] == 0 || original[i, j] == 1)
                        {
                            #region Colturi

                            // colt stanga sus
                            if (i == 0 && j == 0) image[i, j] = GetMed(new double[] { original[i + 1, j], original[i, j + 1], original[i + 1, j + 1] });
                            // colt stanga jos
                            else if (i == 0 && j == original.GetLength(1)) image[i, j] = GetMed(new double[] { original[i + 1, j], original[i, j - 1], original[i + 1, j - 1] });
                            // colt dreapta sus
                            else if (i == original.GetLength(0) && j == 0) image[i, j] = GetMed(new double[] { original[i - 1, j], original[i, j + 1], original[i - 1, j + 1] });
                            // colt dreapta jos
                            else if (i == original.GetLength(0) && j == original.GetLength(1)) image[i, j] = GetMed(new double[] { original[i - 1, j], original[i, j - 1], original[i - 1, j - 1] });

                            #endregion

                            #region Margini

                            // marginea de sus
                            else if (j == 0 && i > 0 && i < original.GetLength(0))
                                image[i, j] = GetMed(new double[] { original[i - 1, j], original[i + 1, j], original[i - 1, j + 1], original[i, j + 1], original[i + 1, j + 1] });

                            // marginea de dreapta
                            else if (j == original.GetLength(1)-1 && i > 0 && i < original.GetLength(0))
                                image[i, j] = GetMed(new double[] { original[i - 1, j], original[i - 1, j - 1], original[i, j - 1], original[i + 1, j - 1], original[i + 1, j] });

                            // marginea de stanga
                            else if (i == 0 && j > 0 && j < original.GetLength(1) + 1)
                                image[i, j] = GetMed(new double[] { original[i, j - 1], original[i + 1, j - 1], original[i + 1, j], original[i + 1, j + 1], original[i, j + 1] });

                            // marginea de jos
                            else if (i == original.GetLength(0)-1 && j > 0 && j < original.GetLength(1) )
                                image[i, j] = GetMed(new double[] { original[i, j - 1], original[i - 1, j - 1], original[i - 1, j], original[i - 1, j + 1], original[i, j + 1] });

                            #endregion

                            else if (i > 0 && i < original.GetLength(0) - 1 && j > 0 && j < original.GetLength(1) - 1) image[i, j] = GetMed(new double[]
                            {
                            original[i - 1, j - 1],
                            original[i, j - 1],
                            original[i + 1, j - 1],
                            original[i + 1, j],
                            original[i + 1, j + 1],
                            original[i, j + 1],
                            original[i - 1, j - 1],
                            original[i - 1, j]
                            });
                        }
                        else
                            image[i, j] = original[i, j];
                    }
                }
                original = image;
                ienumerator++;
            }
            return original;
		}
		public static double GetMed(double[] numbers)
		{
			for(int i =0; i < numbers.Length; i ++)
				for(int j = 0;j<numbers.Length-1; j++)
					if (numbers[j] > numbers[j + 1]) (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
			return numbers[numbers.Length / 2];
        }
	}
}
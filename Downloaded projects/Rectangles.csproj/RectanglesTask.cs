using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			// так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
			var pointDistance = Math.Sqrt(Math.Pow(Math.Max(r2.Left, r1.Left) - Math.Min(r2.Left, r1.Left) ,2) + Math.Pow(Math.Max(r2.Top, r1.Top) - Math.Min(r2.Top, r1.Top), 2));
			if(pointDistance < (r1.Height + r2.Height) || pointDistance < (r1.Width + r2.Width))
				return true;
			return false;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
            
            return 0;
        }

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
            // -1 daca niciunul nu-l suprapune pe celalalt
            // 1 daca r2 este in interiorul lui r1
            // 0 daca r1 este in interiorul lui r2
            if (r1.Width * r1.Height > r2.Width * r2.Height) return 1;
            if (r1.Width * r1.Height < r2.Width * r2.Height) return 0;
            return -1;
		}
	}
}
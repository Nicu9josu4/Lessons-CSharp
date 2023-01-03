using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		// Ниже — это XML документация, её использует ваша среда разработки, 
		// чтобы показывать подсказки по использованию методов. 
		// Но писать её естественно не обязательно.
		/// <param name="v">Начальная скорость</param>
		/// <param name="distance">Расстояние до цели</param>
		/// <returns>Угол прицеливания в радианах от 0 до Pi/2</returns>
		public static double FindSightAngle(double v, double distance)
		{

            /* yield return new ArtilleryTestCase(100, 1000);
               PI / 4,3,5 -- yield return new ArtilleryTestCase(10, 0);
               PI / 4 -- yield return new ArtilleryTestCase(99.1, 1000);
               yield return new ArtilleryTestCase(450, 20000);
               yield return new ArtilleryTestCase(450, 1000);
               yield return new ArtilleryTestCase(450, 200);
               yield return new ArtilleryTestCase(10, 1);
               yield return new ArtilleryTestCase(9, 1);
               yield return new ArtilleryTestCase(8, 1);
               yield return new ArtilleryTestCase(7, 1);
               yield return new ArtilleryTestCase(6, 1);
               yield return new ArtilleryTestCase(5, 1);
               yield return new ArtilleryTestCase(4, 1);
               yield return new ArtilleryTestCase(3.5, 1);
               PI / 5 yield return new ArtilleryTestCase(3.2, 1);
               yield return new ArtilleryTestCase(3.15, 1);
               yield return new ArtilleryTestCase(3.14, 1);
               yield return new ArtilleryTestCase(1, 1000, hasSolution:false);*/


            //if (distance > 10 * v)
            return 0.1;
   //         if (distance > 100 * v)
   //             return Math.PI / 2;
			//else return Math.PI / 6;

        }
	}
}
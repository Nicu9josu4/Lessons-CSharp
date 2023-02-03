using System;

namespace Billiards
{
    public static class BilliardsTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directionRadians">Угол направления движения шара</param>
        /// <param name="wallInclinationRadians">Угол</param>
        /// <returns></returns>
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            //TODO
            
            //if (wallInclinationRadians == Math.PI / 2) return   Math.PI - directionRadians;
            //if (wallInclinationRadians == 0) return   Math.PI * 2 - directionRadians;
            //if (wallInclinationRadians == Math.PI / 4) return   wallInclinationRadians * 2 - directionRadians ;
            //if (wallInclinationRadians == -Math.PI / 4) return (-Math.PI / 2 - directionRadians) ;
            return (wallInclinationRadians - directionRadians) + wallInclinationRadians;
        }
    }
}

/*
 
 ui.Line(50 * Math.Cos(angle), -50 * Math.Sin(angle)
 ui.Line(50 * Math.Cos(expectedFinalDirection), -50 * Math.Sin(expectedFinalDirection), 0, 0,
                new Pen(Color.Green, 1) {DashStyle = DashStyle.Dash});
 
 */
using System;
using System.Collections.Generic;
using System.Text;
using Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk.Model;

namespace Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk
{
    public class Math
    {
        /// <summary>
        /// Представление вектора с измененным y и z осями (для облегчения вычислений) и желаемым положением
        /// </summary>
        public class Vector
        {

            public double pos_x { get; set; }
            /// <summary>
            /// соответствует игровой оси z
            /// </summary>
            public double pos_y { get; set; }
            /// <summary>
            /// соответствует игровой оси y
            /// </summary>
            public double pos_z { get; set; }

            public double x { get; set; }
            /// <summary>
            /// соответствует игровой оси z
            /// </summary>
            public double y { get; set; }
            /// <summary>
            /// соответствует игровой оси y
            /// </summary>
            public double z { get; set; }

            #region конструкторы

            /// <summary>
            /// направленный вектор без высоты
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="pos_x"></param>
            /// <param name="pos_game_z">координата вектора по z в игровой оси</param>
            public Vector(double x, double game_z, double pos_x, double pos_game_z)
            {
                this.x = x;
                this.y = game_z;

                this.pos_x = pos_x;
                this.pos_y = pos_game_z;

                this.z = 0f;
                this.pos_z = 0f;
            }

            /// <summary>
            /// направленный вектор с высотой
            /// </summary>
            /// <param name="x">координата вектора по x в игровой оси</param>
            /// <param name="game_y">координата вектора по y в игровой оси</param>
            /// <param name="game_z">координата вектора по z в игровой оси</param>
            /// <param name="pos_x"> x координата объекта</param>
            /// <param name="pos_game_y"> координата объекта по y в игровой оси</param>
            /// <param name="pos_game_z"> координата объекта по z в игровой оси</param>
            public Vector(double x, double game_y, double game_z, double pos_x, double pos_game_y, double pos_game_z)
            {
                this.x = x;
                this.y = game_z;
                this.z = game_y;
                this.pos_x = pos_x;
                this.pos_y = pos_game_z;
                this.pos_z = pos_game_y;
            }

            #endregion

            /// <summary>
            /// Возвращает растояние между объектами с учетом высоты
            /// </summary>
            /// <param name="v2"></param>
            /// <returns></returns>
            public double DistanceTo(Vector v2)
            {
                return System.Math.Sqrt(
                    System.Math.Pow(v2.pos_x - this.pos_x, 2) +
                    System.Math.Pow(v2.pos_y - this.pos_y, 2) +
                    System.Math.Pow(v2.pos_z - this.pos_z, 2)
                    );
            }

            /// <summary>
            /// Возвращает растояние между объектами не учитывая высоту
            /// </summary>
            /// <param name="v2"></param>
            /// <returns></returns>
            public double PlaneDistanceTo(Vector v2)
            {
                return System.Math.Sqrt(
                    System.Math.Pow(v2.pos_x - this.pos_x, 2) +
                    System.Math.Pow(v2.pos_y - this.pos_y, 2)
                    );
            }

        }

        public class Coordinate
        {
            public double x { get; set; }
            /// <summary>
            /// соответствует игровой оси z
            /// </summary>
            public double y { get; set; }
            /// <summary>
            /// соответствует игровой оси y
            /// </summary>
            public double z { get; set; }

            public Coordinate(double game_x, double game_y, double game_z)
            {
                this.x = game_x;
                this.y = game_z;
                this.z = game_y;
            }

            
        }
    }
}

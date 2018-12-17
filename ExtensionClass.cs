using System;
using System.Collections.Generic;
using System.Text;
using Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk.Model;

namespace Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk
{
        public static class ExtensionClass
    {
        public static Math.Vector GetVector(this Ball ball)
        {
            return new Math.Vector(ball.velocity_x, ball.velocity_y, ball.velocity_z, ball.x, ball.y, ball.z);
        }

        /// <summary>
        /// Конвертирует координату в действие с координатами мира
        /// </summary>
        /// <param name="coor"></param>
        /// <returns></returns>
        public static Model.Action CreateAction(this Model.Action action, Math.Coordinate coor)
        {
            action.target_velocity_x = coor.x;
            action.target_velocity_y = coor.z;
            action.target_velocity_z = coor.y;
            return action;
        }

        /// <summary>
        /// Конвертирует вектор в действие с координатами мира
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static Model.Action CreateAction(this Model.Action action, Math.Vector vector)
        {
            action.target_velocity_x = vector.pos_x;
            action.target_velocity_z = vector.pos_y;
            action.target_velocity_y = vector.pos_z;

            return action;
        }
    }
}

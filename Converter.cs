using System;
using System.Collections.Generic;
using System.Text;
using Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk.Model;

namespace Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk
{
    public static class Converter
    {
        public static Math.Vector BallToVector(Ball ball)
        {
            return new Math.Vector(ball.velocity_x, ball.velocity_y, ball.velocity_z, ball.x, ball.y, ball.z) vector;

        }
    }
}

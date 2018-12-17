using System;
using System.Collections.Generic;
using System.Text;
using Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk.Model;

namespace Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk
{
    public class Math
    {
        public class Vector
        {
            public double pos_x { get; set; }
            public double pos_y { get; set; }
            public double pos_z { get; set; }

            public double x { get; set; }
            public double y { get; set; }
            public double z { get; set; }

            //направленный вектор без высоты
            public Vector(double x, double y, double pos_x, double pos_y)
            {
                this.x = x;
                this.y = y;
                this.pos_x = pos_x;
                this.pos_y = pos_y;
            }

            //направленный вектор с высотой
            public Vector(double x, double y, double z, double pos_x, double pos_y, double pos_z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.pos_x = pos_x;
                this.pos_y = pos_y;
                this.pos_z = pos_z;
            }

        }
    }
}

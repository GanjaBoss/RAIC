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
            public int pos_x { get; set; }
            public int pos_y { get; set; }
            public int pos_z { get; set; }

            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }

            //направленный вектор без высоты
            public Vector(int x, int y, int pos_x, int pos_y)
            {
                this.x = x;
                this.y = y;
                this.pos_x = pos_x;
                this.pos_y = pos_y;
            }

            //направленный вектор с высотой
            public Vector(int x, int y, int z, int pos_x, int pos_y, int pos_z)
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

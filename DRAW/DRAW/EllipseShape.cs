﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DRAW
{
    [Serializable]
    class EllipseShape:BaseShape
    {
        public override BaseShape copySelf()		//重写复制自身方法
        {
            EllipseShape copyEllipseShape = new EllipseShape();
            copyEllipseShape.setP1(this.getP1());		//复制起点
            copyEllipseShape.setP2(this.getP2());		//复制终点
            copyEllipseShape.penColor = this.penColor;
            copyEllipseShape.penwidth = this.penwidth;
            return copyEllipseShape;
        }
        public override bool catchShape(Point p3)
        {
            Point p1 = this.getP1();
            Point p2 = this.getP2();
            int r = (int)Math.Pow(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2), 0.5);  //计算圆的半径
            if (Math.Abs(Math.Pow(Math.Pow(p1.X - p3.X, 2) + Math.Pow(p1.Y - p3.Y, 2), 0.5) - r) < 3)
            { return true; }
            else
            { return false; }
        }
    }
}

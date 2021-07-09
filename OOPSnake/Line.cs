﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class Line
    {
        protected List<Point> Points;

        public Line()
        {
            Points = new List<Point>();
        }

        public void Draw()
        {
            foreach(Point p in Points)
            {
                p.Draw();
            }    
        }
    }
}
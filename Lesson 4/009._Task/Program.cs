﻿
Point pointA = new Point(1, 2);

//Boxing
Object obj = pointA;

//UnBoxing
Point aganPoint = (Point)obj;

struct Point
{
    public int X { get; set; }

    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
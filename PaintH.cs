using System;
using System.Drawing;
using System.Collections.Generic;

namespace Heap_Sort
{
    /**
    * 画出给定堆的类，包含两个函数：
    * 私有函数：GetLevel(int num) 用于根据堆中数据的个数决定画出的堆的层数，最多可画4层
    * 公有函数：PaintHeap(Graphics g,List lst)用于画出给定的堆，为静态函数。
    */
    class PaintH
    {
        const int diameter = 40;
        const int gap = 15;
        const double th = Math.PI / 3;

        private static int GetLevel(int num)
        {
            int level;
            if (num == 1) level = 1;
            else if (num <= 3) level = 2;
            else if (num <= 7) level = 3;
            else if (num <= 15) level = 4;
            else level = 5;
            return level;
        }

        public static void PaintHeap(Graphics g,List<double> lst,int shownum)
        {
            int count = shownum > 31 ? 31 : shownum;
            int level = GetLevel(count);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.LightGreen);
            Brush top_brush = new SolidBrush(Color.LightSkyBlue);
            Brush fbrush = new SolidBrush(Color.DarkBlue);
            Font font = new Font("宋体", 9, FontStyle.Bold);
            int distance = diameter + gap;
            int y_dis = distance;
            int x_i = 100;
            int y_i = 400;
            for (int i = 0; i < level; i++)
            {
                int pres = (int)Math.Pow(2, level - i - 1);
                int end = i == 0 ? count - pres + 1 : pres;
                pres = pres - 1;
                for (int j = 0; j < end; j++)
                {
                    string s = lst[pres].ToString();
                    pres++;
                    int x = x_i + j * distance;
                    int y = y_i;
                    Rectangle rect = new Rectangle(x, y, diameter, diameter);
                    g.DrawEllipse(pen, rect);
                    if (i == level - 1) g.FillEllipse(top_brush, rect);
                    else g.FillEllipse(brush, rect);
                    int s_x = s.Length < 7 ? x + (6 - s.Length) * 4 : x;
                    int s_y = y + 16;
                    g.DrawString(s, font, fbrush, s_x, s_y);
                }
                x_i = (int)(x_i + distance * Math.Cos(th));
                y_i = (int)(y_i - y_dis * Math.Sin(th));
                y_dis = (int)(y_dis * 1.4);
                distance = 2 * distance;
            }
            g.Dispose();
        }
    }
}

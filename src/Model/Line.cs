using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
	[Serializable]
	public class Line : Shape
	{
		#region Constructor

		public Line(RectangleF rect) : base(rect)
		{

		}

		public Line(RectangleShape rectangle) : base(rectangle)
		{
		}
		public Line(int x1, int x2, int y1, int y2) : base()
		{
			point1.X = x1;
			point2.X = x2;
			point1.Y = y1;
			point2.Y = y2;
		}
		static int x1, y1, x2, y2;
	 public	 static PointF point1 = new Point(x1, y1);
		public static PointF point2 = new Point(x2, y2);
		public void DrawEclipse()
		{

		}

		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		/// 

		public bool between(float a, float b)
        {
            if ( b - 0.05 < a && a < b + 0.05 && a-0.05<b && b<a+0.05)
            {
				return true;
            }
			return false;
        }
		public override bool Contains(PointF point)
		{
			// A(x1,y1,z1) and B(x2,y2,z2). I have point p(x,y,z).
			float p = (point.X - point1.X) / (point2.X - point1.X);
			float g = (point.Y - point1.Y) / (point2.Y - point1.Y);
			if (between(p,g))
				// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}

		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			//GraphicsPath graphPath = new GraphicsPath();
			//grfx.FillPath(new SolidBrush(FillColor), graphPath);
			if (matrix != null)
			{
				grfx.MultiplyTransform(matrix);
			}
			//	grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawLine(new Pen(BorderColor), point1,point2);

			/*Graphics g = e.Graphics;
			Pen myPen = new Pen(Color.Black);
			Brush myBrush = new SolidBrush(Color.Red);
			g.DrawLine(myPen, 2, 2, 400, 166); */
		}
	}
}

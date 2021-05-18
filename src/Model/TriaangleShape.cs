using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
	[Serializable]
	class TriaangleShape:Shape
    {
		#region Constructor

		public TriaangleShape(RectangleF rect) : base(rect)
		{

		}

		public TriaangleShape(TriaangleShape rectangle) : base(rectangle)
		{
		}

        public TriaangleShape(int x1,int x2,int x3,int y1,int y2,int y3)
        {
			points[0] = new Point(x1, y1);
			points[1] = new Point(x2, y2);
			points[2] = new Point(x3, y3);
		}

        int x, y, h, w,z;

	public static	PointF[] points = new PointF[3];
	//	points[0] = new Point(x, y);
	//	points[1] = new Point(w, y);
	//	points[2] = new Point(h, z);

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
		public static bool IsPointInPolygon4(PointF[] polygon, PointF testPoint)
		{
			bool result = false;
			int j = polygon.Count() - 1;
			for (int i = 0; i < polygon.Count(); i++)
			{
				if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
				{
					if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
					{
						result = !result;
					}
				}
				j = i;
			}
			return result;
		}
		public override bool Contains(PointF point)
		{
			if (IsPointInPolygon4(points, point))
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
			PointF[] pointFs = new PointF[3];
			pointFs[0] = new PointF(Rectangle.Right, Rectangle.Top);
			pointFs[1] = new PointF(Rectangle.Right, Rectangle.Left);
			pointFs[2] = new PointF(Rectangle.Top, Rectangle.Width);
			if (matrix != null)
			{
				grfx.MultiplyTransform(matrix);
			}
			grfx.FillPolygon(new SolidBrush(FillColor), points);
			grfx.DrawPolygon(new Pen(BorderColor), points);
			// grfx.DrawRectangle(Pens.Black,Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
	[Serializable]
	public class GroupShape : Shape
	{
		#region Constructor


		public GroupShape(RectangleShape rectangle) : base(rectangle)
		{
		}
		//	public virtual PointF Location
		//	{
		//		get { return Rectangle.Location; }
		//		set { AddString.Location = value; }
		//	}


		// 	grfx.DrawString(s, drawFont, new SolidBrush(FillColor),w, h);
		public GroupShape( RectangleF rect) : base(rect)
		{
			
		}
		List<Shape> SubShape = new List<Shape>();
		public virtual int w { get; set; }
		public virtual int h { get; set; }
		public virtual float x { get; set; }
		public virtual float y { get; set; }

		RectangleF rect { get; set; }
		string s { get; set; }
		Font drawFont { get; set; }

		/// <summary>
		/// Височина на елемента.
		/// </summary>


		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				// foreach item in SubShape
				// check if point in item


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
			// for each item in SubShape
			// visualize shape



			base.DrawSelf(grfx);
			if (matrix != null)
			{
				grfx.MultiplyTransform(matrix);
			}
			grfx.DrawString(s, drawFont, new SolidBrush(Color.Pink), new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height));

			//grfx.DrawEllipse(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

		}
	}
}

using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Избран елемент.
		/// </summary>
		/// 
		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection {
			get { return selection; }
			set { selection = value; }
		}
		/*public Matrix localmatrix
        {
            get { return localmatrix; }
			set { localmatrix = value; }
        }*/
		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		#endregion
		
		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle(string width, string height)
		{
			int x =    Convert.ToInt32(width);
			int y = Convert.ToInt32(height);
			
			RectangleShape rect = new RectangleShape(new Rectangle(250,250, x, y));
			rect.FillColor = Color.White;

			ShapeList.Add(rect);
		}
		public void AddRandomLine(string width, string height)
		{
			int x = Convert.ToInt32(width);
			int y = Convert.ToInt32(height);

			Line rect = new Line(50,100,100,333);
			rect.FillColor = Color.White;
			rect.BorderColor = Color.Black;

			ShapeList.Add(rect);
		}
		public void AddRandomCircle(string width, string height)
		{
			
			int x = Convert.ToInt32(width);
			int y = Convert.ToInt32(height);

			triangleshape rect = new triangleshape(new Rectangle(250, 250, x, y));

			rect.FillColor = Color.White;

			ShapeList.Add(rect);
		}
		public void AddRandomTriangle(string width, string height)
		{

			int x = Convert.ToInt32(width);
			int y = Convert.ToInt32(height);

			TriaangleShape rect = new TriaangleShape(50,400,200,100,200,600);

			rect.FillColor = Color.Red;

			ShapeList.Add(rect);
		}
		public void AddRandomString(string width, string height)
		{

			int x = Convert.ToInt32(width);
			int y = Convert.ToInt32(height);
			// public AddString(String text,Font font,float width,float height )
			AddString addString = new AddString("dai mu",new Font("Times New Roman", 12.0f), x, y, new Rectangle(10, 10, x, y));

			addString.FillColor = Color.White;

			ShapeList.Add(addString);
		}


		/// <summary>
		/// Проверява дали дадена точка е в елемента.
		/// Обхожда в ред обратен на визуализацията с цел намиране на
		/// "най-горния" елемент т.е. този който виждаме под мишката.
		/// </summary>
		/// <param name="point">Указана точка</param>
		/// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
		/// 
		public void Rotate()
        {
			Matrix myMatrix = new Matrix();
			myMatrix.Translate(20, 0, MatrixOrder.Append);
			foreach (Shape item in selection)
            {
				item.matrix = myMatrix;
			}
				
		//	selection.Location = new PointF(selection.Location.X + 20 - lastLocation.X, selection.Location.Y + 20 - lastLocation.Y);
		//	lastLocation = p;
			//		grfx.RotateTransform(45, MatrixOrder.Append);
			//	selection.DrawSelf(grfx);
		}
		public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
					ShapeList[i].FillColor = Color.Red;
						
					return ShapeList[i];
				}	
			}
			return null;
		}
		
		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
            foreach (Shape item in selection)
            {
				if (item is TriaangleShape)
				{
					TriaangleShape.points[0] = new PointF(TriaangleShape.points[0].X + p.X - lastLocation.X, TriaangleShape.points[0].Y + p.Y - lastLocation.Y);
					TriaangleShape.points[1] = new PointF(TriaangleShape.points[1].X + p.X - lastLocation.X, TriaangleShape.points[1].Y + p.Y - lastLocation.Y);
					TriaangleShape.points[2] = new PointF(TriaangleShape.points[2].X + p.X - lastLocation.X, TriaangleShape.points[2].Y + p.Y - lastLocation.Y);
					
				}
				if (item is Line)
				{
					Line.point1 = new PointF(Line.point1.X + p.X - lastLocation.X, Line.point1.Y + p.Y - lastLocation.Y);
					Line.point2 = new PointF(Line.point2.X + p.X - lastLocation.X, Line.point2.Y + p.Y - lastLocation.Y);
					
				}
				if (!(item is Line) && !(item is TriaangleShape))
				{
					item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
					
				}
				
			}
			lastLocation = p;



		}
	}
}

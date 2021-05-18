using DocumentFormat.OpenXml.Drawing.Charts;
using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		public DialogProcessor dialogProcessor = new DialogProcessor();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Height = 500;
			this.Width = 500;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			
		}
		private void viewPort_Load(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle(textBox1.Text, textBox2.Text);

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}
		void drawcircleSpeedButtonClick(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomRectangle(textBox1.Text, textBox2.Text);

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked) {
				Shape sel = dialogProcessor.ContainsPoint(e.Location);
				if(sel != null)
                {
                    if (dialogProcessor.Selection.Contains(sel))
                    {
						dialogProcessor.Selection.Remove(sel);
                    }
                    else
                    {
						dialogProcessor.Selection.Add(sel);
                    }
                }


				if (sel != null)
				{
					statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
				
			}

		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomCircle(textBox1.Text,textBox2.Text);

			statusBar.Items[0].Text = "Последно действие: Рисуване на круг";

			viewPort.Invalidate();
		}

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomLine(textBox1.Text, textBox2.Text);

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";  


			viewPort.Invalidate();

		}

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomTriangle(textBox1.Text, textBox2.Text);

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();

		}

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomString(textBox1.Text, textBox2.Text);

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();

		}

        private void viewPort_Paint(object sender, PaintEventArgs e)
        {
			dialogProcessor.ReDraw(sender, e);
			
		}

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
			if (dialogProcessor.Selection == null)
			{

			}
            else
            {
				if (colorDialog1.ShowDialog() == DialogResult.OK)
				{
					foreach (Shape item in dialogProcessor.Selection)
                    {
						item.FillColor = colorDialog1.Color;
					}
						
					viewPort.Invalidate();
				}
			}
			
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection == null)
            {

            }
            else
            {
				if (colorDialog2.ShowDialog() == DialogResult.OK)
				{
					foreach (Shape item in dialogProcessor.Selection)
                    {
						item.BorderColor = colorDialog2.Color;
						
					}
					viewPort.Invalidate();
				}
			}
			
		}

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
			dialogProcessor.Rotate();
			viewPort.Invalidate();
		}

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
			// calculate bounding box
			// new gruop shape
			// subshape = selection
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
			using (Bitmap bmp = new Bitmap(this.Width, this.Height))
			{
				this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
				bmp.Save(@"C:\Users\Радостин\Desktop\Нова папка (10)\sample.png", ImageFormat.Png); // make sure path exists!
			}
		}

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Stream myStream;
			SaveFileDialog savefile1 = new SaveFileDialog();
			List<Type> g = new List<Type>();
			savefile1.Filter = "xml files |*.xml";
			savefile1.FilterIndex = 2;
			savefile1.RestoreDirectory = true;

			if (savefile1.ShowDialog() == DialogResult.OK)
			{
				if ((myStream = savefile1.OpenFile()) != null)
				{
					foreach(Shape item in dialogProcessor.ShapeList)
                    {
						g.Add(item.GetType().);
						

                    }
					foreach(Type type in g)
                    {
						Console.WriteLine(type.ToString());
				
						

					}
					triangleshape values = new triangleshape(new Rectangle(250, 250, 200, 200));
					values.Width = this.Width;
					values.Height = this.Height;
					values.Location = this.Location;
					myStream.Close();
					SaveValues(savefile1.FileName, values);
				}
				
			}
		}
		public void SaveValues(string fileName, Shape v)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(triangleshape));
			using (TextWriter textWriter = new StreamWriter(fileName))
			{
				serializer.Serialize(textWriter, v);
				textWriter.Close();
			}
}
	}
}

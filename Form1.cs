using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _11
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        public List<Point> points = new List<Point>();
        private Point point=new Point();
        private Point point2=new Point();        
        private Font font;
        private Brush brush;
        private int zagIndex = 0;
        private int ellipseCounter = 0;
        private int rectangleCounter = 0;
        private int poligonCounter = 0; 
        private int textCounter=0;
        private int lineCoynter = 0;
        string text;

        public Rectangle rectangle = new Rectangle(150, 10, 100, 50);
        public Rectangle ellipse=new Rectangle( 10,  10,  100,  50);
        
            

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 2);
            font = new Font("Arial", 16);
            brush = new SolidBrush(Color.Black);
        }
        private void еліпсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Elipse {++ellipseCounter}");
            graphics.DrawEllipse(pen, ellipse);
        }

        private void прямокутникToolStripMenuItem_Click(object sender, EventArgs e)
        {
             listBox1.Items.Add($"Прямокутник {++rectangleCounter}");
            zagIndex++;
                graphics.DrawRectangle(pen, rectangle);
            
           


        }

        

        private void полігонToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add($"Полігон {++poligonCounter}");

            points.Add(new Point(e.X, e.Y));

            if (points.Count>1)
            {
                graphics.DrawPolygon(pen, points.ToArray());

            }
        }

        

        private void лініяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Лінія {++lineCoynter}");
            graphics.DrawLine(pen, point, point2);
        }

        

        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text = textBox1.Text;
                Font font = new Font("Arial", 12);
                Brush brush = new SolidBrush(Color.Black);
                Point point = new Point(10, 10);
                graphics.DrawString(text, font, brush, point);
                listBox1.Items.Add($"Текст {++textCounter}");

            }
        }

        private void налаштуванняФігуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                pen = form2.pen;
                brush = form2.brush;
                font= form2.font;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == $"Прямокутник {rectangleCounter}")
                graphics.DrawRectangle(pen, rectangle.X + 300, rectangle.Y, rectangle.Width, rectangle.Height);

            if (listBox1.SelectedItem.ToString() == $"Elipse {ellipseCounter}")
                graphics.DrawEllipse(pen, ellipse.X + 300, ellipse.Y, ellipse.Width, ellipse.Height);

            if (listBox1.SelectedItem.ToString() == $"Полігон {poligonCounter}")
                graphics.DrawPolygon(pen, points.ToArray());

            if (listBox1.SelectedItem.ToString() == $"Лінія {lineCoynter}")
                graphics.DrawLine(pen, point, point2);

            if (listBox1.SelectedItem.ToString() == $"Текст {textCounter}")
                graphics.DrawString(text, font, brush, 10, 100);

        }
    }
}
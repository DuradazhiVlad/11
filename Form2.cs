using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form2 : Form
    {
        public Pen pen= new Pen(Color.Black, 10);
        public Font font=new Font("", 12);
        public SolidBrush brush = new SolidBrush(Color.Black);

        public Form2()
        {
            InitializeComponent();
            // comboBox1=colorDialog1.Container;
            comboBox1.SelectedIndex = (int)pen.DashStyle;
            comboBox2.SelectedIndex = (int)pen.StartCap;
            comboBox3.SelectedIndex = (int)pen.EndCap;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1= new Form1();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.DialogResult= DialogResult.OK;
            //if (colorDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    // дії, які необхідно виконати після вибору користувачем коліру
            //    this.BackColor = colorDialog1.Color; // змінити колір фону форми на обраний користувачем
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
               
                pen.Color = colorDialog1.Color;
                this.Refresh();
                brush = new SolidBrush(colorDialog1.Color);
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawLine(pen,new Point(50,50),new Point(250,50));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
            
            font=new Font("", trackBar1.Value);
            this.Refresh();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen.DashStyle = (DashStyle)comboBox1.SelectedIndex;
            this.Refresh();   

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            if (index > 3) index += 12;
            pen.StartCap = (LineCap)index;
            this.Refresh();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=comboBox2.SelectedIndex;
            if (index > 3) index += 12;
            pen.EndCap = (LineCap)index;
            this.Refresh();
        }
    }
}

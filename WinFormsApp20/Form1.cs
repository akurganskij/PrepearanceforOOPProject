using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20
{
    public partial class Form1 : Form
    {
        Rectangle rect = new Rectangle(300, 100, 200, 300);
        SolidBrush br = new SolidBrush(Color.Red);
        double angle = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {            
            PaintEventArgs paint = new PaintEventArgs(CreateGraphics(), rect);
            Rect_Paint(sender, paint);        
        }
        private void Rect_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.RotateTransform((float)angle, System.Drawing.Drawing2D.MatrixOrder.Append);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.FillRectangle(br, rect);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 1;
            this.Text = angle.ToString();
            this.Refresh();
        }

        private void Form1_Paint1(object sender, PaintEventArgs e)
        {
            e.Graphics.RotateTransform((float)angle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            br.Color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            this.Refresh();
        }
    }
}

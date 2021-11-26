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
        int t = 10;
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
            pictureBox1.Left += t;
            if (pictureBox1.Left >= 1800 || pictureBox1.Left <= 18)
                t *= -1;
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
            
            
        }
    }
}

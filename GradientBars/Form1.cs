using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GradientBars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            Rectangle rec = new Rectangle(0,0,this.Size.Width, this.Size.Height);

            LinearGradientBrush brush = new LinearGradientBrush(rec,Color.Blue, Color.Transparent,LinearGradientMode.BackwardDiagonal);

            g.FillRectangle(brush, rec);
        }

        

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}

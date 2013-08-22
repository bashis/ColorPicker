using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class ColorViewer : Form
    {
        public ColorViewer()
        {
            InitializeComponent();
        }
        private Color myColor=Color.Black;
        public Color MyColor 
        { 
            get { return myColor; }
            set 
            { 
                myColor = value;
                pictureBox1.BackColor = value;
                progressBar1.Value = value.R;
                label1.Text = "R: " + value.R;
                progressBar2.Value = value.G;
                label2.Text = "G: " + value.G;
                progressBar3.Value = value.B;
                label3.Text = "B: " + value.B;
            }
        }
        public ColorViewer(Color color)
        {
            InitializeComponent();
            MyColor = color;
        }
        private void ColorViewer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColorViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            this.Left = 0;
            this.Top = 0;


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int x = MousePosition.X, y = MousePosition.Y;
            this.Hide();
            Color myColor = Screenshot().GetPixel(x, y);
            (new ColorViewer(myColor)).Show();
        }

        public Bitmap Screenshot()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
                    0, 0, Screen.PrimaryScreen.Bounds.Size);
            }
            return bmp;
        }


    }
}

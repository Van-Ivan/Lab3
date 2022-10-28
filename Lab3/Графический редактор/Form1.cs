using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графический_редактор
{
    public partial class BitMap : Form
    {
        public BitMap()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        Color DefaultColor
        {
            get { return Color.White; }
        }

        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i=0; i<width; i++)
            {
                for (int j=0; j<height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

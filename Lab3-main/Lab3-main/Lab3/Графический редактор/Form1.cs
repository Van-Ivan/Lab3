﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        int _x, _y;
        bool _mouseClicked = false;
        Color SelectedColor { get { return Color.Red; } }
        int SelectedSize { get { return tbSizeBrush.Value; } }
        Brush _selectedBrush;






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) //Создать, не могу переименовать
        {
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e) //Выход, не могу переименовать
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
        }

        private void btnSpray_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SprayBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_mouseDown(object sender, MouseEventArgs e) //btn_swuere?
        {
            if (_selectedBrush == null) { return; }

            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) { _mouseClicked = false; }

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge;
using AForge.Imaging.Filters;

namespace Editor_Imágenes
{
    public partial class frmEditarImágenes : Form
    {
        
        public frmEditarImágenes()
        {
            InitializeComponent();
        }

        private void frmEditarImágenes_Load(object sender, EventArgs e)
        {
            
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            pcbImagen2.Image = grayscale.Apply((Bitmap)pcbImagen1.Image);
        }
    }
}

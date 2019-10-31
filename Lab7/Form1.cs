using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stabilizator Stab;

        private void drowHaractPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResultImageBox.Image == null ) ResultImageBox.Image = Stab.DrawHaractPoints(Stab.Image).Resize(FirstImageBox.Width, FirstImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
            else
            {
                FirstImageBox.Image = Stab.DrawHaractPoints(Stab.Image).Resize(FirstImageBox.Width, FirstImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
                ResultImageBox.Image = Stab.DrawHaractPoints(Stab.SecondImage).Resize(FirstImageBox.Width, FirstImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
            }
        }

        private void fitrstImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            var result = OFD.ShowDialog();

            if (result == DialogResult.OK)
            {
                Stab = new Stabilizator(OFD.FileName);

                FirstImageBox.Image = new Image<Bgr, byte>(OFD.FileName).Resize(FirstImageBox.Width, FirstImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
            }
        }

        private void secondImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            var result = OFD.ShowDialog();

            if (result == DialogResult.OK)
            {
                Stab.LoadSecondImage(OFD.FileName);

                ResultImageBox.Image = new Image<Bgr, byte>(OFD.FileName).Resize(FirstImageBox.Width, FirstImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
            }
            
        }

        private void stabilizateImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Stab.SecondImage != null && Stab.Image!=null)
            {
                FirstImageBox.Image = Stab.DrawHaractPoints(Stab.Image).Resize(FirstImageBox.Width, FirstImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
                ResultImageBox.Image = Stab.DrawLukasKanade().Resize(ResultImageBox.Width, ResultImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
            }
            else MessageBox.Show("Изображение не загружено или загружено только одно");
        }

        private void homographyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultImageBox.Image = Stab.Stabilizate().Resize(ResultImageBox.Width, ResultImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
        }
        
        private void GetBriskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultImageBox.Image = Stab.GetBriskPoints().Resize(ResultImageBox.Width, ResultImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
        }
    }
}

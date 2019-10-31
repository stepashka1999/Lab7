using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;


namespace Lab7
{
    class Stabilizator
    {
        /*--- Initialisation ---*/
        public Image<Bgr, byte> Image { get; private set; }
        public Image<Bgr, byte> SecondImage { get; private set; }
        
        // - Detectors
        GFTTDetector detector = new GFTTDetector(40, 0.01, 5, 3, true);
        Brisk BriskDetector = new Brisk();
        FastFeatureDetector FastDetector = new FastFeatureDetector();

        public Stabilizator(string FileName)
        {
            Image = new Image<Bgr, byte>(FileName);
        }

        public void LoadSecondImage(string FileName)
        {
            SecondImage = new Image<Bgr, byte>(FileName);
        }


        private MKeyPoint[] GetGFTPoints(Image<Bgr,byte> img)
        {
            MKeyPoint[] points = detector.Detect(img.Copy().Convert<Gray, byte>().Mat);

            return points;
        }

        private MKeyPoint[] GetBriskPoints(Image<Bgr, byte> img)
        {
            MKeyPoint[] points = BriskDetector.Detect(img.Copy().Convert<Gray, byte>().Mat);

            return points;
        }

        private MKeyPoint[] GetFastDPoints(Image<Bgr, byte> img)
        {
            MKeyPoint[] points = FastDetector.Detect(img.Copy().Convert<Gray, byte>().Mat);

            return points;
        }

        public Image<Bgr,byte> DrawHaractPoints(Image<Bgr,byte> img)
        {
            var points = GetGFTPoints(img);//Looks like better method of another

            var tempImg = img.Copy();

            foreach (MKeyPoint p in points)
                CvInvoke.Circle(tempImg, Point.Round(p.Point), 6, new Bgr(Color.GreenYellow).MCvScalar, 2);

            return tempImg;
        }

        private PointF[] MKeyToPoint(MKeyPoint[] GFTP)
        {
            PointF[] srcPoints = new PointF[GFTP.Length];

            for (int i = 0; i < GFTP.Length; i++)
                srcPoints[i] = GFTP[i].Point;

            return srcPoints;
        }

        private PointF[] LukasKanade()
        {
            var GFTP = GetGFTPoints(Image);

            var srcPoints = MKeyToPoint(GFTP);

            PointF[] destPoints; //Array for haract points of the detImage

            byte[] status; // status of points (Found / Not Found)
            float[] trackErrors; //Errors

            CvInvoke.CalcOpticalFlowPyrLK(Image.Convert<Gray, byte>().Mat, SecondImage.Convert<Gray, byte>().Mat, srcPoints, new Size(20, 20), 5, new MCvTermCriteria(20, 1), out destPoints, out status, out trackErrors);
            /* |--- Params ---|
             | 1 - First Image
             | 2 - Second Image
             | 3 - Array of the Sourse Image
             | 4 - Size of the Find Window
             | 5 - Level of the Pyramid
             | 6 - Stop condition
             | 7 - Position haract points on the new Image
             | 8 - "1" if Found and "0" if Not Found
             | 9 - Array for Errors
             */

            return destPoints;
        }

        public Image<Bgr,byte> DrawLukasKanade()
        {
            var resImg = SecondImage.Copy();

            var destPoints = LukasKanade();

            foreach(PointF p in destPoints)
                CvInvoke.Circle(resImg, Point.Round(p), 6, new Bgr(Color.GreenYellow).MCvScalar, 2);

            return resImg;
        }
       
        public Image<Bgr,byte> Stabilizate()
        {
            var destPoints = LukasKanade();
            var srcPoints = MKeyToPoint(GetGFTPoints(Image));

            Mat homographyMatrix = CvInvoke.FindHomography(destPoints, srcPoints);

            var destImage = new Image<Bgr, byte>(Image.Size);

            CvInvoke.WarpPerspective(SecondImage, destImage, homographyMatrix, destImage.Size);

            return destImage;
        }
       

    }
}

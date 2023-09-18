using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;



namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Capture webcam;
        CascadeClassifier haar;

        private DateTime lastScreenshotTime = DateTime.MinValue;

        private void Form2_Load(object sender, EventArgs e)
        {
            webcam = new Capture(0);
            haar = new CascadeClassifier("haarcascade_frontalface_default.xml");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Image = null;
        }

        private int screenshotCounter = 0; // Initialize a counter for screenshot filenames

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> binaryGoruntu = webcam.QueryFrame().ToImage<Bgr, Byte>())
            {
                if (binaryGoruntu != null)
                {
                    Image<Gray, byte> greyScaleGoruntu = binaryGoruntu.Convert<Gray, byte>();
                    Rectangle[] rectangles = haar.DetectMultiScale(greyScaleGoruntu, 1.4, 1, new Size(100, 100), new Size(800, 800));

                    foreach (var detectedObject in rectangles)
                    {
                        binaryGoruntu.Draw(detectedObject, new Bgr(0, double.MaxValue, 0), 3);

                        // Capture and save a screenshot whenever an object resembling a person is detected
                        string screenshotFileName = $"person_related_{screenshotCounter}.png";
                        string screenshotPath = Path.Combine("C:/Users/RUTHMAGALLANES/Desktop/ScreenShot", screenshotFileName);
                        binaryGoruntu.Save(screenshotPath);
                        screenshotCounter++;
                    }

                    pictureBox1.Image = binaryGoruntu.ToBitmap();
                }
            }
        }


    }
}



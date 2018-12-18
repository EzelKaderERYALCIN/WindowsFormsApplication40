using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Vision;
using AForge.Vision.Motion;


namespace WindowsFormsApplication40
{
    public partial class objectFollow : Form
    {
        private FilterInfoCollection cameras; //cameras isminde tanımladığımız değişken bilgisayara kaç kamera bağlıysa onları tutan bir dizi.
        private VideoCaptureDevice usedcamera; //usedcamera ise bizim kullanacağımız kamera.

        public objectFollow()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = arduinoportBox.SelectedItem.ToString(); //arduinonun bağlı olduğu portu arduinoportbox'a yaz
            serialPort1.BaudRate = 9600;//haberleşme hızı
            serialPort1.Open();//haberleşmeyi aç
        }

        private void objectFollow_Load(object sender, EventArgs e)
        {
            arduinoportBox.DataSource = SerialPort.GetPortNames();
            int numbers = arduinoportBox.Items.Count;
            if (numbers == 0)
            {
                arduinoportBox.Enabled = false;
                btnconnect.Enabled = false;
            }
            else
            {
                arduinoportBox.Enabled = true;
                btnconnect.Enabled = true;
            }

            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);// cameras dizisine mevcut kameraları dolduruyoruz.

            foreach (FilterInfo VideoCaptureDevice in cameras)
            {

               cameraBox.Items.Add(VideoCaptureDevice.Name);//kameraları camerabox a dolduruyoruz.
               cameraBox.SelectedIndex = 0;
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            usedcamera= new VideoCaptureDevice(cameras[cameraBox.SelectedIndex].MonikerString);//start a basıldığında yukarıda tanımladığımız usedcamera değişkenine cameraboxta seçilmiş olan kamerayı atıyoruz.
            usedcamera.NewFrame += new NewFrameEventHandler(usedcamera_NewFrame);
            usedcamera.Start();//kamerayı başlatır
        }

        void usedcamera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Console.WriteLine(image.Size);
            usedcamera.DesiredFrameSize = new Size(640, 320);
            Bitmap image1 = (Bitmap)eventArgs.Frame.Clone();
            sourceBox.Image = image;
            if (redButton1.Checked)
            {
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                filter.CenterColor = new RGB(Color.FromArgb(250,30, 30)); //algılanacak renk
                filter.Radius = 100;
                filter.ApplyInPlace(image1);//filtre uygulanır
                cevretara(image1);//algılanan rengi çerçevelemek için kullanılan kod.
            }
            if (greenButton1.Checked)
            {
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                filter.CenterColor = new RGB(Color.FromArgb(30,180, 30));
                filter.Radius = 100;
                filter.ApplyInPlace(image1);
                cevretara(image1);
            }
            if (blueButton1.Checked)
            {
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                filter.CenterColor = new RGB(Color.FromArgb(30, 30, 200));
                filter.Radius = 100;
                filter.ApplyInPlace(image1);
                cevretara(image1);

            }
        }

        private void cevretara(Bitmap image)
        {
            BlobCounter blobCounter = new BlobCounter(); //Yeni blobcounter oluşturma
            blobCounter.FilterBlobs = true;//blobcounter a filtre uygulanabilir
            blobCounter.MinWidth =5;// genişliği 5'nin altında olanları alma
            blobCounter.MinHeight = 5;
            blobCounter.ProcessImage(image);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            processedBox.Image = image;

            foreach (Rectangle recs in rects)
            {

                if (rects.Length > 0)
                {
                    Rectangle objectRect = rects[0];

                    Graphics g = sourceBox.CreateGraphics();
                    using (Pen pen = new Pen(Color.FromArgb(252,3, 26), 2))
                    {
                        g.DrawRectangle(pen, objectRect);
                    }

                    int axisX = objectRect.X + (objectRect.Width / 2);// dikdörtgenin x koordinatı alınır.
                    int axisY = objectRect.Y+(objectRect.Height / 2); ;//dikdörtgenin y koordinatı alınır.
                    if (axisX < 100 && axisY < 100)
                    {
                        serialPort1.Write("2");
                    }
                    else if ((axisX > 100 && axisX < 300) && (axisY < 100))
                    {
                        serialPort1.Write("3");
                    }
                    else if ((axisX > 427 && axisX < 640) && (axisY < 100))
                    {
                        serialPort1.Write("4");
                    }
                    else if ((axisX <100) && (axisY > 100 && axisY < 200))
                    {
                        serialPort1.Write("5");
                    }
                    else if ((axisX > 100 && axisX < 300) && (axisY > 100 && axisY < 200))
                    {
                        serialPort1.Write("6");
                    }
                    else if ((axisX > 427 && axisX < 640) && (axisY > 100 && axisY < 200))
                    {
                        serialPort1.Write("7");
                    }
                    else if ((axisX < 100) && (axisY > 240 && axisY <360))
                    {
                        serialPort1.Write("8");
                    }
                    else if ((axisX > 100 && axisX < 300) && (axisY > 240 && axisY < 360))
                    {
                        serialPort1.Write("9");
                    }
                    else if ((axisX > 426 && axisX < 640) && (axisY > 240 && axisY < 360))
                    {
                        serialPort1.Write("1");
                    }
                    g.DrawString(axisX.ToString() + "X" + axisY.ToString(), new Font("Arial", 12), Brushes.Red, new System.Drawing.Point(250, 1));
                    g.Dispose();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usedcamera.IsRunning)

            {

                usedcamera.Stop(); // kamerayı durdurur.

            }
        }
    }
}
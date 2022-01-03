using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using emguCV;
using ArduinoServerGit;
using System.Threading;
using System.Timers;
using System.IO.Ports;

namespace emguCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        Server server;
        SerialPort port;
        bool Is_Decleared=false;
        private void Device_Click(object sender, EventArgs e)
        {

        }

        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in filter)
            {
                cboDevice.Items.Add(info.Name);
            }
            cboDevice.SelectedIndex = 0;
            foreach (string com in SerialPort.GetPortNames())
            {
                ComCBO.Items.Add(com);
            }
            ComCBO.SelectedIndex = 0;
        }
        Thread thread;
        ParameterizedThreadStart imd;
        bool is_resSelected=false;
        
        private void btnDetect_Click(object sender, EventArgs e)
        {
            if (Is_Decleared == true)
            {
                device.VideoResolution = device.VideoCapabilities[ResCBO.SelectedIndex];

            }
            is_resSelected = true;
            //device.NewFrame += Device_NewFrame;
            //device.Start();
            

        }
        
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(@"C:\Users\PC\source\repos\emguCV\haarcascade_frontalface_alt_tree.xml");
        int x_pos;
        int y_pos;
        int sum_x;
        int sum_y;
        bool Is_Open = false;
        Bitmap bitmap;
        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            sum_x = 0;
            sum_y = 0;
            bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = bitmap.ToImage<Bgr, byte>();
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach (Rectangle rec in rectangles)
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        g.DrawRectangle(pen, rec);
                    }
                }
                sum_x += rec.X + (rec.Width) / 2;
                sum_y += rec.Y + (rec.Height) / 2;
            }

            if (rectangles.Length > 0)
            {
                x_pos = sum_x / rectangles.Length;
                y_pos = sum_y / rectangles.Length;
                
                
            }
            pictureBox1.Image = bitmap;


        }
        public void senderData()
        {
            int screenWidth;
            while (true)
            {
                if (bitmap != null && x_pos>0)
                {
                    
                    port.WriteLine($"{ToDegrees(x_pos, 1280)}");
                    Thread.Sleep(1000);
                }
            }

        }
        /* void ImageDetection(object _bitmap)
        {
            int  sum_x = 0;
            int  sum_y = 0;
            int y_pos;
            int x_pos;
            Bitmap _Bitmap = (Bitmap)_bitmap;
          
            if (_Bitmap != null)
            {
                try
                {
                    Image<Bgr, byte> grayImage = _Bitmap.ToImage<Bgr, byte>();
                    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
                    foreach (Rectangle rec in rectangles)
                    {
                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            using (Pen pen = new Pen(Color.Red, 1))
                            {
                                g.DrawRectangle(pen, rec);
                            }
                        }
                        sum_x += rec.X + (rec.Width) / 2;
                        sum_y += rec.Y + (rec.Height) / 2;

                    }
                    if (rectangles.Length > 0)
                    {
                        x_pos = sum_x / rectangles.Length;
                        y_pos = sum_y / rectangles.Length;
                    }
                    pictureBox1.Image = _Bitmap;

                }
                catch (Exception ex)
                {

                }

            }
            
        
        }
        */

        private int ToDegrees(int X,int screenWidth)
        {
            //the feild of view is 68.5
            /*double adder= screen.Width/68.5;
            int degree=0;
            for (var i = 0; i < screen.Width; i+=adder)
            {
                degree++;
                if (x>=i&&x<i+adder)
                {
                    return degree;
                }
            }
            */
            double pixelsfordegree= (int)(screenWidth/68.5);
            
                return (int) (X/pixelsfordegree);
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(device.IsRunning)
            {
                device.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            server = new Server();
            Is_Open = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(filter[cboDevice.SelectedIndex].MonikerString);
            for (int i = 0; i < device.VideoCapabilities.Length; i++)
            {
                ResCBO.Items.Add(device.VideoCapabilities[i].FrameSize.Width.ToString());
            }
            ResCBO.SelectedIndex = 0;
            Is_Decleared = true;
        }
        bool isCom = false;
        private void button3_Click(object sender, EventArgs e)
        {
            //Hi Nir
            if (is_resSelected)
            {
               
                port = new SerialPort(ComCBO.SelectedItem.ToString());
                port.Open();
                Thread t = new Thread(new ThreadStart(senderData));
                t.Start();
                device.NewFrame += Device_NewFrame;
                device.Start();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

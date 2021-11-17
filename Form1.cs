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
        bool Is_Connected;
        private void Device_Click(object sender, EventArgs e)
        {

        }

        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo info in filter)
            {
                cboDevice.Items.Add(info.Name);
            }
            cboDevice.SelectedIndex = 0;
            device = new VideoCaptureDevice();
            Is_Connected = false;
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(filter[cboDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(@"C:\Users\PC\source\repos\emguCV\cascade_front.xml");
        int x_pos;
        int y_pos;
        int sum_x;
        int sum_y;
        bool Is_Open = false;
        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            sum_x = 0;
            sum_y = 0;
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = bitmap.ToImage<Bgr, byte>();
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach(Rectangle rec in rectangles)
            {
                using(Graphics g=Graphics.FromImage(bitmap))
                {
                    using (Pen pen=new Pen(Color.Red,1))
                    {
                        g.DrawRectangle(pen, rec);
                    }
                }
                sum_x += rec.X + (rec.Width) / 2;
                sum_y += rec.Y + (rec.Height) / 2;
                
            }
            if ((rectangles.Length>0)&&Is_Open==true)
            {
                x_pos = sum_x / rectangles.Length;
                y_pos = sum_y / rectangles.Length;
                server.send($"{x_pos},{x_pos}");
                Thread.Sleep(100);
                
            }
            pictureBox1.Image = bitmap;
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
    }
}

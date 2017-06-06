using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace MultiDrawing
{
    public partial class Form1 : Form
    {
        Pen pen;
        Graphics graphics;
        KeyValuePair<int, int> coordinatesPair;
        List<KeyValuePair<int, int>> drawingCoordinates;

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        //NetworkStream serverStream; 
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(System.Drawing.Color.Red, 5);
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
            //graphics.DrawRectangle(pen, 10, 10, 1, 1);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            coordinatesPair = new KeyValuePair<int, int>();
            drawingCoordinates = new List<KeyValuePair<int, int>>();

            drawingCoordinates.Add(new KeyValuePair<int, int>(e.X, e.Y));
            graphics.DrawRectangle(pen, e.X, e.Y, 10, 10);
            Refresh();
        }

        

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                drawingCoordinates.Add(new KeyValuePair<int, int>(e.X, e.Y));
                graphics.DrawRectangle(pen, e.X, e.Y, 10, 10);
                Refresh();

            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            var binFormatter = new BinaryFormatter();

            binFormatter.Serialize(serverStream, drawingCoordinates);
            serverStream.Flush();
            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //foreach(KeyValuePair<int,int> pair in drawingCoordinates)
            //{
            //    Console.WriteLine(pair.Key + " " + pair.Value);
            //}

            clientSocket.Connect("127.0.0.1", 8888);
        }
    }
}

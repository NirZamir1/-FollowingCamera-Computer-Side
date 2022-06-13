using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Net;
using System.Text.Encodings;
namespace ArduinoServerGit
{
    public class Server
    {
        const int port = 5000;// ethernet port;
        IPHostEntry hostEntry;//host for constent adress;
        IPAddress IP;//IP
        TcpClient client; //Client
        TcpListener listen;//Listener for clients
        NetworkStream nwStream;
        Thread R;
        string DataToSend;
        bool isListening = true;
        public bool Is_Connected { get=>client.Connected;}
        public Server()
        {
            hostEntry = Dns.GetHostEntry("Enter The Name");
            IP = hostEntry.AddressList[1];
            Console.WriteLine(IP);
            listen = new TcpListener(IP, port);
            listen.Start();
            client = new TcpClient();
            R = new Thread(new ThreadStart(Run));
            R.Start();
        }
        public void Run()
        {
            while (isListening == true)
            {
                while (listen.Pending())
                {
                    client = listen.AcceptTcpClient();
                }
            }
        }
        public void send(string Data)
        {
            if (client.Connected)
            {
                try
                {   
                    byte[] data;
                    nwStream = client.GetStream();
                    DataToSend = Data;
                    data = Encoding.ASCII.GetBytes(DataToSend);
                    nwStream.Write(data, 0, data.Length);                   
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}

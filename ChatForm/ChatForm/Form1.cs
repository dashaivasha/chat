using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Xml.Serialization;

namespace ChatForm
{
    public partial class AntWork : Form
    {
        public AntWork()
        {
            InitializeComponent();

        }
        const string pathAdmin = @"E:\даша\AdminTRUE\admins.xml";
        List<Admins> admins = new List<Admins>();

        static string userName;
        private const string host = "192.168.43.11";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        static bool wait = true;
        Thread receiveThread;




        static void SendMessage(string message)
        {
                
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
            
            
        }
        // получение сообщений
        public void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    if (!wait) return;
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    if (message.Contains("$$$#!"))
                    {
                        message = message.Replace("$$$#!", "");
                        listUser.Items.Clear();
                        foreach (string username in message.Split(','))
                        {
                            listUser.Items.Add(username);
                        }
                    } else
                    {
                        listMessage.Items.Add(message);
                    }

                }
                catch
                {
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }
        static void Disconnect()
        {
            if (stream != null)
            {
                stream.Close();
                stream = null;
            }
            if (client != null)
            {
                client.Close();//отключение клиента
                client = null;
            }
            wait = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string messag = Mess.Text;
                SendMessage(messag);
                listMessage.Items.Add("Я:" + messag);
                Mess.Clear();
            }
            catch (Exception ex)
            {
                Disconnect();
                Console.WriteLine(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Admins s = admins.Find((admin) => admin.Login == LoginEnter.Text);
            label5.Text = "Добро пожаловать: " + userName;
            if (LoginEnter.Text == "" || PassEnter.Text == "")
            {
                EnetLogorPass.Visible = true;
                Citata.Visible = false;
            }
            if (s == null)
            {
                EnetLogorPass.Visible = true;
                Citata.Visible = false;

            }
            else
            if (s.Pass == PassEnter.Text)
            {
                RealAdmin.FIO = s.Fio;
                RealAdmin.Org = s.Organization;
                EnetLogorPass.Visible = false;
                ErrorTxt.Visible = false;
                pictureBox4.Visible = false;
                panel4.Visible = false;
                panel4.Visible = false; 
                client = new TcpClient();
                userName = LoginEnter.Text;
                try
                {
                    client.Connect(host, port); //подключение клиента
                    stream = client.GetStream(); // получаем поток
                    string message = userName;
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    // запускаем новый поток для получения данных
                    receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                    receiveThread.Start(); //старт потока
                    label5.Text = "Добро пожаловать:  " + userName;
                }
                catch (Exception ex)
                {
                    Disconnect();
                    Console.WriteLine(ex.Message);
                }
            }
        
            else
            {
                EnetLogorPass.Visible = false;
                ErrorTxt.Visible = true;
                Citata.Visible = false;
            }
        }
        public static class RealAdmin
        {
            public static string FIO;
            public static string Org;
        }

        private void AntWork_Load(object sender, EventArgs e)
        {
            XmlSerializer serializer1 = new XmlSerializer(typeof(List<Admins>));
            StreamReader reader1 = new StreamReader(pathAdmin);
            admins = (List<Admins>)serializer1.Deserialize(reader1);
            reader1.Close();
        }

        private void AntWork_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("E:\\даша\\ChatForm\\ChatForm\\1.txt", true);
            foreach (var item in listMessage.Items)
                writer.WriteLine(item.ToString());
            writer.Close();

            /*TextWriter writer = new StreamWriter(@"E:\ChatForm\ChatForm\1.txt");
                   
                foreach (var item in listMessage.Items)
                    writer.WriteLine(item.ToString());*/

           
            writer.Close();
            Disconnect();
        }

        private void AntWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void EnetLogorPass_Click(object sender, EventArgs e)
        {

        }

        private void ErrorTxt_Click(object sender, EventArgs e)
        {

        }

        private void LoginEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Проект разработан в рамках УП ТРПО, при поддержке ИП КриВо");
        }

        private void Citata_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void PassEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listFind.Visible = true;
            listHistory.Visible = false;
            listHistory.Items.Add(listHistory.FindString(textBox1.Text));
            bool found = false;
         
            foreach (object a in listHistory.Items)
            {
                if (a.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    found = true;
                    listFind.Items.Add(a);
                    
                   
                }

            }
            if (!found)
            {
                MessageBox.Show("Ничего не найдено");
            }
           

        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listHistory.Visible = true;
            listFind.Visible = false;
            listHistory.Items.Clear();

            TextReader reader = new StreamReader(@"E:\даша\ChatForm\ChatForm\1.txt");
            string t;
            while ((t = reader.ReadLine()) != null)
            {

                listHistory.Items.Add(t);
            }

            reader.Close();
           

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AntWork_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

      

        private void Mess_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {

                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        string messag = Mess.Text;
                        SendMessage(messag);
                        listMessage.Items.Add("Я:" + messag);
                        Mess.Clear();
                    }
                    catch (Exception ex)
                    {
                        Disconnect();
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Pod.Visible = true;
                 
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Pod.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
              
             
        }
    }
}

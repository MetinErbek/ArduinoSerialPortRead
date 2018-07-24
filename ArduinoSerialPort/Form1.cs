using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;


namespace ArduinoSerialPort
{
    public partial class SerialPortRead : Form
    {
        string[] portlar = SerialPort.GetPortNames();

        public SerialPortRead()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (string port in portlar)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.SelectedIndex = 1;
            txtStatus.Text = "Bağlantı kapalı";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string sonuc = serialPort1.ReadExisting();
                txtData.Text = sonuc;

                switch (txtData.Text)
                {
                    case "0": picChane.Image = Properties.Resources.videoplayback___2of2_01; break;
                    case "1": picChane.Image = Properties.Resources.videoplayback___2of2_02; break;
                    case "2": picChane.Image = Properties.Resources.videoplayback___2of2_03; break;
                    case "3": picChane.Image = Properties.Resources.videoplayback___2of2_04; break;
                    case "4": picChane.Image = Properties.Resources.videoplayback___2of2_05; break;
                    case "5": picChane.Image = Properties.Resources.videoplayback___2of2_06; break;
                    case "6": picChane.Image = Properties.Resources.videoplayback___2of2_07; break;
                    case "7": picChane.Image = Properties.Resources.videoplayback___2of2_08; break;
                    case "8": picChane.Image = Properties.Resources.videoplayback___2of2_09; break;
                    case "9": picChane.Image = Properties.Resources.videoplayback___2of2_10; break;
                    case "10": picChane.Image = Properties.Resources.videoplayback___2of2_11; break;
                    case "11": picChane.Image = Properties.Resources.videoplayback___2of2_12; break;
                    case "12": picChane.Image = Properties.Resources.videoplayback___2of2_13; break;
                    case "13": picChane.Image = Properties.Resources.videoplayback___2of2_14; break;
                    case "14": picChane.Image = Properties.Resources.videoplayback___2of2_15; break;
                    case "15": picChane.Image = Properties.Resources.videoplayback___2of2_16; break;
                    case "16": picChane.Image = Properties.Resources.videoplayback___2of2_17; break;
                    case "17": picChane.Image = Properties.Resources.videoplayback___2of2_18; break;
                    case "18": picChane.Image = Properties.Resources.videoplayback___2of2_19; break;
                    case "19": picChane.Image = Properties.Resources.videoplayback___2of2_20; break;
                    case "20": picChane.Image = Properties.Resources.videoplayback___2of2_21; break;
                    case "21": picChane.Image = Properties.Resources.videoplayback___2of2_22; break;
                    case "22": picChane.Image = Properties.Resources.videoplayback___2of2_23; break;
                    case "23": picChane.Image = Properties.Resources.videoplayback___2of2_24; break;
                    case "24": picChane.Image = Properties.Resources.videoplayback___2of2_25; break;
                    case "25": picChane.Image = Properties.Resources.videoplayback___2of2_26; break;
                    case "26": picChane.Image = Properties.Resources.videoplayback___2of2_27; break;
                    case "27": picChane.Image = Properties.Resources.videoplayback___2of2_28; break;
                    case "28": picChane.Image = Properties.Resources.videoplayback___2of2_29; break;
                    case "29": picChane.Image = Properties.Resources.videoplayback___2of2_30; break;
                    case "30": picChane.Image = Properties.Resources.videoplayback___2of2_31; break;
                    case "31": picChane.Image = Properties.Resources.videoplayback___2of2_32; break;
                    case "32": picChane.Image = Properties.Resources.videoplayback___2of2_33; break;
                    case "33": picChane.Image = Properties.Resources.videoplayback___2of2_34; break;
                    case "34": picChane.Image = Properties.Resources.videoplayback___2of2_35; break;
                    case "35": picChane.Image = Properties.Resources.videoplayback___2of2_36; break;
                    case "36": picChane.Image = Properties.Resources.videoplayback___2of2_37; break;
                    case "37": picChane.Image = Properties.Resources.videoplayback___2of2_38; break;
                    case "38": picChane.Image = Properties.Resources.videoplayback___2of2_39; break;
                    case "39": picChane.Image = Properties.Resources.videoplayback___2of2_40; break;

                }
          

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Stop();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (serialPort1.IsOpen == false)
            {
                if (comboBox1.Text == "")
                    return;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt16(comboBox2.Text);
                try
                {
                    serialPort1.Open();
                    txtStatus.Text = "Bağlantı açık";
                }
                catch (Exception hata)
                {
                    MessageBox.Show("hata:" + hata.Message);
                }
            }
            else
            {
                txtStatus.Text = "bağlantı ok";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                txtStatus.Text = "bağlantı kapalı";
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if
                (serialPort1.IsOpen == true)
                serialPort1.Close();
        }
    }
    internal class serialPort1
    {


    }
}


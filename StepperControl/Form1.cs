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

namespace StepperControl
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cb_port.Items.AddRange(ports);
            btn_disconect.Enabled = false;
            btn_connection.Enabled = true;
            
        }

        private void Btn_connection_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cb_port.Text;
                serialPort1.BaudRate = Convert.ToInt32(cb_boundRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cb_dataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cb_stopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cb_parityBits.Text);

                serialPort1.Open();
                pb_status.Value = 100;
                btn_connection.Enabled = false;
                btn_disconect.Enabled = true;
            }
            catch (Exception err){
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Btn_disconect_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                pb_status.Value = 0;
                btn_connection.Enabled = true;
                btn_disconect.Enabled = false;
            }
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tb_angle.Text+ tb_acceleretion.Text;
                serialPort1.WriteLine(dataOUT);
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            tb_recive.Text = dataIN;
        }
    }
}

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
        int dataInt;

        string front;
        string dir;
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

            tb_angle.Enabled = false;
            tb_maxSpeed.Enabled = false;
            tb_acceleretion.Enabled = false;
            tb_deceleration.Enabled = false;
            cb_dir.Enabled = false;
            cb_front.Enabled = false;
            btn_send.Enabled = false;
            
            
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

                tb_angle.Enabled = true;
                tb_maxSpeed.Enabled = true;
                tb_acceleretion.Enabled = true;
                tb_deceleration.Enabled = true;
                cb_dir.Enabled = true;
                cb_front.Enabled = true;
                btn_send.Enabled = true;

                cb_front.SelectedIndex = 1;
                cb_dir.SelectedIndex = 1;
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
                tb_recive.Text = "";

                tb_angle.Enabled = false;
                tb_maxSpeed.Enabled = false;
                tb_acceleretion.Enabled = false;
                tb_deceleration.Enabled = false;
                cb_dir.Enabled = false;
                cb_front.Enabled = false;
                btn_send.Enabled = false;
               

            }
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
               serialPort1.WriteLine(tb_angle.Text);
                dataOUT = tb_angle.Text+ tb_maxSpeed.Text+tb_acceleretion.Text + tb_deceleration.Text;
                serialPort1.WriteLine(tb_angle.Text);
                serialPort1.WriteLine(tb_maxSpeed.Text);
                serialPort1.WriteLine(tb_acceleretion.Text);
                serialPort1.WriteLine(tb_deceleration.Text);
                if (cb_dir.Text == "По часовой")
                {
                    serialPort1.WriteLine("1");
                }
                else
                {
                    serialPort1.WriteLine("2");
                }
                if (cb_front.Text == "Линейный")
                {
                    serialPort1.WriteLine("1");
                }else if(cb_front.Text == "S-кривая")
                {
                    serialPort1.WriteLine("2");

                }
                else
                {
                    serialPort1.WriteLine("3");

                }

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

            /*    dataInt = Int32.Parse(dataIN);
                if (dataInt == 1) { 
                tb_recive.Text = "Данные пришли";
            }else if(dataInt == 2)
                {
                    tb_recive.Text = "Ошибка приёма данных";
                }*/





        }

        private void Tb_angle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                  && !char.IsDigit(e.KeyChar)
                  && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Tb_maxSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                  && !char.IsDigit(e.KeyChar)
                  && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Tb_acceleretion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                  && !char.IsDigit(e.KeyChar)
                  && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Tb_deceleration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                  && !char.IsDigit(e.KeyChar)
                  && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }


    }
}

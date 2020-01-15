namespace StepperControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_connection = new System.Windows.Forms.Button();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_boundRate = new System.Windows.Forms.ComboBox();
            this.l_baudRate = new System.Windows.Forms.Label();
            this.tb_recive = new System.Windows.Forms.TextBox();
            this.tb_angle = new System.Windows.Forms.TextBox();
            this.L_angle = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.l_dataBits = new System.Windows.Forms.Label();
            this.l_stopBits = new System.Windows.Forms.Label();
            this.l_parityBits = new System.Windows.Forms.Label();
            this.cb_dataBits = new System.Windows.Forms.ComboBox();
            this.cb_stopBits = new System.Windows.Forms.ComboBox();
            this.cb_parityBits = new System.Windows.Forms.ComboBox();
            this.btn_disconect = new System.Windows.Forms.Button();
            this.pb_status = new System.Windows.Forms.ProgressBar();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connection
            // 
            this.btn_connection.Location = new System.Drawing.Point(12, 196);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(99, 40);
            this.btn_connection.TabIndex = 0;
            this.btn_connection.Text = "Подключиться";
            this.btn_connection.UseVisualStyleBackColor = true;
            this.btn_connection.Click += new System.EventHandler(this.Btn_connection_Click);
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(100, 48);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(121, 21);
            this.cb_port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "СOM-порт";
            // 
            // cb_boundRate
            // 
            this.cb_boundRate.FormattingEnabled = true;
            this.cb_boundRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cb_boundRate.Location = new System.Drawing.Point(100, 75);
            this.cb_boundRate.Name = "cb_boundRate";
            this.cb_boundRate.Size = new System.Drawing.Size(121, 21);
            this.cb_boundRate.TabIndex = 3;
            this.cb_boundRate.Text = "9600";
            // 
            // l_baudRate
            // 
            this.l_baudRate.AutoSize = true;
            this.l_baudRate.Location = new System.Drawing.Point(9, 83);
            this.l_baudRate.Name = "l_baudRate";
            this.l_baudRate.Size = new System.Drawing.Size(79, 13);
            this.l_baudRate.TabIndex = 4;
            this.l_baudRate.Text = "Скорость, бод";
            // 
            // tb_recive
            // 
            this.tb_recive.Location = new System.Drawing.Point(12, 279);
            this.tb_recive.Multiline = true;
            this.tb_recive.Name = "tb_recive";
            this.tb_recive.Size = new System.Drawing.Size(533, 116);
            this.tb_recive.TabIndex = 5;
            // 
            // tb_angle
            // 
            this.tb_angle.Location = new System.Drawing.Point(334, 48);
            this.tb_angle.Name = "tb_angle";
            this.tb_angle.Size = new System.Drawing.Size(121, 20);
            this.tb_angle.TabIndex = 6;
            // 
            // L_angle
            // 
            this.L_angle.AutoSize = true;
            this.L_angle.Location = new System.Drawing.Point(267, 51);
            this.L_angle.Name = "L_angle";
            this.L_angle.Size = new System.Drawing.Size(61, 13);
            this.L_angle.TabIndex = 7;
            this.L_angle.Text = "Угол, град";
            // 
            // l_dataBits
            // 
            this.l_dataBits.AutoSize = true;
            this.l_dataBits.Location = new System.Drawing.Point(9, 109);
            this.l_dataBits.Name = "l_dataBits";
            this.l_dataBits.Size = new System.Drawing.Size(61, 13);
            this.l_dataBits.TabIndex = 8;
            this.l_dataBits.Text = "Кол-во бит";
            // 
            // l_stopBits
            // 
            this.l_stopBits.AutoSize = true;
            this.l_stopBits.Location = new System.Drawing.Point(9, 135);
            this.l_stopBits.Name = "l_stopBits";
            this.l_stopBits.Size = new System.Drawing.Size(87, 13);
            this.l_stopBits.TabIndex = 9;
            this.l_stopBits.Text = "Кол-во стоп-бит";
            // 
            // l_parityBits
            // 
            this.l_parityBits.AutoSize = true;
            this.l_parityBits.Location = new System.Drawing.Point(9, 157);
            this.l_parityBits.Name = "l_parityBits";
            this.l_parityBits.Size = new System.Drawing.Size(73, 13);
            this.l_parityBits.TabIndex = 10;
            this.l_parityBits.Text = "Бит чётности";
            // 
            // cb_dataBits
            // 
            this.cb_dataBits.FormattingEnabled = true;
            this.cb_dataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cb_dataBits.Location = new System.Drawing.Point(100, 101);
            this.cb_dataBits.Name = "cb_dataBits";
            this.cb_dataBits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_dataBits.Size = new System.Drawing.Size(121, 21);
            this.cb_dataBits.TabIndex = 3;
            this.cb_dataBits.Text = "8";
            // 
            // cb_stopBits
            // 
            this.cb_stopBits.FormattingEnabled = true;
            this.cb_stopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_stopBits.Location = new System.Drawing.Point(100, 127);
            this.cb_stopBits.Name = "cb_stopBits";
            this.cb_stopBits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_stopBits.Size = new System.Drawing.Size(121, 21);
            this.cb_stopBits.TabIndex = 3;
            this.cb_stopBits.Text = "1";
            // 
            // cb_parityBits
            // 
            this.cb_parityBits.FormattingEnabled = true;
            this.cb_parityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cb_parityBits.Location = new System.Drawing.Point(100, 153);
            this.cb_parityBits.Name = "cb_parityBits";
            this.cb_parityBits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_parityBits.Size = new System.Drawing.Size(121, 21);
            this.cb_parityBits.TabIndex = 3;
            this.cb_parityBits.Text = "None";
            // 
            // btn_disconect
            // 
            this.btn_disconect.Location = new System.Drawing.Point(122, 196);
            this.btn_disconect.Name = "btn_disconect";
            this.btn_disconect.Size = new System.Drawing.Size(99, 40);
            this.btn_disconect.TabIndex = 0;
            this.btn_disconect.Text = "Отключиться";
            this.btn_disconect.UseVisualStyleBackColor = true;
            this.btn_disconect.Click += new System.EventHandler(this.Btn_disconect_Click);
            // 
            // pb_status
            // 
            this.pb_status.Location = new System.Drawing.Point(12, 242);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(209, 23);
            this.pb_status.TabIndex = 11;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(408, 229);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 12;
            this.btn_send.Text = "Старт";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.pb_status);
            this.Controls.Add(this.l_parityBits);
            this.Controls.Add(this.l_stopBits);
            this.Controls.Add(this.l_dataBits);
            this.Controls.Add(this.L_angle);
            this.Controls.Add(this.tb_angle);
            this.Controls.Add(this.tb_recive);
            this.Controls.Add(this.l_baudRate);
            this.Controls.Add(this.cb_parityBits);
            this.Controls.Add(this.cb_stopBits);
            this.Controls.Add(this.cb_dataBits);
            this.Controls.Add(this.cb_boundRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_port);
            this.Controls.Add(this.btn_disconect);
            this.Controls.Add(this.btn_connection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_boundRate;
        private System.Windows.Forms.Label l_baudRate;
        private System.Windows.Forms.TextBox tb_recive;
        private System.Windows.Forms.TextBox tb_angle;
        private System.Windows.Forms.Label L_angle;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label l_dataBits;
        private System.Windows.Forms.Label l_stopBits;
        private System.Windows.Forms.Label l_parityBits;
        private System.Windows.Forms.ComboBox cb_dataBits;
        private System.Windows.Forms.ComboBox cb_stopBits;
        private System.Windows.Forms.ComboBox cb_parityBits;
        private System.Windows.Forms.Button btn_disconect;
        private System.Windows.Forms.ProgressBar pb_status;
        private System.Windows.Forms.Button btn_send;
    }
}


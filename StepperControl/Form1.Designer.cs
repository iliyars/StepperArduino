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
            this.tb_maxSpeed = new System.Windows.Forms.TextBox();
            this.tb_acceleretion = new System.Windows.Forms.TextBox();
            this.tb_deceleration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_front = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_dir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_comFields = new System.Windows.Forms.GroupBox();
            this.gb_connecionBtns = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_comFields.SuspendLayout();
            this.gb_connecionBtns.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connection
            // 
            this.btn_connection.Location = new System.Drawing.Point(0, 23);
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
            this.cb_port.Location = new System.Drawing.Point(102, 19);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(121, 21);
            this.cb_port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
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
            "9600",
            "115200"});
            this.cb_boundRate.Location = new System.Drawing.Point(102, 46);
            this.cb_boundRate.Name = "cb_boundRate";
            this.cb_boundRate.Size = new System.Drawing.Size(121, 21);
            this.cb_boundRate.TabIndex = 3;
            this.cb_boundRate.Text = "115200";
            // 
            // l_baudRate
            // 
            this.l_baudRate.AutoSize = true;
            this.l_baudRate.Location = new System.Drawing.Point(11, 54);
            this.l_baudRate.Name = "l_baudRate";
            this.l_baudRate.Size = new System.Drawing.Size(79, 13);
            this.l_baudRate.TabIndex = 4;
            this.l_baudRate.Text = "Скорость, бод";
            // 
            // tb_recive
            // 
            this.tb_recive.Location = new System.Drawing.Point(12, 295);
            this.tb_recive.Multiline = true;
            this.tb_recive.Name = "tb_recive";
            this.tb_recive.Size = new System.Drawing.Size(508, 116);
            this.tb_recive.TabIndex = 5;
            // 
            // tb_angle
            // 
            this.tb_angle.Location = new System.Drawing.Point(145, 20);
            this.tb_angle.Name = "tb_angle";
            this.tb_angle.Size = new System.Drawing.Size(103, 20);
            this.tb_angle.TabIndex = 6;
            this.tb_angle.Text = "0";
            this.tb_angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_angle_KeyPress);
            // 
            // L_angle
            // 
            this.L_angle.AutoSize = true;
            this.L_angle.Location = new System.Drawing.Point(16, 31);
            this.L_angle.Name = "L_angle";
            this.L_angle.Size = new System.Drawing.Size(61, 13);
            this.L_angle.TabIndex = 7;
            this.L_angle.Text = "Угол, град";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // l_dataBits
            // 
            this.l_dataBits.AutoSize = true;
            this.l_dataBits.Location = new System.Drawing.Point(11, 80);
            this.l_dataBits.Name = "l_dataBits";
            this.l_dataBits.Size = new System.Drawing.Size(61, 13);
            this.l_dataBits.TabIndex = 8;
            this.l_dataBits.Text = "Кол-во бит";
            // 
            // l_stopBits
            // 
            this.l_stopBits.AutoSize = true;
            this.l_stopBits.Location = new System.Drawing.Point(11, 106);
            this.l_stopBits.Name = "l_stopBits";
            this.l_stopBits.Size = new System.Drawing.Size(87, 13);
            this.l_stopBits.TabIndex = 9;
            this.l_stopBits.Text = "Кол-во стоп-бит";
            // 
            // l_parityBits
            // 
            this.l_parityBits.AutoSize = true;
            this.l_parityBits.Location = new System.Drawing.Point(11, 128);
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
            this.cb_dataBits.Location = new System.Drawing.Point(102, 72);
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
            this.cb_stopBits.Location = new System.Drawing.Point(102, 98);
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
            this.cb_parityBits.Location = new System.Drawing.Point(102, 124);
            this.cb_parityBits.Name = "cb_parityBits";
            this.cb_parityBits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_parityBits.Size = new System.Drawing.Size(121, 21);
            this.cb_parityBits.TabIndex = 3;
            this.cb_parityBits.Text = "None";
            // 
            // btn_disconect
            // 
            this.btn_disconect.Location = new System.Drawing.Point(112, 23);
            this.btn_disconect.Name = "btn_disconect";
            this.btn_disconect.Size = new System.Drawing.Size(99, 40);
            this.btn_disconect.TabIndex = 0;
            this.btn_disconect.Text = "Отключиться";
            this.btn_disconect.UseVisualStyleBackColor = true;
            this.btn_disconect.Click += new System.EventHandler(this.Btn_disconect_Click);
            // 
            // pb_status
            // 
            this.pb_status.Location = new System.Drawing.Point(2, 69);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(209, 23);
            this.pb_status.TabIndex = 11;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(16, 191);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 40);
            this.btn_send.TabIndex = 12;
            this.btn_send.Text = "Старт";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // tb_maxSpeed
            // 
            this.tb_maxSpeed.Location = new System.Drawing.Point(145, 49);
            this.tb_maxSpeed.Name = "tb_maxSpeed";
            this.tb_maxSpeed.Size = new System.Drawing.Size(103, 20);
            this.tb_maxSpeed.TabIndex = 13;
            this.tb_maxSpeed.Text = "0";
            this.tb_maxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_maxSpeed_KeyPress);
            // 
            // tb_acceleretion
            // 
            this.tb_acceleretion.Location = new System.Drawing.Point(145, 75);
            this.tb_acceleretion.Name = "tb_acceleretion";
            this.tb_acceleretion.Size = new System.Drawing.Size(103, 20);
            this.tb_acceleretion.TabIndex = 13;
            this.tb_acceleretion.Text = "0";
            this.tb_acceleretion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_acceleretion_KeyPress);
            // 
            // tb_deceleration
            // 
            this.tb_deceleration.Location = new System.Drawing.Point(145, 102);
            this.tb_deceleration.Name = "tb_deceleration";
            this.tb_deceleration.Size = new System.Drawing.Size(103, 20);
            this.tb_deceleration.TabIndex = 13;
            this.tb_deceleration.Text = "0";
            this.tb_deceleration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_deceleration_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Макс. скорость, шаг/с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ускорние, шаг/с^2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Торможение, шаг/с^2";
            // 
            // cb_front
            // 
            this.cb_front.FormattingEnabled = true;
            this.cb_front.Items.AddRange(new object[] {
            "Линейный",
            "S-кривая",
            "Sin"});
            this.cb_front.Location = new System.Drawing.Point(145, 129);
            this.cb_front.Name = "cb_front";
            this.cb_front.Size = new System.Drawing.Size(103, 21);
            this.cb_front.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Тип ускорения";
            // 
            // cb_dir
            // 
            this.cb_dir.FormattingEnabled = true;
            this.cb_dir.Items.AddRange(new object[] {
            "По часовой",
            "Против часовой"});
            this.cb_dir.Location = new System.Drawing.Point(145, 156);
            this.cb_dir.Name = "cb_dir";
            this.cb_dir.Size = new System.Drawing.Size(103, 21);
            this.cb_dir.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Направление";
            // 
            // gb_comFields
            // 
            this.gb_comFields.Controls.Add(this.l_parityBits);
            this.gb_comFields.Controls.Add(this.l_stopBits);
            this.gb_comFields.Controls.Add(this.l_dataBits);
            this.gb_comFields.Controls.Add(this.l_baudRate);
            this.gb_comFields.Controls.Add(this.cb_parityBits);
            this.gb_comFields.Controls.Add(this.cb_stopBits);
            this.gb_comFields.Controls.Add(this.cb_dataBits);
            this.gb_comFields.Controls.Add(this.cb_boundRate);
            this.gb_comFields.Controls.Add(this.label1);
            this.gb_comFields.Controls.Add(this.cb_port);
            this.gb_comFields.Location = new System.Drawing.Point(12, 23);
            this.gb_comFields.Name = "gb_comFields";
            this.gb_comFields.Size = new System.Drawing.Size(229, 161);
            this.gb_comFields.TabIndex = 17;
            this.gb_comFields.TabStop = false;
            this.gb_comFields.Text = "парметры COM-порта";
            // 
            // gb_connecionBtns
            // 
            this.gb_connecionBtns.Controls.Add(this.pb_status);
            this.gb_connecionBtns.Controls.Add(this.btn_disconect);
            this.gb_connecionBtns.Controls.Add(this.btn_connection);
            this.gb_connecionBtns.Location = new System.Drawing.Point(10, 191);
            this.gb_connecionBtns.Name = "gb_connecionBtns";
            this.gb_connecionBtns.Size = new System.Drawing.Size(230, 98);
            this.gb_connecionBtns.TabIndex = 18;
            this.gb_connecionBtns.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_dir);
            this.groupBox1.Controls.Add(this.cb_front);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_deceleration);
            this.groupBox1.Controls.Add(this.tb_acceleretion);
            this.groupBox1.Controls.Add(this.tb_maxSpeed);
            this.groupBox1.Controls.Add(this.btn_send);
            this.groupBox1.Controls.Add(this.L_angle);
            this.groupBox1.Controls.Add(this.tb_angle);
            this.groupBox1.Location = new System.Drawing.Point(247, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 265);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры движения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_connecionBtns);
            this.Controls.Add(this.gb_comFields);
            this.Controls.Add(this.tb_recive);
            this.Name = "Form1";
            this.Text = "StepperControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_comFields.ResumeLayout(false);
            this.gb_comFields.PerformLayout();
            this.gb_connecionBtns.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox tb_maxSpeed;
        private System.Windows.Forms.TextBox tb_acceleretion;
        private System.Windows.Forms.TextBox tb_deceleration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_front;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_dir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_comFields;
        private System.Windows.Forms.GroupBox gb_connecionBtns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
    }
}


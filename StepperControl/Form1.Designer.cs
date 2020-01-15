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
            this.btn_connection = new System.Windows.Forms.Button();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_connection
            // 
            this.btn_connection.Location = new System.Drawing.Point(534, 48);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(99, 40);
            this.btn_connection.TabIndex = 0;
            this.btn_connection.Text = "Подключиться";
            this.btn_connection.UseVisualStyleBackColor = true;
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(138, 48);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(121, 21);
            this.cb_port.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_port);
            this.Controls.Add(this.btn_connection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.ComboBox cb_port;
    }
}


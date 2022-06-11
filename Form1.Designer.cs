
namespace emguCV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDetect = new System.Windows.Forms.Button();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.Device = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Server_btn = new System.Windows.Forms.Button();
            this.ResCBO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ComCBO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetect
            // 
            this.btnDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetect.Location = new System.Drawing.Point(360, 53);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(68, 23);
            this.btnDetect.TabIndex = 0;
            this.btnDetect.Text = "SelectRes";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(80, 25);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(611, 23);
            this.cboDevice.TabIndex = 1;
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.cboDevice_SelectedIndexChanged);
            // 
            // Device
            // 
            this.Device.AutoSize = true;
            this.Device.Location = new System.Drawing.Point(29, 28);
            this.Device.Name = "Device";
            this.Device.Size = new System.Drawing.Size(45, 15);
            this.Device.TabIndex = 2;
            this.Device.Text = "Device:";
            this.Device.Click += new System.EventHandler(this.Device_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 720);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Server_btn
            // 
            this.Server_btn.Location = new System.Drawing.Point(12, 869);
            this.Server_btn.Name = "Server_btn";
            this.Server_btn.Size = new System.Drawing.Size(97, 23);
            this.Server_btn.TabIndex = 7;
            this.Server_btn.Text = "Open Server";
            this.Server_btn.UseVisualStyleBackColor = true;
            this.Server_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ResCBO
            // 
            this.ResCBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResCBO.FormattingEnabled = true;
            this.ResCBO.Location = new System.Drawing.Point(80, 54);
            this.ResCBO.Name = "ResCBO";
            this.ResCBO.Size = new System.Drawing.Size(274, 23);
            this.ResCBO.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Resolution:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "SelecetDevice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ComCBO
            // 
            this.ComCBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComCBO.FormattingEnabled = true;
            this.ComCBO.Location = new System.Drawing.Point(890, 24);
            this.ComCBO.Name = "ComCBO";
            this.ComCBO.Size = new System.Drawing.Size(288, 23);
            this.ComCBO.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Com";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 904);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComCBO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResCBO);
            this.Controls.Add(this.Server_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Device);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.btnDetect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Label Device;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Server_btn;
        private System.Windows.Forms.ComboBox ResCBO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox ComCBO;
        private System.Windows.Forms.Label label2;
    }
}


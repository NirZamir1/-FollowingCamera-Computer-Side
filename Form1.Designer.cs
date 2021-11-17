
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
            this.label3 = new System.Windows.Forms.Label();
            this.Server_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(80, 400);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(75, 23);
            this.btnDetect.TabIndex = 0;
            this.btnDetect.Text = "Detect";
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
            this.pictureBox1.Location = new System.Drawing.Point(80, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 317);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Server_btn
            // 
            this.Server_btn.Location = new System.Drawing.Point(170, 400);
            this.Server_btn.Name = "Server_btn";
            this.Server_btn.Size = new System.Drawing.Size(104, 23);
            this.Server_btn.TabIndex = 7;
            this.Server_btn.Text = "Open Server";
            this.Server_btn.UseVisualStyleBackColor = true;
            this.Server_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.Server_btn);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Server_btn;
    }
}


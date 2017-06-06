namespace MultiDrawing
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverPort = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.serverIpTextBox = new System.Windows.Forms.TextBox();
            this.serverPortTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.Location = new System.Drawing.Point(23, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(358, 275);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(387, 30);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(57, 13);
            this.serverLabel.TabIndex = 1;
            this.serverLabel.Text = "Server IP :";
            this.serverLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // serverPort
            // 
            this.serverPort.AutoSize = true;
            this.serverPort.Location = new System.Drawing.Point(387, 61);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(66, 13);
            this.serverPort.TabIndex = 2;
            this.serverPort.Text = "Server Port :";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(387, 92);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status :";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(390, 131);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(164, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(390, 160);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(164, 23);
            this.disconnectButton.TabIndex = 5;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(390, 189);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(164, 23);
            this.colorButton.TabIndex = 6;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            // 
            // serverIpTextBox
            // 
            this.serverIpTextBox.Location = new System.Drawing.Point(450, 27);
            this.serverIpTextBox.Name = "serverIpTextBox";
            this.serverIpTextBox.Size = new System.Drawing.Size(104, 20);
            this.serverIpTextBox.TabIndex = 7;
            this.serverIpTextBox.Text = "192.168.0.1";
            // 
            // serverPortTextBox
            // 
            this.serverPortTextBox.Location = new System.Drawing.Point(459, 61);
            this.serverPortTextBox.Name = "serverPortTextBox";
            this.serverPortTextBox.Size = new System.Drawing.Size(95, 20);
            this.serverPortTextBox.TabIndex = 8;
            this.serverPortTextBox.Text = "9050";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(436, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Disconnected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 419);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.serverPortTextBox);
            this.Controls.Add(this.serverIpTextBox);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label serverPort;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TextBox serverIpTextBox;
        private System.Windows.Forms.TextBox serverPortTextBox;
        private System.Windows.Forms.TextBox textBox3;
    }
}


namespace WindowsFormsAppSPARK2Dashboard
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dissconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.ScanPortButton = new System.Windows.Forms.Button();
            this.ConnectionPortLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(606, 199);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(606, 155);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dissconnectButton);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.baudRateComboBox);
            this.panel1.Controls.Add(this.baudRateLabel);
            this.panel1.Controls.Add(this.portComboBox);
            this.panel1.Controls.Add(this.ScanPortButton);
            this.panel1.Controls.Add(this.ConnectionPortLabel);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 183);
            this.panel1.TabIndex = 2;
            // 
            // dissconnectButton
            // 
            this.dissconnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dissconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dissconnectButton.ForeColor = System.Drawing.Color.White;
            this.dissconnectButton.Location = new System.Drawing.Point(75, 143);
            this.dissconnectButton.Name = "dissconnectButton";
            this.dissconnectButton.Size = new System.Drawing.Size(143, 23);
            this.dissconnectButton.TabIndex = 6;
            this.dissconnectButton.Text = "Disconnect";
            this.dissconnectButton.UseVisualStyleBackColor = false;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Green;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Location = new System.Drawing.Point(75, 143);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(143, 23);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(127, 98);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.baudRateComboBox.TabIndex = 4;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.baudRateLabel.Location = new System.Drawing.Point(26, 101);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(61, 13);
            this.baudRateLabel.TabIndex = 3;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(127, 53);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 2;
            // 
            // ScanPortButton
            // 
            this.ScanPortButton.BackColor = System.Drawing.Color.Magenta;
            this.ScanPortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScanPortButton.FlatAppearance.BorderSize = 0;
            this.ScanPortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanPortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanPortButton.ForeColor = System.Drawing.Color.White;
            this.ScanPortButton.Location = new System.Drawing.Point(17, 53);
            this.ScanPortButton.Name = "ScanPortButton";
            this.ScanPortButton.Size = new System.Drawing.Size(77, 25);
            this.ScanPortButton.TabIndex = 1;
            this.ScanPortButton.Text = "Scan Port";
            this.ScanPortButton.UseVisualStyleBackColor = false;
            this.ScanPortButton.Click += new System.EventHandler(this.ScanPortButton_Click);
            // 
            // ConnectionPortLabel
            // 
            this.ConnectionPortLabel.AutoSize = true;
            this.ConnectionPortLabel.ForeColor = System.Drawing.Color.Purple;
            this.ConnectionPortLabel.Location = new System.Drawing.Point(88, 15);
            this.ConnectionPortLabel.Name = "ConnectionPortLabel";
            this.ConnectionPortLabel.Size = new System.Drawing.Size(91, 13);
            this.ConnectionPortLabel.TabIndex = 0;
            this.ConnectionPortLabel.Text = "Connection Panel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ConnectionPortLabel;
        private System.Windows.Forms.Button ScanPortButton;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Button dissconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox baudRateComboBox;
    }
}


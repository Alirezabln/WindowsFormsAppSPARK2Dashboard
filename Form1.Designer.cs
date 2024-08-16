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
            this.Sol1Open = new System.Windows.Forms.Button();
            this.Sol1Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.ScanPortButton = new System.Windows.Forms.Button();
            this.ConnectionPortLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.dissconnectButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valvePanel = new System.Windows.Forms.Label();
            this.sol2Open = new System.Windows.Forms.Button();
            this.sol3Open = new System.Windows.Forms.Button();
            this.sol4Open = new System.Windows.Forms.Button();
            this.sol2Close = new System.Windows.Forms.Button();
            this.sol3Close = new System.Windows.Forms.Button();
            this.sol4Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sol1Open
            // 
            this.Sol1Open.BackColor = System.Drawing.Color.Green;
            this.Sol1Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sol1Open.ForeColor = System.Drawing.Color.White;
            this.Sol1Open.Location = new System.Drawing.Point(81, 49);
            this.Sol1Open.Name = "Sol1Open";
            this.Sol1Open.Size = new System.Drawing.Size(178, 28);
            this.Sol1Open.TabIndex = 0;
            this.Sol1Open.Text = "Open";
            this.Sol1Open.UseVisualStyleBackColor = false;
            this.Sol1Open.Click += new System.EventHandler(this.sol1Open_Click);
            // 
            // Sol1Close
            // 
            this.Sol1Close.BackColor = System.Drawing.Color.Red;
            this.Sol1Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sol1Close.ForeColor = System.Drawing.Color.White;
            this.Sol1Close.Location = new System.Drawing.Point(81, 49);
            this.Sol1Close.Name = "Sol1Close";
            this.Sol1Close.Size = new System.Drawing.Size(178, 28);
            this.Sol1Close.TabIndex = 1;
            this.Sol1Close.Text = "Close";
            this.Sol1Close.UseVisualStyleBackColor = false;
            this.Sol1Close.Click += new System.EventHandler(this.sol1close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.baudRateComboBox);
            this.panel1.Controls.Add(this.baudRateLabel);
            this.panel1.Controls.Add(this.portComboBox);
            this.panel1.Controls.Add(this.ScanPortButton);
            this.panel1.Controls.Add(this.ConnectionPortLabel);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.dissconnectButton);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 183);
            this.panel1.TabIndex = 2;
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
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
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
            this.dissconnectButton.Click += new System.EventHandler(this.dissconnectButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.valvePanel);
            this.panel2.Controls.Add(this.Sol1Open);
            this.panel2.Controls.Add(this.Sol1Close);
            this.panel2.Controls.Add(this.sol2Open);
            this.panel2.Controls.Add(this.sol2Close);
            this.panel2.Controls.Add(this.sol3Open);
            this.panel2.Controls.Add(this.sol3Close);
            this.panel2.Controls.Add(this.sol4Open);
            this.panel2.Controls.Add(this.sol4Close);
            this.panel2.Location = new System.Drawing.Point(383, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 248);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(14, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sol 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(14, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sol 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sol 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sol 1";
            // 
            // valvePanel
            // 
            this.valvePanel.AutoSize = true;
            this.valvePanel.ForeColor = System.Drawing.Color.Purple;
            this.valvePanel.Location = new System.Drawing.Point(69, 14);
            this.valvePanel.Name = "valvePanel";
            this.valvePanel.Size = new System.Drawing.Size(138, 13);
            this.valvePanel.TabIndex = 0;
            this.valvePanel.Text = "Manual Valve Control Panel";
            // 
            // sol2Open
            // 
            this.sol2Open.BackColor = System.Drawing.Color.Green;
            this.sol2Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sol2Open.ForeColor = System.Drawing.Color.White;
            this.sol2Open.Location = new System.Drawing.Point(81, 92);
            this.sol2Open.Name = "sol2Open";
            this.sol2Open.Size = new System.Drawing.Size(178, 28);
            this.sol2Open.TabIndex = 4;
            this.sol2Open.Text = "Open";
            this.sol2Open.UseVisualStyleBackColor = false;
            this.sol2Open.Click += new System.EventHandler(this.sol2Open_Click);
            // 
            // sol3Open
            // 
            this.sol3Open.BackColor = System.Drawing.Color.Green;
            this.sol3Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sol3Open.ForeColor = System.Drawing.Color.White;
            this.sol3Open.Location = new System.Drawing.Point(81, 140);
            this.sol3Open.Name = "sol3Open";
            this.sol3Open.Size = new System.Drawing.Size(178, 28);
            this.sol3Open.TabIndex = 7;
            this.sol3Open.Text = "Open";
            this.sol3Open.UseVisualStyleBackColor = false;
            this.sol3Open.Click += new System.EventHandler(this.sol3Open_Click);
            // 
            // sol4Open
            // 
            this.sol4Open.BackColor = System.Drawing.Color.Green;
            this.sol4Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sol4Open.ForeColor = System.Drawing.Color.White;
            this.sol4Open.Location = new System.Drawing.Point(81, 186);
            this.sol4Open.Name = "sol4Open";
            this.sol4Open.Size = new System.Drawing.Size(178, 28);
            this.sol4Open.TabIndex = 10;
            this.sol4Open.Text = "Open";
            this.sol4Open.UseVisualStyleBackColor = false;
            this.sol4Open.Click += new System.EventHandler(this.sol4Open_Click);
            // 
            // sol2Close
            // 
            this.sol2Close.BackColor = System.Drawing.Color.Red;
            this.sol2Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sol2Close.ForeColor = System.Drawing.Color.White;
            this.sol2Close.Location = new System.Drawing.Point(81, 92);
            this.sol2Close.Name = "sol2Close";
            this.sol2Close.Size = new System.Drawing.Size(178, 28);
            this.sol2Close.TabIndex = 5;
            this.sol2Close.Text = "Close";
            this.sol2Close.UseVisualStyleBackColor = false;
            this.sol2Close.Click += new System.EventHandler(this.sol2Close_Click);
            // 
            // sol3Close
            // 
            this.sol3Close.BackColor = System.Drawing.Color.Red;
            this.sol3Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sol3Close.ForeColor = System.Drawing.Color.White;
            this.sol3Close.Location = new System.Drawing.Point(81, 140);
            this.sol3Close.Name = "sol3Close";
            this.sol3Close.Size = new System.Drawing.Size(178, 28);
            this.sol3Close.TabIndex = 8;
            this.sol3Close.Text = "Close";
            this.sol3Close.UseVisualStyleBackColor = false;
            this.sol3Close.Click += new System.EventHandler(this.sol3Close_Click);
            // 
            // sol4Close
            // 
            this.sol4Close.BackColor = System.Drawing.Color.Red;
            this.sol4Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sol4Close.ForeColor = System.Drawing.Color.White;
            this.sol4Close.Location = new System.Drawing.Point(81, 186);
            this.sol4Close.Name = "sol4Close";
            this.sol4Close.Size = new System.Drawing.Size(178, 28);
            this.sol4Close.TabIndex = 11;
            this.sol4Close.Text = "Close";
            this.sol4Close.UseVisualStyleBackColor = false;
            this.sol4Close.Click += new System.EventHandler(this.sol4Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Sol1Open;
        private System.Windows.Forms.Button Sol1Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ConnectionPortLabel;
        private System.Windows.Forms.Button ScanPortButton;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Button dissconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label valvePanel;
        private System.Windows.Forms.Button sol3Open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sol2Open;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sol2Close;
        private System.Windows.Forms.Button sol4Close;
        private System.Windows.Forms.Button sol4Open;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sol3Close;
    }
}


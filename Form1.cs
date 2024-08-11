//SEDS Dashboard for SPARK 2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsAppSPARK2Dashboard
{
    public partial class Form1 : Form
    {
        #region Constants
        private readonly int[] baudrate = { 9600, 19200, 38400, 57600, 115200 };
        #endregion
        private readonly int[] baudRate = { 9600, 19200, 38400, 57600, 115200 };

        private SerialPort Serial = new SerialPort();

        #region Local Helpers
        private void ScanPort()
        {
            // Get a list of serial port names.
            String[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            portComboBox.Items.Clear();
            baudRateComboBox.Items.Clear();

            //Append to the combo box
            foreach (String port in Ports)
            {
                portComboBox.Items.Add(port);
            }

            foreach (int baud in baudRate)
            {
                baudRateComboBox.Items.Add(baud.ToString());
            }
        }
        #endregion

        #region Handlers
        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            return;
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the port combo box when the form loads
            ScanPort();
        }

        private void ScanPortButton_Click(object sender, EventArgs e)
        {
            // Refresh the port combo box when the Scan Port Button is clicked
            ScanPort();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!Serial.IsOpen)
            {
                try
                {
                    // Get user COM port selection
                    Serial.PortName = portComboBox.Text;
                }
                catch
                {
                    MessageBox.Show("Error! No COM port Selected");
                    return;
                }

                // Get user baud rate selection
                try
                {
                    Serial.BaudRate = Convert.ToInt32(baudRateComboBox.Text);
                }
                catch
                {
                    MessageBox.Show("Error! No Baud Rate Selected");
                    return;
                }
                // Serial Port Configuration
                Serial.Parity = Parity.None;
                Serial.StopBits = StopBits.One;
                Serial.DataBits = 8;
                Serial.Handshake = Handshake.None;
                Serial.ReceivedBytesThreshold = 1;
                Serial.WriteTimeout = 30000;

            }
            if (!Serial.IsOpen)
            {
                try
                {
                    Serial.Open();
                }
                catch
                {
                    MessageBox.Show("Error! The COM port is not accessible");
                    return;
                }
            }
            if (Serial.IsOpen)
            {
                connectButton.Enabled = false;
                connectButton.Visible = false;
                portComboBox.Enabled = false;
                baudRateComboBox.Enabled = false;
                dissconnectButton.Enabled = true;
                ScanPortButton.Enabled = false;

                // Add a handler to the DataReceived event
                Serial.DataReceived += new SerialDataReceivedEventHandler(Serial_DataReceived);
            }
        }

        private void dissconnectButton_Click(object sender, EventArgs e)
        {
            //if user clicks disconnect button
            if (Serial.IsOpen)
            {
                Serial.Close();
            }
            connectButton.Enabled = true;
            connectButton.Visible = true;
            dissconnectButton.Enabled = false;
            dissconnectButton.Visible = true;
            portComboBox.Enabled = true;
            baudRateComboBox.Enabled = true;
            ScanPortButton.Enabled = true;

            return;
        }


        private void OpenButton_Click(object sender, EventArgs e)
        {
            //Send command to the Arduino to turn pin 13 on
            if (Serial != null)
            {
                if (Serial.IsOpen)
                {
                    Serial.Write("A");
                }
                else
                {
                    MessageBox.Show("Error! The COM port is not open");
                }
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Send command to the Arduino to turn pin 13 off
            if (Serial != null)
            {
                if (Serial.IsOpen)
                {
                    Serial.Write("a");
                }
                else
                {
                    MessageBox.Show("Error! The COM port is not open");
                }
            }
        }
    }
}

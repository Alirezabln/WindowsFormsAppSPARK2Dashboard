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


        //private void OpenButton_Click(object sender, EventArgs e)
        //{
        //Send command to the Arduino to turn pin 13 on
        //serialPort1.Write("A");
        //}

        //private void closeButton_Click(object sender, EventArgs e)
        //{
        // Send command to the Arduino to turn pin 13 off
        // serialPort1.Write("a");
        //}
    }
}

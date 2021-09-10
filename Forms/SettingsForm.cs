using MonoBrick.EV3;
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

namespace EV3_WPF
{
    public partial class SettingsForm : Form
    {
        ConnectionHandler ch;
        Brick<Sensor, Sensor, Sensor, Sensor> connectedDevice;

        public SettingsForm()
        {
            InitializeComponent();
            cmbboxCOM.DropDownStyle = ComboBoxStyle.DropDownList;
            btnStart.Visible = false;
            ch = new ConnectionHandler();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            var form2 = new PlayForm(connectedDevice);
            form2.Show();
        }

        private void cmbboxCOM_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbboxCOM.Items.Clear();
            foreach (string comport in ports)
            {
                cmbboxCOM.Items.Add(comport);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connectedDevice = ch.OpenConnection(cmbboxCOM.Text);

            if (connectedDevice != null)
            {
                lblConnectionStatus.Text = "  Připojeno";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Green;
                btnStart.Visible = true;
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connectedDevice != null) ch.CloseConnection();
        }
    }
}

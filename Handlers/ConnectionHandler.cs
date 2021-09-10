using MonoBrick.EV3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV3_WPF
{
    public class ConnectionHandler
    {
        Brick<Sensor, Sensor, Sensor, Sensor> brick;

        public Brick<Sensor, Sensor, Sensor, Sensor> OpenConnection(string comPort)
        {
            try
            {
                brick = new Brick<Sensor, Sensor, Sensor, Sensor>(comPort.ToLower());
                brick.Connection.Open();
                MessageBox.Show("Zařízení úspěšně připojeno.", "Připojeno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return brick;
            }
            catch (Exception e)
            {
                MessageBox.Show("Pokus o připojení neúspěšný. Zkuste prosím znova. " + "(" + e.Message + ")", "Chyba připojení",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
                
        }

        public void CloseConnection()
        {
            brick.Connection.Close();
        }
    }
}

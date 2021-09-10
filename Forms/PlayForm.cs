using MonoBrick.EV3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV3_WPF
{
    public partial class PlayForm : Form
    {
        VehicleHandler vehicle;
        List<Action> movements = new List<Action>();
        List<Button> buttons;

        public PlayForm(Brick<Sensor, Sensor, Sensor, Sensor> brick)
        {
            InitializeComponent();
            vehicle = new VehicleHandler(brick);
            buttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 };

            foreach (Button b in buttons)
            {
                b.Enabled = false;
                b.Visible = false;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            movements.Add(vehicle.GoStraight);
            AddSeq("˄");
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            movements.Add(vehicle.TurnAround);
            AddSeq("↻");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            movements.Add(vehicle.TurnLeft);
            AddSeq("˂");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            movements.Add(vehicle.TurnRight);
            AddSeq("˃");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach(Action m in movements)
            {
                m();
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            movements.Clear();

            foreach (Button b in buttons)
            {
                b.Text = "";
                b.Visible = false;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                if (b.Visible == true)
                {
                    b.Enabled = true;
                    b.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void AddSeq(string icon)
        {
            buttons[movements.Count() - 1].Text = icon;
            buttons[movements.Count() - 1].Visible = true;
        }

        private void ResetButtons()
        {
            foreach (Button b in buttons)
            {
                b.Enabled = false;
                b.BackColor = System.Drawing.Color.Orange;

                if(b.Text == "")
                {
                    b.Visible = false;
                }
            }
        }

        private void RedrawMoves(int startPosition)
        {
            try
            {
                movements.RemoveAt(startPosition);

                if (startPosition == movements.Count())
                {
                    buttons[startPosition].Text = "";
                }
                else
                {
                    for (int i = startPosition; i < movements.Count(); i++)
                    {
                        buttons[i].Text = buttons[i + 1].Text;
                        buttons[i + 1].Text = "";
                    }

                }

                ResetButtons();
            }
            catch(Exception e)
            {
                MessageBox.Show("Nahlašte prosím vývojáři tuto chybu: " + e.Message, "Chyba programu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            RedrawMoves(0);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            RedrawMoves(1);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            RedrawMoves(2);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            RedrawMoves(3);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            RedrawMoves(4);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            RedrawMoves(5);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            RedrawMoves(6);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            RedrawMoves(7);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            RedrawMoves(8);
        }

        private void b10_Click(object sender, EventArgs e)
        {
            RedrawMoves(9);
        }

        private void b11_Click(object sender, EventArgs e)
        {
            RedrawMoves(10);
        }

        private void b12_Click(object sender, EventArgs e)
        {
            RedrawMoves(11);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    public partial class Listener2 : Form
    {
        public Listener2(Listener1 battery)
        {
            InitializeComponent();
            battery.OnChargingCompleted += Battery_OnChargingCompleted;
        }

        public void Battery_OnChargingCompleted(object? sender, EventArgs e)
        {
            Display_txtbx.Text += "\nCharging completed";
        }

        public void Form_OnTrigger()
        {
            Display_txtbx.Text += "\nCharging started!";
        }

        private void Display_txtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

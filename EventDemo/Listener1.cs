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
    public partial class Listener1 : Form
    {
        public event EventHandler OnChargingCompleted;
        public Listener1()
        {
            InitializeComponent();
        }

        public void Form_OnDischarge()
        {
            Level_pgb.Increment(-1);
        }

        public void Form_OnChargingStarted()
        {
            for (int i = 0; i < 100; i++)
            {
                Level_pgb.Increment(1);
                Thread.Sleep(100);
                if (Level_pgb.Value == Level_pgb.Maximum)
                {
                    OnChargingCompleted?.Invoke(this, new EventArgs());
                    break;
                }
            }
        }
    }
}

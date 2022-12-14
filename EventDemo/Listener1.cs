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

        public async void Form_OnChargingStarted()
        {
            bool charging;
            do
            {
                charging = await AddOneBar(Level_pgb);

                Level_pgb.Increment(1);
            }
            while (charging);

            OnChargingCompleted?.Invoke(this, new EventArgs());
        }

        public async Task<bool> AddOneBar(ProgressBar bar)
        {
            return await Task.Run(() =>
            {
                if (bar.Value == bar.Maximum)
                {
                    return false;
                }
                else
                {
                    Thread.Sleep(1000);
                    return true;
                }
            });
        }
    }
}

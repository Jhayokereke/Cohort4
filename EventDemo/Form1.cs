namespace EventDemo
{
    public partial class Form1 : Form
    {
        public delegate void TriggerDelegate();
        public event TriggerDelegate OnChargingStarted;
        public event TriggerDelegate OnDischarge;
        public Form1() 
        {
            InitializeComponent();
            Listener1 listener1 = new Listener1();
            Listener2 listener2 = new Listener2(listener1);
            this.OnChargingStarted += listener2.Form_OnTrigger;
            this.OnChargingStarted += listener1.Form_OnChargingStarted;
            OnDischarge += listener1.Form_OnDischarge;
            listener1.Show();
            listener2.Show();
        }

        private void Trigger_btn_Click(object sender, EventArgs e)
        {
            OnChargingStarted?.Invoke(); //publisher
        }

        private void StopCharging_btn_Click(object sender, EventArgs e)
        {
            OnDischarge?.Invoke();
        }
    }
}
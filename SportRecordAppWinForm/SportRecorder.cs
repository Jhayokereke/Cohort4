using SportRecordLibrary;

namespace SportRecordAppWinForm
{
    public partial class SportRecorder : Form
    {
        private List<SportRecord> records;
        public SportRecorder(List<SportRecord> sportRecords)
        {
            InitializeComponent();
            records = sportRecords;
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            SportRecord newRecord = new()
            {
                SportCategory = SportName_txtbx.Text,
                FirstPosition = new Competitor { Name = WinnerName_txtbx.Text, Country = WinnerCountry_txtbx.Text, TagNumber = int.Parse(WinnerTag_txtbx.Text) },
                SecondPosition = new Competitor { Name = FRunnerName_txtbx.Text, Country = FRunnerCountry_txtbx.Text, TagNumber = int.Parse(FRunnerTag_txtbx.Text) },
                ThirdPosition = new Competitor { Name = SRunnerName_txtbx.Text, Country = SRunnerCountry_txtbx.Text, TagNumber = int.Parse(SRunnerTag_txtbx.Text) }
            };

            records.Add(newRecord);
            MessageBox.Show("Added successfully.");
            ClearTextBoxes();
        }

        private void ViewRecords_btn_Click(object sender, EventArgs e)
        {
            new DisplayWindow(records).Show();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
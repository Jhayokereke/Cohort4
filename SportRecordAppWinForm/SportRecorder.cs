using SportRecordLibrary;

namespace SportRecordAppWinForm
{
    public partial class SportRecorder : Form
    {
        private List<SportRecord> records;
        private DisplayWindow displayWindow;
        public delegate void UpdateDelegate(List<SportRecord> records);
        public event UpdateDelegate OnUpdated;
        public SportRecorder(List<SportRecord> sportRecords)
        {
            InitializeComponent();
            records = sportRecords;
            displayWindow = new DisplayWindow(this);
            displayWindow.Show();
        }

        private void DisplayWindow_OnUpdated(List<SportRecord> records)
        {
            throw new NotImplementedException();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SportName_txtbx.Text) || string.IsNullOrWhiteSpace(WinnerName_txtbx.Text) 
                || string.IsNullOrWhiteSpace(WinnerCountry_txtbx.Text) || string.IsNullOrWhiteSpace(WinnerTag_txtbx.Text) 
                || string.IsNullOrWhiteSpace(FRunnerName_txtbx.Text) || string.IsNullOrWhiteSpace(FRunnerCountry_txtbx.Text) 
                || string.IsNullOrWhiteSpace(FRunnerTag_txtbx.Text) || string.IsNullOrWhiteSpace(SRunnerName_txtbx.Text) 
                || string.IsNullOrWhiteSpace(SRunnerCountry_txtbx.Text) || string.IsNullOrWhiteSpace(SRunnerTag_txtbx.Text))
            {
                MessageBox.Show("Incomplete!");
            }

            else
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
                OnUpdated?.Invoke(records);
                ClearTextBoxes(); 
            }
        }

        private void ViewRecords_btn_Click(object sender, EventArgs e)
        {
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

        private void WinnerTag_txtbx_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(WinnerTag_txtbx);
        }

        private void FRunnerTag_txtbx_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(FRunnerTag_txtbx);
        }

        private void SRunnerTag_txtbx_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(SRunnerTag_txtbx);
        }

        private void ValidateNumber(TextBox textbox)
        {
            bool isNumericDigit = int.TryParse(textbox.Text, out _);

            if (!isNumericDigit)
            {
                MessageBox.Show($"{textbox.Text} is not a number!");
                textbox.Text = string.Empty;
            }
        }
    }
}
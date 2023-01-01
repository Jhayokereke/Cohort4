using Entities;

namespace ADO.NetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fetch_btn_Click(object sender, EventArgs e)
        {
            DisplayTable.DataSource = new Datastore().FetchData();
        }

        private void AddNew_btn_Click(object sender, EventArgs e)
        {
            DotnetFellow newFellow = new()
            {
                Id = Id_txtbx.Text,
                Firstname = Firstname_txtbx.Text,
                Middlename = Middlename_txtbx.Text,
                Lastname = Lastname_txtbx.Text,
                GenderId = Gender_drpdwn.SelectedIndex + 1,
                StateId = 2
            };

            if (new Datastore().AddFellow(newFellow))
            {
                MessageBox.Show("Successfully added!");
            }
            else
            {
                MessageBox.Show("Failed to add!");
            }
        }
    }
}
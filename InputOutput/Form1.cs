namespace InputOutput
{
    public partial class Form1 : Form
    {
        private List<string> _todoItems = new List<string>();
        private readonly string _path = Path.Combine("C:\\Users\\hp\\Git Repository\\Cohort4\\InputOutput", "Todo.txt");
        public Form1()
        {
            _todoItems = new IOLogic().ReadFromFile(_path);
            InitializeComponent();
            DisplayScreen.Text = string.Join("\n", _todoItems);
        }

        private void AddNew_btn_Click(object sender, EventArgs e)
        {
            IOLogic logic = new();
            //add to list
            _todoItems.Add(NewItem_txtbx.Text);
            //save to file
            logic.WriteToFile(_path, _todoItems);
            //refresh
            DisplayScreen.Text = string.Join("\n", _todoItems);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            _todoItems = DisplayScreen.Text.Split("\n").ToList();
            DisplayScreen.Text = string.Join("\n", _todoItems);
        }
    }
}
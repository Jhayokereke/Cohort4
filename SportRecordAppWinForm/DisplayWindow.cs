using SportRecordLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportRecordAppWinForm
{
    public partial class DisplayWindow : Form
    {
        private SportRecorder Recorder;
        private DataTable table;

        public DisplayWindow(SportRecorder recorder)
        {
            InitializeComponent();
            

            Recorder = recorder;
            Recorder.OnUpdated += Recorder_OnUpdated;
        }

        private void Recorder_OnUpdated(List<SportRecord> records)
        {
            table = new DataTable();
            table.Columns.Add("Sport");
            table.Columns.Add("Winner", typeof(string));
            table.Columns.Add("First Runner Up", typeof(string));
            table.Columns.Add("Second Runner Up", typeof(string));
            foreach (SportRecord record in records)
            {
                table.Rows.Add(record.SportCategory, record.FirstPosition, record.SecondPosition, record.ThirdPosition);
            }

            RecordTable_dtgrd.DataSource = table;
        }
    }
}

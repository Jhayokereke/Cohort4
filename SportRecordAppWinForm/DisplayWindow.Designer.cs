namespace SportRecordAppWinForm
{
    partial class DisplayWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecordTable_dtgrd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable_dtgrd)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordTable_dtgrd
            // 
            this.RecordTable_dtgrd.AllowUserToAddRows = false;
            this.RecordTable_dtgrd.AllowUserToDeleteRows = false;
            this.RecordTable_dtgrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordTable_dtgrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecordTable_dtgrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RecordTable_dtgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordTable_dtgrd.Location = new System.Drawing.Point(24, 63);
            this.RecordTable_dtgrd.Name = "RecordTable_dtgrd";
            this.RecordTable_dtgrd.ReadOnly = true;
            this.RecordTable_dtgrd.RowHeadersWidth = 51;
            this.RecordTable_dtgrd.RowTemplate.Height = 29;
            this.RecordTable_dtgrd.Size = new System.Drawing.Size(554, 188);
            this.RecordTable_dtgrd.TabIndex = 0;
            // 
            // DisplayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecordTable_dtgrd);
            this.Name = "DisplayWindow";
            this.Text = "DisplayWindow";
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable_dtgrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView RecordTable_dtgrd;
    }
}
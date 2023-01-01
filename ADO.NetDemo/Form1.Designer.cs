namespace ADO.NetDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayTable = new System.Windows.Forms.DataGridView();
            this.Fetch_btn = new System.Windows.Forms.Button();
            this.Firstname_txtbx = new System.Windows.Forms.TextBox();
            this.Middlename_txtbx = new System.Windows.Forms.TextBox();
            this.Lastname_txtbx = new System.Windows.Forms.TextBox();
            this.Id_txtbx = new System.Windows.Forms.TextBox();
            this.Gender_drpdwn = new System.Windows.Forms.ComboBox();
            this.State_drpdwn = new System.Windows.Forms.ComboBox();
            this.AddNew_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayTable
            // 
            this.DisplayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayTable.Location = new System.Drawing.Point(33, 12);
            this.DisplayTable.Name = "DisplayTable";
            this.DisplayTable.RowHeadersWidth = 51;
            this.DisplayTable.RowTemplate.Height = 29;
            this.DisplayTable.Size = new System.Drawing.Size(461, 433);
            this.DisplayTable.TabIndex = 0;
            // 
            // Fetch_btn
            // 
            this.Fetch_btn.Location = new System.Drawing.Point(33, 469);
            this.Fetch_btn.Name = "Fetch_btn";
            this.Fetch_btn.Size = new System.Drawing.Size(154, 55);
            this.Fetch_btn.TabIndex = 1;
            this.Fetch_btn.Text = "Fetch";
            this.Fetch_btn.UseVisualStyleBackColor = true;
            this.Fetch_btn.Click += new System.EventHandler(this.Fetch_btn_Click);
            // 
            // Firstname_txtbx
            // 
            this.Firstname_txtbx.Location = new System.Drawing.Point(551, 21);
            this.Firstname_txtbx.Name = "Firstname_txtbx";
            this.Firstname_txtbx.PlaceholderText = "Firstname";
            this.Firstname_txtbx.Size = new System.Drawing.Size(403, 27);
            this.Firstname_txtbx.TabIndex = 2;
            // 
            // Middlename_txtbx
            // 
            this.Middlename_txtbx.Location = new System.Drawing.Point(551, 83);
            this.Middlename_txtbx.Name = "Middlename_txtbx";
            this.Middlename_txtbx.PlaceholderText = "Middlename";
            this.Middlename_txtbx.Size = new System.Drawing.Size(403, 27);
            this.Middlename_txtbx.TabIndex = 3;
            // 
            // Lastname_txtbx
            // 
            this.Lastname_txtbx.Location = new System.Drawing.Point(551, 141);
            this.Lastname_txtbx.Name = "Lastname_txtbx";
            this.Lastname_txtbx.PlaceholderText = "Lastname";
            this.Lastname_txtbx.Size = new System.Drawing.Size(403, 27);
            this.Lastname_txtbx.TabIndex = 4;
            // 
            // Id_txtbx
            // 
            this.Id_txtbx.Location = new System.Drawing.Point(551, 201);
            this.Id_txtbx.Name = "Id_txtbx";
            this.Id_txtbx.PlaceholderText = "Id";
            this.Id_txtbx.Size = new System.Drawing.Size(403, 27);
            this.Id_txtbx.TabIndex = 5;
            // 
            // Gender_drpdwn
            // 
            this.Gender_drpdwn.FormattingEnabled = true;
            this.Gender_drpdwn.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.Gender_drpdwn.Location = new System.Drawing.Point(551, 273);
            this.Gender_drpdwn.Name = "Gender_drpdwn";
            this.Gender_drpdwn.Size = new System.Drawing.Size(403, 28);
            this.Gender_drpdwn.TabIndex = 6;
            // 
            // State_drpdwn
            // 
            this.State_drpdwn.FormattingEnabled = true;
            this.State_drpdwn.Items.AddRange(new object[] {
            "Imo",
            "Ekiti",
            "Osun",
            "Ondo",
            "Oyo",
            "Lagos",
            "Ogun",
            "Delta"});
            this.State_drpdwn.Location = new System.Drawing.Point(551, 340);
            this.State_drpdwn.Name = "State_drpdwn";
            this.State_drpdwn.Size = new System.Drawing.Size(403, 28);
            this.State_drpdwn.TabIndex = 7;
            // 
            // AddNew_btn
            // 
            this.AddNew_btn.Location = new System.Drawing.Point(551, 407);
            this.AddNew_btn.Name = "AddNew_btn";
            this.AddNew_btn.Size = new System.Drawing.Size(107, 38);
            this.AddNew_btn.TabIndex = 8;
            this.AddNew_btn.Text = "Add new";
            this.AddNew_btn.UseVisualStyleBackColor = true;
            this.AddNew_btn.Click += new System.EventHandler(this.AddNew_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 574);
            this.Controls.Add(this.AddNew_btn);
            this.Controls.Add(this.State_drpdwn);
            this.Controls.Add(this.Gender_drpdwn);
            this.Controls.Add(this.Id_txtbx);
            this.Controls.Add(this.Lastname_txtbx);
            this.Controls.Add(this.Middlename_txtbx);
            this.Controls.Add(this.Firstname_txtbx);
            this.Controls.Add(this.Fetch_btn);
            this.Controls.Add(this.DisplayTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DisplayTable;
        private Button Fetch_btn;
        private TextBox Firstname_txtbx;
        private TextBox Middlename_txtbx;
        private TextBox Lastname_txtbx;
        private TextBox Id_txtbx;
        private ComboBox Gender_drpdwn;
        private ComboBox State_drpdwn;
        private Button AddNew_btn;
    }
}
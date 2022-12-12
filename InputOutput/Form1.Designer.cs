namespace InputOutput
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
            this.DisplayScreen = new System.Windows.Forms.RichTextBox();
            this.NewItem_txtbx = new System.Windows.Forms.TextBox();
            this.Read_btn = new System.Windows.Forms.Button();
            this.Path_lbl = new System.Windows.Forms.Label();
            this.Write_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayScreen
            // 
            this.DisplayScreen.Location = new System.Drawing.Point(12, 72);
            this.DisplayScreen.Name = "DisplayScreen";
            this.DisplayScreen.Size = new System.Drawing.Size(776, 366);
            this.DisplayScreen.TabIndex = 0;
            this.DisplayScreen.Text = "";
            // 
            // NewItem_txtbx
            // 
            this.NewItem_txtbx.Location = new System.Drawing.Point(12, 39);
            this.NewItem_txtbx.Name = "NewItem_txtbx";
            this.NewItem_txtbx.PlaceholderText = "Buy garri";
            this.NewItem_txtbx.Size = new System.Drawing.Size(475, 27);
            this.NewItem_txtbx.TabIndex = 1;
            // 
            // Read_btn
            // 
            this.Read_btn.Location = new System.Drawing.Point(493, 37);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(94, 29);
            this.Read_btn.TabIndex = 2;
            this.Read_btn.Text = "Add new";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.AddNew_btn_Click);
            // 
            // Path_lbl
            // 
            this.Path_lbl.AutoSize = true;
            this.Path_lbl.Location = new System.Drawing.Point(12, 16);
            this.Path_lbl.Name = "Path_lbl";
            this.Path_lbl.Size = new System.Drawing.Size(37, 20);
            this.Path_lbl.TabIndex = 3;
            this.Path_lbl.Text = "Path";
            // 
            // Write_btn
            // 
            this.Write_btn.Location = new System.Drawing.Point(593, 37);
            this.Write_btn.Name = "Write_btn";
            this.Write_btn.Size = new System.Drawing.Size(94, 29);
            this.Write_btn.TabIndex = 4;
            this.Write_btn.Text = "Save";
            this.Write_btn.UseVisualStyleBackColor = true;
            this.Write_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Write_btn);
            this.Controls.Add(this.Path_lbl);
            this.Controls.Add(this.Read_btn);
            this.Controls.Add(this.NewItem_txtbx);
            this.Controls.Add(this.DisplayScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox DisplayScreen;
        private TextBox NewItem_txtbx;
        private Button Read_btn;
        private Label Path_lbl;
        private Button Write_btn;
    }
}
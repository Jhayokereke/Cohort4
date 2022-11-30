namespace EventDemo
{
    partial class Listener1
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
            this.Level_pgb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Level_pgb
            // 
            this.Level_pgb.Location = new System.Drawing.Point(96, 107);
            this.Level_pgb.Name = "Level_pgb";
            this.Level_pgb.Size = new System.Drawing.Size(562, 29);
            this.Level_pgb.TabIndex = 0;
            this.Level_pgb.Maximum = 100;
            // 
            // Listener1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 216);
            this.Controls.Add(this.Level_pgb);
            this.Name = "Listener1";
            this.Text = "Listener1";
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar Level_pgb;
    }
}
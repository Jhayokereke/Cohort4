namespace EventDemo
{
    partial class Listener2
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
            this.components = new System.ComponentModel.Container();
            this.PopUp_nfy = new System.Windows.Forms.NotifyIcon(this.components);
            this.Display_txtbx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PopUp_nfy
            // 
            this.PopUp_nfy.Text = "Notify";
            this.PopUp_nfy.Visible = true;
            // 
            // Display_txtbx
            // 
            this.Display_txtbx.Location = new System.Drawing.Point(12, 12);
            this.Display_txtbx.Name = "Display_txtbx";
            this.Display_txtbx.Size = new System.Drawing.Size(399, 290);
            this.Display_txtbx.TabIndex = 0;
            this.Display_txtbx.Text = "";
            this.Display_txtbx.TextChanged += new System.EventHandler(this.Display_txtbx_TextChanged);
            // 
            // Listener2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 366);
            this.Controls.Add(this.Display_txtbx);
            this.Name = "Listener2";
            this.Text = "Listener2";
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon PopUp_nfy;
        private RichTextBox Display_txtbx;
    }
}
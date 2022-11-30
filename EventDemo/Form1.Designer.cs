namespace EventDemo
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
            this.Trigger_btn = new System.Windows.Forms.Button();
            this.StopCharging_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Trigger_btn
            // 
            this.Trigger_btn.Location = new System.Drawing.Point(52, 43);
            this.Trigger_btn.Name = "Trigger_btn";
            this.Trigger_btn.Size = new System.Drawing.Size(136, 51);
            this.Trigger_btn.TabIndex = 0;
            this.Trigger_btn.Text = "Start Charging";
            this.Trigger_btn.UseVisualStyleBackColor = true;
            this.Trigger_btn.Click += new System.EventHandler(this.Trigger_btn_Click);
            // 
            // StopCharging_btn
            // 
            this.StopCharging_btn.Location = new System.Drawing.Point(52, 122);
            this.StopCharging_btn.Name = "StopCharging_btn";
            this.StopCharging_btn.Size = new System.Drawing.Size(136, 51);
            this.StopCharging_btn.TabIndex = 1;
            this.StopCharging_btn.Text = "Stop Charging";
            this.StopCharging_btn.UseVisualStyleBackColor = true;
            this.StopCharging_btn.Click += new System.EventHandler(this.StopCharging_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.StopCharging_btn);
            this.Controls.Add(this.Trigger_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Trigger_btn;
        private Button StopCharging_btn;
    }
}
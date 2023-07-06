namespace NlogForm
{
    partial class LogForm1
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
            this.txtLog1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtLog1
            // 
            this.txtLog1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLog1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog1.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.txtLog1.ForeColor = System.Drawing.Color.White;
            this.txtLog1.Location = new System.Drawing.Point(0, 0);
            this.txtLog1.Margin = new System.Windows.Forms.Padding(0);
            this.txtLog1.Name = "txtLog1";
            this.txtLog1.ReadOnly = true;
            this.txtLog1.Size = new System.Drawing.Size(800, 450);
            this.txtLog1.TabIndex = 25;
            this.txtLog1.Text = "";
            // 
            // LogForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLog1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogForm1";
            this.Text = "LogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLog1;
    }
}
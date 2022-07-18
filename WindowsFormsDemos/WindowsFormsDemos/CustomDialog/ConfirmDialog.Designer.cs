
namespace WindowsFormsDemos.CustomDialog
{
    partial class ConfirmDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Yesbutton = new System.Windows.Forms.Button();
            this.Nobutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to close?";
            // 
            // Yesbutton
            // 
            this.Yesbutton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Yesbutton.Location = new System.Drawing.Point(132, 105);
            this.Yesbutton.Name = "Yesbutton";
            this.Yesbutton.Size = new System.Drawing.Size(94, 31);
            this.Yesbutton.TabIndex = 1;
            this.Yesbutton.Text = "Yes";
            this.Yesbutton.UseVisualStyleBackColor = true;
            // 
            // Nobutton
            // 
            this.Nobutton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Nobutton.Location = new System.Drawing.Point(243, 104);
            this.Nobutton.Name = "Nobutton";
            this.Nobutton.Size = new System.Drawing.Size(94, 29);
            this.Nobutton.TabIndex = 2;
            this.Nobutton.Text = "No";
            this.Nobutton.UseVisualStyleBackColor = true;
            // 
            // ConfimDialog
            // 
            this.AcceptButton = this.Yesbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.Nobutton;
            this.ClientSize = new System.Drawing.Size(363, 149);
            this.ControlBox = false;
            this.Controls.Add(this.Nobutton);
            this.Controls.Add(this.Yesbutton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfimDialog";
            this.Text = "ConfimDialog";
            this.Load += new System.EventHandler(this.ConfimDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Yesbutton;
        private System.Windows.Forms.Button Nobutton;
    }
}
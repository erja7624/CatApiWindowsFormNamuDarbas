
namespace CatAPI
{
    partial class CatInfo
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
            this.CatInfoTextField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CatInfoTextField
            // 
            this.CatInfoTextField.AcceptsReturn = true;
            this.CatInfoTextField.Dock = System.Windows.Forms.DockStyle.Left;
            this.CatInfoTextField.Location = new System.Drawing.Point(0, 0);
            this.CatInfoTextField.Multiline = true;
            this.CatInfoTextField.Name = "CatInfoTextField";
            this.CatInfoTextField.ReadOnly = true;
            this.CatInfoTextField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CatInfoTextField.Size = new System.Drawing.Size(374, 549);
            this.CatInfoTextField.TabIndex = 0;
            // 
            // CatInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 549);
            this.Controls.Add(this.CatInfoTextField);
            this.Name = "CatInfo";
            this.Text = "CatInfo";
            this.Load += new System.EventHandler(this.CatInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CatInfoTextField;
    }
}
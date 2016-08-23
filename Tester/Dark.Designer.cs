namespace Tester
{
    partial class Dark
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
            this.visualStudioTabControl1 = new VisualStudioTabControl.VisualStudioTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.visualStudioTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualStudioTabControl1
            // 
            this.visualStudioTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.visualStudioTabControl1.AllowDrop = true;
            this.visualStudioTabControl1.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.visualStudioTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualStudioTabControl1.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.visualStudioTabControl1.ClosingMessage = "";
            this.visualStudioTabControl1.Controls.Add(this.tabPage1);
            this.visualStudioTabControl1.Controls.Add(this.tabPage2);
            this.visualStudioTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualStudioTabControl1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.visualStudioTabControl1.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.visualStudioTabControl1.ItemSize = new System.Drawing.Size(240, 16);
            this.visualStudioTabControl1.Location = new System.Drawing.Point(0, 0);
            this.visualStudioTabControl1.Name = "visualStudioTabControl1";
            this.visualStudioTabControl1.SelectedIndex = 0;
            this.visualStudioTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.visualStudioTabControl1.ShowClosingButton = false;
            this.visualStudioTabControl1.ShowClosingMessage = false;
            this.visualStudioTabControl1.Size = new System.Drawing.Size(569, 280);
            this.visualStudioTabControl1.TabIndex = 0;
            this.visualStudioTabControl1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // Dark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 280);
            this.Controls.Add(this.visualStudioTabControl1);
            this.Name = "Dark";
            this.Text = "Dark";
            this.visualStudioTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VisualStudioTabControl.VisualStudioTabControl visualStudioTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
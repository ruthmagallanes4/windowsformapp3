
namespace WindowsFormsApp3
{
    partial class Form3
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
            this.DiscoverButton = new System.Windows.Forms.Button();
            this.DiscoverDeviceList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DiscoverButton
            // 
            this.DiscoverButton.Location = new System.Drawing.Point(315, 275);
            this.DiscoverButton.Name = "DiscoverButton";
            this.DiscoverButton.Size = new System.Drawing.Size(152, 63);
            this.DiscoverButton.TabIndex = 0;
            this.DiscoverButton.Text = "START";
            this.DiscoverButton.UseVisualStyleBackColor = true;
            this.DiscoverButton.Click += new System.EventHandler(this.DiscoverButton_Click);
            // 
            // DiscoverDeviceList
            // 
            this.DiscoverDeviceList.FormattingEnabled = true;
            this.DiscoverDeviceList.Location = new System.Drawing.Point(150, 43);
            this.DiscoverDeviceList.Name = "DiscoverDeviceList";
            this.DiscoverDeviceList.Size = new System.Drawing.Size(495, 199);
            this.DiscoverDeviceList.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DiscoverDeviceList);
            this.Controls.Add(this.DiscoverButton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DiscoverButton;
        private System.Windows.Forms.ListBox DiscoverDeviceList;
    }
}
namespace FlashCards
{
    partial class SaveAsOpen
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
            this.fileName = new System.Windows.Forms.TextBox();
            this.saveOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileName
            // 
            this.fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(25, 40);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 26);
            this.fileName.TabIndex = 0;
            this.fileName.Text = "example.txt";
            this.fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_KeyDown);
            // 
            // saveOpen
            // 
            this.saveOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOpen.Location = new System.Drawing.Point(25, 85);
            this.saveOpen.Name = "saveOpen";
            this.saveOpen.Size = new System.Drawing.Size(100, 26);
            this.saveOpen.TabIndex = 1;
            this.saveOpen.Text = "Save";
            this.saveOpen.UseVisualStyleBackColor = true;
            this.saveOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_SaveOpen);
            // 
            // SaveAsOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 150);
            this.Controls.Add(this.saveOpen);
            this.Controls.Add(this.fileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveAsOpen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save As";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button saveOpen;
    }
}
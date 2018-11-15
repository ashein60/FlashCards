namespace FlashCards
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNote = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNote = new System.Windows.Forms.ToolStripMenuItem();
            this.currentWords = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFlashCard = new System.Windows.Forms.RichTextBox();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.currentSlide = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addNote,
            this.deleteNote,
            this.currentWords});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.Click_New);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Click_Open);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Click_Save);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.Click_SaveAs);
            // 
            // addNote
            // 
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(70, 21);
            this.addNote.Text = "Add Note";
            this.addNote.Click += new System.EventHandler(this.Click_AddNote);
            // 
            // deleteNote
            // 
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(81, 21);
            this.deleteNote.Text = "Delete Note";
            this.deleteNote.Click += new System.EventHandler(this.Click_DeleteNote);
            // 
            // currentWords
            // 
            this.currentWords.Name = "currentWords";
            this.currentWords.Size = new System.Drawing.Size(91, 21);
            this.currentWords.Text = "Showing Title";
            this.currentWords.Click += new System.EventHandler(this.Click_CurrentWords);
            // 
            // mainFlashCard
            // 
            this.mainFlashCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainFlashCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFlashCard.Location = new System.Drawing.Point(20, 45);
            this.mainFlashCard.Name = "mainFlashCard";
            this.mainFlashCard.Size = new System.Drawing.Size(900, 540);
            this.mainFlashCard.TabIndex = 4;
            this.mainFlashCard.Text = "";
            this.mainFlashCard.TextChanged += new System.EventHandler(this.Type_MainFlashCard);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.right.FlatAppearance.BorderSize = 0;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.Location = new System.Drawing.Point(920, 45);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(20, 540);
            this.right.TabIndex = 5;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = false;
            this.right.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Right);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.left.FlatAppearance.BorderSize = 0;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.Location = new System.Drawing.Point(0, 45);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(20, 540);
            this.left.TabIndex = 6;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = false;
            this.left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Left);
            // 
            // currentSlide
            // 
            this.currentSlide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.currentSlide.Location = new System.Drawing.Point(420, 585);
            this.currentSlide.Name = "currentSlide";
            this.currentSlide.Size = new System.Drawing.Size(100, 20);
            this.currentSlide.TabIndex = 7;
            this.currentSlide.Text = "0/0";
            this.currentSlide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 605);
            this.Controls.Add(this.currentSlide);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.mainFlashCard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Cards";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox mainFlashCard;
        private System.Windows.Forms.ToolStripMenuItem addNote;
        private System.Windows.Forms.ToolStripMenuItem deleteNote;
        private System.Windows.Forms.ToolStripMenuItem currentWords;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Label currentSlide;
    }
}


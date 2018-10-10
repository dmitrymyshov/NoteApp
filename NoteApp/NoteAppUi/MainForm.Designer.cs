namespace NoteAppUi
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategorysComboBox = new System.Windows.Forms.ComboBox();
            this.TitlesListBox = new System.Windows.Forms.ListBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ChangeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ShowCatgoryTextBox = new System.Windows.Forms.TextBox();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.CreateTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerNote = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNote)).BeginInit();
            this.splitContainerNote.Panel1.SuspendLayout();
            this.splitContainerNote.Panel2.SuspendLayout();
            this.splitContainerNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategorysComboBox
            // 
            this.CategorysComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategorysComboBox.FormattingEnabled = true;
            this.CategorysComboBox.Location = new System.Drawing.Point(105, 12);
            this.CategorysComboBox.Name = "CategorysComboBox";
            this.CategorysComboBox.Size = new System.Drawing.Size(165, 21);
            this.CategorysComboBox.TabIndex = 0;
            this.CategorysComboBox.SelectedIndexChanged += new System.EventHandler(this.CategorysComboBox_SelectedIndexChanged);
            // 
            // TitlesListBox
            // 
            this.TitlesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlesListBox.FormattingEnabled = true;
            this.TitlesListBox.Location = new System.Drawing.Point(12, 43);
            this.TitlesListBox.Name = "TitlesListBox";
            this.TitlesListBox.Size = new System.Drawing.Size(258, 329);
            this.TitlesListBox.TabIndex = 1;
            this.TitlesListBox.SelectedIndexChanged += new System.EventHandler(this.TitlesListBox_SelectedIndexChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTextBox.Location = new System.Drawing.Point(3, 2);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(528, 23);
            this.TitleTextBox.TabIndex = 2;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTextBox.Location = new System.Drawing.Point(2, 34);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(190, 13);
            this.CategoryTextBox.TabIndex = 3;
            this.CategoryTextBox.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);
            // 
            // CreateDateTimePicker
            // 
            this.CreateDateTimePicker.Enabled = false;
            this.CreateDateTimePicker.Location = new System.Drawing.Point(54, 53);
            this.CreateDateTimePicker.MaximumSize = new System.Drawing.Size(138, 20);
            this.CreateDateTimePicker.MinimumSize = new System.Drawing.Size(130, 20);
            this.CreateDateTimePicker.Name = "CreateDateTimePicker";
            this.CreateDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.CreateDateTimePicker.TabIndex = 4;
            this.CreateDateTimePicker.Visible = false;
            this.CreateDateTimePicker.ValueChanged += new System.EventHandler(this.CreateDateTimePicker_ValueChanged);
            // 
            // ChangeDateTimePicker
            // 
            this.ChangeDateTimePicker.Enabled = false;
            this.ChangeDateTimePicker.Location = new System.Drawing.Point(262, 53);
            this.ChangeDateTimePicker.MaximumSize = new System.Drawing.Size(138, 20);
            this.ChangeDateTimePicker.MinimumSize = new System.Drawing.Size(130, 20);
            this.ChangeDateTimePicker.Name = "ChangeDateTimePicker";
            this.ChangeDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.ChangeDateTimePicker.TabIndex = 5;
            this.ChangeDateTimePicker.Visible = false;
            this.ChangeDateTimePicker.ValueChanged += new System.EventHandler(this.ChangeDateTimePicker_ValueChanged);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Location = new System.Drawing.Point(3, 82);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(540, 337);
            this.NoteTextBox.TabIndex = 6;
            this.NoteTextBox.Visible = false;
            this.NoteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Image = global::NoteAppUi.Properties.Resources.delete__1_;
            this.DeleteButton.Location = new System.Drawing.Point(94, 382);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(35, 35);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewButton.Image = global::NoteAppUi.Properties.Resources.add__1_;
            this.NewButton.Location = new System.Drawing.Point(12, 382);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(35, 35);
            this.NewButton.TabIndex = 8;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeButton.Image = global::NoteAppUi.Properties.Resources.edit__1_;
            this.ChangeButton.Location = new System.Drawing.Point(53, 382);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(35, 35);
            this.ChangeButton.TabIndex = 7;
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ShowCatgoryTextBox
            // 
            this.ShowCatgoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowCatgoryTextBox.Enabled = false;
            this.ShowCatgoryTextBox.Location = new System.Drawing.Point(12, 15);
            this.ShowCatgoryTextBox.Name = "ShowCatgoryTextBox";
            this.ShowCatgoryTextBox.Size = new System.Drawing.Size(87, 13);
            this.ShowCatgoryTextBox.TabIndex = 10;
            this.ShowCatgoryTextBox.Text = "Show Category:";
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeTextBox.Enabled = false;
            this.ChangeTextBox.Location = new System.Drawing.Point(211, 57);
            this.ChangeTextBox.MinimumSize = new System.Drawing.Size(45, 13);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.Size = new System.Drawing.Size(45, 13);
            this.ChangeTextBox.TabIndex = 12;
            this.ChangeTextBox.Text = "Modified:";
            this.ChangeTextBox.Visible = false;
            // 
            // CreateTextBox
            // 
            this.CreateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreateTextBox.Enabled = false;
            this.CreateTextBox.Location = new System.Drawing.Point(3, 57);
            this.CreateTextBox.Name = "CreateTextBox";
            this.CreateTextBox.Size = new System.Drawing.Size(45, 13);
            this.CreateTextBox.TabIndex = 13;
            this.CreateTextBox.Text = "Created:";
            this.CreateTextBox.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainerNote
            // 
            this.splitContainerNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerNote.Location = new System.Drawing.Point(0, 27);
            this.splitContainerNote.Name = "splitContainerNote";
            // 
            // splitContainerNote.Panel1
            // 
            this.splitContainerNote.Panel1.Controls.Add(this.TitlesListBox);
            this.splitContainerNote.Panel1.Controls.Add(this.NewButton);
            this.splitContainerNote.Panel1.Controls.Add(this.DeleteButton);
            this.splitContainerNote.Panel1.Controls.Add(this.ChangeButton);
            this.splitContainerNote.Panel1.Controls.Add(this.ShowCatgoryTextBox);
            this.splitContainerNote.Panel1.Controls.Add(this.CategorysComboBox);
            this.splitContainerNote.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainerNote.Panel2
            // 
            this.splitContainerNote.Panel2.Controls.Add(this.TitleTextBox);
            this.splitContainerNote.Panel2.Controls.Add(this.NoteTextBox);
            this.splitContainerNote.Panel2.Controls.Add(this.CreateTextBox);
            this.splitContainerNote.Panel2.Controls.Add(this.ChangeDateTimePicker);
            this.splitContainerNote.Panel2.Controls.Add(this.ChangeTextBox);
            this.splitContainerNote.Panel2.Controls.Add(this.CreateDateTimePicker);
            this.splitContainerNote.Panel2.Controls.Add(this.CategoryTextBox);
            this.splitContainerNote.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerNote.Size = new System.Drawing.Size(824, 427);
            this.splitContainerNote.SplitterDistance = 274;
            this.splitContainerNote.TabIndex = 15;
            this.splitContainerNote.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerNote_SplitterMoved);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 455);
            this.Controls.Add(this.splitContainerNote);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(630, 400);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerNote.Panel1.ResumeLayout(false);
            this.splitContainerNote.Panel1.PerformLayout();
            this.splitContainerNote.Panel2.ResumeLayout(false);
            this.splitContainerNote.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNote)).EndInit();
            this.splitContainerNote.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategorysComboBox;
        private System.Windows.Forms.ListBox TitlesListBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.DateTimePicker CreateDateTimePicker;
        private System.Windows.Forms.DateTimePicker ChangeDateTimePicker;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox ShowCatgoryTextBox;
        private System.Windows.Forms.TextBox ChangeTextBox;
        private System.Windows.Forms.TextBox CreateTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerNote;
    }
}


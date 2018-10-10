namespace NoteAppUi
{
    partial class InnerForm
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategorysComboBox = new System.Windows.Forms.ComboBox();
            this.CreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ChangeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ShowTitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CreateTextBox = new System.Windows.Forms.TextBox();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(68, 23);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(706, 20);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // CategorysComboBox
            // 
            this.CategorysComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.CategorysComboBox.FormattingEnabled = true;
            this.CategorysComboBox.Location = new System.Drawing.Point(68, 49);
            this.CategorysComboBox.Name = "CategorysComboBox";
            this.CategorysComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategorysComboBox.TabIndex = 1;
            this.CategorysComboBox.TextChanged += new System.EventHandler(this.CategorysComboBox_TextChanged);
            // 
            // CreateDateTimePicker
            // 
            this.CreateDateTimePicker.Enabled = false;
            this.CreateDateTimePicker.Location = new System.Drawing.Point(68, 76);
            this.CreateDateTimePicker.Name = "CreateDateTimePicker";
            this.CreateDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.CreateDateTimePicker.TabIndex = 2;
            this.CreateDateTimePicker.ValueChanged += new System.EventHandler(this.CreateDateTimePicker_ValueChanged);
            // 
            // ChangeDateTimePicker
            // 
            this.ChangeDateTimePicker.Enabled = false;
            this.ChangeDateTimePicker.Location = new System.Drawing.Point(291, 75);
            this.ChangeDateTimePicker.Name = "ChangeDateTimePicker";
            this.ChangeDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.ChangeDateTimePicker.TabIndex = 3;
            this.ChangeDateTimePicker.ValueChanged += new System.EventHandler(this.ChangeDateTimePicker_ValueChanged);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Location = new System.Drawing.Point(12, 102);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(776, 307);
            this.NoteTextBox.TabIndex = 4;
            this.NoteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(632, 415);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(713, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ShowTitleTextBox
            // 
            this.ShowTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowTitleTextBox.Enabled = false;
            this.ShowTitleTextBox.Location = new System.Drawing.Point(12, 26);
            this.ShowTitleTextBox.Name = "ShowTitleTextBox";
            this.ShowTitleTextBox.Size = new System.Drawing.Size(50, 13);
            this.ShowTitleTextBox.TabIndex = 7;
            this.ShowTitleTextBox.Text = "Title:";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTextBox.Enabled = false;
            this.CategoryTextBox.Location = new System.Drawing.Point(12, 52);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(50, 13);
            this.CategoryTextBox.TabIndex = 8;
            this.CategoryTextBox.Text = "Category:";
            // 
            // CreateTextBox
            // 
            this.CreateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreateTextBox.Enabled = false;
            this.CreateTextBox.Location = new System.Drawing.Point(12, 82);
            this.CreateTextBox.Name = "CreateTextBox";
            this.CreateTextBox.Size = new System.Drawing.Size(50, 13);
            this.CreateTextBox.TabIndex = 9;
            this.CreateTextBox.Text = "Created:";
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeTextBox.Enabled = false;
            this.ChangeTextBox.Location = new System.Drawing.Point(235, 81);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.Size = new System.Drawing.Size(50, 13);
            this.ChangeTextBox.TabIndex = 10;
            this.ChangeTextBox.Text = "Modified:";
            // 
            // InnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeTextBox);
            this.Controls.Add(this.CreateTextBox);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.ShowTitleTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.ChangeDateTimePicker);
            this.Controls.Add(this.CreateDateTimePicker);
            this.Controls.Add(this.CategorysComboBox);
            this.Controls.Add(this.TitleTextBox);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "InnerForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox CategorysComboBox;
        private System.Windows.Forms.DateTimePicker CreateDateTimePicker;
        private System.Windows.Forms.DateTimePicker ChangeDateTimePicker;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ShowTitleTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox CreateTextBox;
        private System.Windows.Forms.TextBox ChangeTextBox;
    }
}
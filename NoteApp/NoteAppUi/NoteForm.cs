using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUi
{
    public partial class NoteForm : Form
    {
        private Note _note;

        public Note Note
        {
            get { return _note; }
            set
            {
                _note = value;
                if (_note != null)
                {
                    TitleTextBox.Text = _note.Title; //при отправлении заметки в это окно, автоматом заполнятся компоненты формы

                    CategorysComboBox.SelectedItem = _note.Category;

                    CreateDateTimePicker.Value = _note.DateCreate;

                    ChangeDateTimePicker.Value = _note.DateChange;

                    NoteTextBox.Text = _note.Text;
                }
            }
        }

        public NoteForm()
        {
            InitializeComponent();

            foreach (NoteCategory element in Enum.GetValues(typeof(NoteCategory)))
            {
                CategorysComboBox.Items.Add(element);
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckTitle)
            {
                TitleTextBox.BackColor = Color.MistyRose;
            }
            else
            {
                TitleTextBox.BackColor = Color.White;
            }
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckText)
            {
                NoteTextBox.BackColor = Color.MistyRose;
            }
            else
            {
                NoteTextBox.BackColor = Color.White;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckTitle || CheckText || CheckCategory)
            {
                MessageBox.Show("Данные введены некоректно");
            }
            else
            {
                _note.DateChange = DateTime.Now; //автоматическое изменение даты редактирования

                _note.Title = TitleTextBox.Text;

                _note.Text = NoteTextBox.Text;

                var selectedIndex = CategorysComboBox.SelectedIndex;

                _note.Category = (NoteCategory)CategorysComboBox.Items[selectedIndex];

                DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void CategorysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckCategory)
            {
                CategorysComboBox.BackColor = Color.MistyRose;
            }
            else
            {
                CategorysComboBox.BackColor = Color.White;


            }
        }

        private bool CheckTitle
        {
            get
            {
                if (TitleTextBox.Text == string.Empty)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool CheckText
        {
            get
            {
                if (NoteTextBox.Text == string.Empty)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool CheckCategory
        {
            get
            {
                if (CategorysComboBox.SelectedIndex == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

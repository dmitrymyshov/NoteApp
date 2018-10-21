using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
            _note.Title = TitleTextBox.Text;

            if (CheckTitle)
            {
                TitleTextBox.BackColor = Color.LightSalmon;
            }
            else
            {
                TitleTextBox.BackColor = Color.White;
            }
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Text = NoteTextBox.Text;

            if (CheckText)
            {
                NoteTextBox.BackColor = Color.LightSalmon;
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
                CategorysComboBox.BackColor = Color.LightSalmon;
            }
            else
            {
                CategorysComboBox.BackColor = Color.White;

                var selectedIndex = CategorysComboBox.SelectedIndex;

                _note.Category = (NoteCategory)CategorysComboBox.Items[selectedIndex];
            }
        }

        private bool CheckTitle
        {
            get
            {
                if (_note.Title == string.Empty)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set {  }
        }

        private bool CheckText
        {
            get
            {
                if (_note.Text == string.Empty)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set { }
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
            set { }
        }
    }
}

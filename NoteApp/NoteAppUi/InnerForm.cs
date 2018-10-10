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
    public partial class InnerForm : Form
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

                    CategorysComboBox.Text = _note.Category.ToString();

                    CreateDateTimePicker.Value = _note.DateCreate;

                    ChangeDateTimePicker.Value = _note.DateChange;

                    NoteTextBox.Text = _note.Text;
                }
            }
        }

        public InnerForm()
        {
            InitializeComponent();
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Work);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Home);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.HealthAndSport);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Peoples);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Documents);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Finance);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Other);
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Title = TitleTextBox.Text;

            if (TitleTextBox.Text.Length == 0 || TitleTextBox.Text.Length > 50)
            {
                TitleTextBox.BackColor = Color.Red;
            }
            else
            {
                TitleTextBox.BackColor = Color.White;
            }
        }

        private void CategorysComboBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CategorysComboBox.Items.Count; i++) { 

                
                if (CategorysComboBox.Text != CategorysComboBox.Items[i].ToString())
                {
                    CategorysComboBox.BackColor = Color.Red;

                }
                else
                {
                    CategorysComboBox.BackColor = Color.White;

                    var selectedIndex = CategorysComboBox.SelectedIndex;

                    _note.Category = (NoteCategory)CategorysComboBox.Items[i];

                    break;                 
                }
            }
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Text = NoteTextBox.Text;

            if (NoteTextBox.Text == "")
            {
                NoteTextBox.BackColor = Color.Red;
            }
            else
            {
                NoteTextBox.BackColor = Color.White;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (NoteTextBox.BackColor == Color.Red || CategorysComboBox.BackColor == Color.Red || TitleTextBox.BackColor == Color.Red)
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

        private void CreateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ChangeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}

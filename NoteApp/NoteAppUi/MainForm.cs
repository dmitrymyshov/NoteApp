using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Work);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Home);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.HealthAndSport);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Peoples);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Documents);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Finance);
            CategorysComboBox.Items.Add(NoteApp.NoteCategory.Other);

            try
            {
                allNotes = ProjectManager.LoadFromFile(); //загрузил список заметок
            }
            catch (Exception ex)
            {
                ProjectManager.SaveToFile(allNotes);
            }

           

            CategorysComboBox.SelectedIndex = 0; //по умолчанию 1 категория 
        }

        Project allNotes = new Project();   //список свех заметок

        private void CategorysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //проверка на null(если заметок еще нет)
            if (allNotes != null)
            {
                TitlesListBox.Items.Clear();

                //Если выбрана любая другая категория
                {
                    for (int i = 0; i < allNotes.Notes.Count; i++)
                    {
                     TitlesListBox.Items.Add(allNotes.Notes[i].Title);    
                    }
                }
            }
        }

        private void TitlesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //завершение метода если элемент не выбран
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            CategoryTextBox.Clear();

            TitleTextBox.Clear();

            CreateDateTimePicker.Visible = true;

            ChangeDateTimePicker.Visible = true;

            CreateTextBox.Visible = true;

            ChangeTextBox.Visible = true;

            NoteTextBox.Visible = true;

            NoteTextBox.Clear();

            //если выбран заполняем данными правую часть окна
            TitleTextBox.Text = allNotes.Notes[TitlesListBox.SelectedIndex].Title;

            CategoryTextBox.Text = "Category: " + allNotes.Notes[TitlesListBox.SelectedIndex].Category;

            CreateDateTimePicker.Value = allNotes.Notes[TitlesListBox.SelectedIndex].DateCreate;

            ChangeDateTimePicker.Value = allNotes.Notes[TitlesListBox.SelectedIndex].DateChange;

            NoteTextBox.Text = allNotes.Notes[TitlesListBox.SelectedIndex].Text;
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ChangeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //если заметка не выбрана завершаем выполнение обработчика(ничего не происходит при нажатии на "Изменить")
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            //получаем выбранную заметку
            var selectedIndex = TitlesListBox.SelectedIndex; //индекс нашей заметки в списке всех заметок allNotes

            var selectedNote = allNotes.Notes[selectedIndex]; //сама заметка



            var inner = new InnerForm(); //создаем форму

            inner.Note = selectedNote; //передаем форме данные

            //если было нажато Cancel завершаем выполнение обработчика
            if (inner.ShowDialog() == DialogResult.OK)
            {
                var updatedNote = inner.Note; //забираем измененные данные

                //удалить и заменить старые данные
                TitlesListBox.Items.RemoveAt(selectedIndex);

                allNotes.Notes.RemoveAt(selectedIndex);

                allNotes.Notes.Insert(selectedIndex, updatedNote);

                var changeTitle = updatedNote.Title;

                var changeCategory = updatedNote.Category;

                //вызов обработчика NoteComboBox_SelectedIndexChanged
                if (CategorysComboBox.SelectedIndex == (int)changeCategory)
                {
                    CategorysComboBox_SelectedIndexChanged(sender, e);
                }
                else
                {
                    CategorysComboBox.SelectedIndex = (int)changeCategory;
                }

                TitlesListBox.SelectedItem = changeTitle;

                ProjectManager.SaveToFile(allNotes);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            //получаем выбранную заметку
            Note newNote = new Note("", NoteCategory.Work, "", DateTime.Now); //сама заметка
            newNote.DateChange = DateTime.Now;

            var inner = new InnerForm(); //создаем форму

            inner.Note = newNote; //передаем форме данные

            //если было нажато Cancel завершаем выполнение обработчика
            if (inner.ShowDialog() == DialogResult.OK)
            {
                var updatedNote = inner.Note; //забираем измененные данные

                //добавляем новую заметку в список
                allNotes.Notes.Add(updatedNote);

                var changeTitle = updatedNote.Title;
                var changeCategory = updatedNote.Category;

                //вызов обработчика NoteComboBox_SelectedIndexChanged
                if (CategorysComboBox.SelectedIndex == (int)changeCategory)
                {
                    CategorysComboBox_SelectedIndexChanged(sender, e);
                }
                else
                {
                    CategorysComboBox.SelectedIndex = (int)changeCategory;
                }

                TitlesListBox.SelectedItem = changeTitle;
                ProjectManager.SaveToFile(allNotes);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //если заметка не выбрана завершаем выполнение обработчика(ничего не происходит при нажатии на "Изменить")
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            //получаем выбранную заметку
            var selectedNotesIndex = TitlesListBox.SelectedIndex; //индекс нашей заметки в списке всех заметок allNotes

            var selectedNote = allNotes.Notes[selectedNotesIndex]; //сама заметка

            var selectedIndexList = TitlesListBox.SelectedIndex; //индекс выбранной заметки в TitleListBox

            TitlesListBox.Items.RemoveAt(selectedIndexList);

            allNotes.Notes.RemoveAt(selectedNotesIndex);

            CategorysComboBox.SelectedIndex = 0;

            TitlesListBox.SelectedIndex = -1;

            CreateDateTimePicker.Visible = false;

            ChangeDateTimePicker.Visible = false;

            CreateTextBox.Visible = false;

            ChangeTextBox.Visible = false;

            ProjectManager.SaveToFile(allNotes);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewButton_Click(sender, e);
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeButton_Click(sender, e);
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About(); //создаем форму

            about.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void splitContainerNote_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}

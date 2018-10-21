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

            foreach (NoteCategory element in Enum.GetValues(typeof(NoteCategory)))
            {
                CategorysComboBox.Items.Add(element);
            }

            try
            {
                allNotes = ProjectManager.LoadFromFile(); //загрузил список заметок
            }
            catch (Exception ex)
            {
                ProjectManager.SaveToFile(allNotes);
            }

            splitContainerNote.Panel2.Visible = false; //при запуске правую панель не видно(убрать  лабе расш функц!!!!!!!!!!!!!)

            CategorysComboBox.SelectedIndex = 0; //по умолчанию 1 категория 

        }

        Project allNotes = new Project();   //список свех заметок

        private void CategorysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListbox();
        }

        private void TitlesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //завершение метода если элемент не выбран
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            ClearRigthPanel();

            splitContainerNote.Panel2.Visible = true;

            //если выбран заполняем данными правую часть окна
            TitleTextBox.Text = allNotes.Notes[TitlesListBox.SelectedIndex].Title;

            CategoryTextBox.Text = "Category: " + allNotes.Notes[TitlesListBox.SelectedIndex].Category;

            CreateDateTimePicker.Value = allNotes.Notes[TitlesListBox.SelectedIndex].DateCreate;

            ChangeDateTimePicker.Value = allNotes.Notes[TitlesListBox.SelectedIndex].DateChange;

            NoteTextBox.Text = allNotes.Notes[TitlesListBox.SelectedIndex].Text;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeNote();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            CreateNote();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNote();                                                       
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeNote();                                                          
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();                                                        
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About(); //создаем форму

            about.ShowDialog();
        }

        //Очищает элементы правой панели
        private void ClearRigthPanel()
        {
            CategoryTextBox.Clear();

            TitleTextBox.Clear();

            NoteTextBox.Clear();
        }

        //заполнет ListBox заголовками заметок
        private void FillListbox()
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

        //создание заметки
        private void CreateNote()
        {
            //получаем выбранную заметку
            Note newNote = new Note(string.Empty, NoteCategory.Work, string.Empty, DateTime.Now); //сама заметка

            newNote.DateChange = DateTime.Now;

            var inner = new NoteForm(); //создаем форму

            inner.Note = newNote; //передаем форме данные

            //если было нажато Cancel завершаем выполнение обработчика
            if (inner.ShowDialog() == DialogResult.OK)
            {
                var updatedNote = inner.Note; //забираем измененные данные

                //добавляем новую заметку в список
                allNotes.Notes.Add(updatedNote);

                var changeTitle = updatedNote.Title;

                FillListbox();    

                TitlesListBox.SelectedItem = changeTitle;

                ProjectManager.SaveToFile(allNotes);
            }
        }

        //изменение заметки
        private void ChangeNote()
        {
            //если заметка не выбрана завершаем выполнение обработчика(ничего не происходит при нажатии на "Изменить")
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            //получаем выбранную заметку
            var selectedIndex = TitlesListBox.SelectedIndex; //индекс нашей заметки в списке всех заметок allNotes

            var selectedNote = allNotes.Notes[selectedIndex]; //сама заметка

            var inner = new NoteForm(); //создаем форму

            inner.Note = selectedNote; //передаем форме данные

            //если было нажато Cancel завершаем выполнение обработчика
            if (inner.ShowDialog() == DialogResult.OK)
            {
                var updatedNote = inner.Note; //забираем измененные данные

                //удалить и заменить старые данные
                allNotes.Notes.RemoveAt(selectedIndex);

                allNotes.Notes.Add(updatedNote);

                FillListbox();

                var changeTitle = updatedNote.Title;

                TitlesListBox.SelectedItem = changeTitle;

                ProjectManager.SaveToFile(allNotes);
            }
        }

        //удаление заметки
        private void DeleteNote()
        {
            //если заметка не выбрана завершаем выполнение обработчика(ничего не происходит при нажатии на "Удалить")
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            //получаем выбранную заметку
            var selectedNotesIndex = TitlesListBox.SelectedIndex; //индекс нашей заметки в списке всех заметок allNotes

            var selectedIndexList = TitlesListBox.SelectedIndex; //индекс выбранной заметки в TitleListBox

            TitlesListBox.Items.RemoveAt(selectedIndexList);

            allNotes.Notes.RemoveAt(selectedNotesIndex);

            FillListbox();

            ClearRigthPanel();

            splitContainerNote.Panel2.Visible = false;

            ProjectManager.SaveToFile(allNotes);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CategorysComboBox.Items.Add("All");

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

            CategorysComboBox.SelectedIndex = 0; //по умолчанию 1 категория 

            if (allNotes._currentNote != -1 && allNotes._currentNote < TitlesListBox.Items.Count)
            {
                TitlesListBox.SelectedIndex = allNotes._currentNote;
            }
            else 
            {
                splitContainerNote.Panel2.Visible = false;
            }
        }

        Project allNotes = new Project();   //список свех заметок

        List<Note> sortNotes = new List<Note>(); //отсортированный список заметок

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

            allNotes._currentNote = allNotes.RealIndexes[TitlesListBox.SelectedIndex];

            ProjectManager.SaveToFile(allNotes);

            ClearRigthPanel();

            splitContainerNote.Panel2.Visible = true;

            sortNotes = allNotes.SortWithSelectionCategory(CategorysComboBox.SelectedIndex);

            //если выбран заполняем данными правую часть окна
            TitleTextBox.Text = sortNotes[TitlesListBox.SelectedIndex].Title;

            CategoryTextBox.Text = "Category: " + sortNotes[TitlesListBox.SelectedIndex].Category;

            CreateDateTimePicker.Value = sortNotes[TitlesListBox.SelectedIndex].DateCreate;

            ChangeDateTimePicker.Value = sortNotes[TitlesListBox.SelectedIndex].DateChange;

            NoteTextBox.Text = sortNotes[TitlesListBox.SelectedIndex].Text;
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNote();                                                       
        }

        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeNote();                                                          
        }

        private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
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

                sortNotes = allNotes.SortWithSelectionCategory(CategorysComboBox.SelectedIndex);

                {
                    for (int i = 0; i < sortNotes.Count; i++)
                    {
                        TitlesListBox.Items.Add(sortNotes[i].Title);

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

            var selectedNote = sortNotes[selectedIndex]; //сама заметка

            var inner = new NoteForm(); //создаем форму

            inner.Note = selectedNote; //передаем форме данные

            //если было нажато Cancel завершаем выполнение обработчика
            if (inner.ShowDialog() == DialogResult.OK)
            {
                var updatedNote = inner.Note; //забираем измененные данные

                //удалить и заменить старые данные
                allNotes.Notes.RemoveAt(allNotes.RealIndexes[selectedIndex]);

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

            if (MessageBox.Show("Вы уверены что хотите удалить заметку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //получаем выбранную заметку
                var selectedIndex = TitlesListBox.SelectedIndex; //индекс нашей заметки в списке всех заметок allNotes

                TitlesListBox.Items.RemoveAt(selectedIndex);

                allNotes.Notes.RemoveAt(allNotes.RealIndexes[selectedIndex]);

                allNotes._currentNote = -1;

                FillListbox();

                ClearRigthPanel();

                splitContainerNote.Panel2.Visible = false;

                ProjectManager.SaveToFile(allNotes);
            }
        }
    }
}

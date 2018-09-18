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
        }
        Project firstProject = new Project();   //создал экземпляр Project

        private void button1_Click(object sender, EventArgs e)
        {
            firstProject.NoteList.Add(new Note("", NoteCategory.Other, "Какой то текст", DateTime.Now) { }); //создал и сразу добаил экземпляр в список

            ProjectManager.SaveToFile(firstProject); //сохранил

        }

        private void button2_Click(object sender, EventArgs e)

        {
            firstProject = ProjectManager.LoadFromFile(); //загрузил список заметок
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstProject.NoteList[0].Title = "Тест";  //Дата изменения должна поменяться вместе с заголовком у 1й заметки

            ProjectManager.SaveToFile(firstProject); //сохранил с изменениями
        }
    }
}

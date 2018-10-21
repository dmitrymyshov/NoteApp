using System;
using NUnit.Framework;
using NoteApp;
using System.Collections.Generic;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        private List<Note> _allNotes;

        [SetUp]
        public void InitAllNotes()
        {
            _allNotes = new List<Note>();

            _allNotes.Add(new Note("Заголовок1", NoteCategory.Work, "Текст1", DateTime.Today) { DateChange = DateTime.Today });
            _allNotes.Add(new Note("Заголовок3", NoteCategory.Work, "Текст3", DateTime.Today) { DateChange = DateTime.Today });
            _allNotes.Add(new Note("Заголовок2", NoteCategory.Work, "Текст2", DateTime.Today) { DateChange = DateTime.Today });
            _allNotes.Add(new Note("Заголовок4", NoteCategory.Work, "Текст4", DateTime.Today) { DateChange = DateTime.Today });

        }

        [Test(Description = "Проверка, что все элементы списка заметок заполнены(не нулевые)")]
        public void AllItemsAreNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(_allNotes, "Список заметок содержит незаполненые заметки");
        }

        [Test(Description = "Проверка заметок в списке на уникальность")]
        public void AllItemsAreUnique()
        {
            CollectionAssert.AllItemsAreUnique(_allNotes, "Список заметок содержит одинаковые заметки");
        }

        [Test(Description = "Проверка на равенство элементов списка")]
        public void AreEquivalent()
        {
            List<Note> allNotesTest = new List<Note>();

            allNotesTest.Add(new Note("Заголовок1", NoteCategory.Work, "Текст1", DateTime.Today) { DateChange = DateTime.Today });
            allNotesTest.Add(new Note("Заголовок3", NoteCategory.Work, "Текст3", DateTime.Today) { DateChange = DateTime.Today });
            allNotesTest.Add(new Note("Заголовок2", NoteCategory.Work, "Текст2", DateTime.Today) { DateChange = DateTime.Today });
            allNotesTest.Add(new Note("Заголовок4", NoteCategory.Work, "Текст4", DateTime.Today) { DateChange = DateTime.Today });

            for (int i = 0; i < _allNotes.Count; i++)
            {
                Assert.AreEqual(_allNotes[i].Title, allNotesTest[i].Title);
                Assert.AreEqual(_allNotes[i].Category, allNotesTest[i].Category);
                Assert.AreEqual(_allNotes[i].Text, allNotesTest[i].Text);
                Assert.AreEqual(_allNotes[i].DateChange, allNotesTest[i].DateChange);
                Assert.AreEqual(_allNotes[i].DateCreate, allNotesTest[i].DateCreate);
            }
        }
    }
}
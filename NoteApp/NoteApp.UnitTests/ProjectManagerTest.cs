using NUnit.Framework;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private Project _notesForSave;

        private Project _notesForLoad;

        private List<Note> _actualList;

        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\NoteAppTest.notes";

        [SetUp]
        public void InitNote()
        {
            _notesForSave = new Project();
            _notesForLoad = new Project();
            _actualList = new List<Note>();

            _notesForSave.Notes.Add(new Note("Заголовок1", NoteCategory.Work, "Текст1", DateTime.Today) { DateChange = DateTime.Today });
            _notesForSave.Notes.Add(new Note("Заголовок3", NoteCategory.Work, "Текст3", DateTime.Today) { DateChange = DateTime.Today });
            _notesForSave.Notes.Add(new Note("Заголовок2", NoteCategory.Work, "Текст2", DateTime.Today) { DateChange = DateTime.Today });
            _notesForSave.Notes.Add(new Note("Заголовок4", NoteCategory.Work, "Текст4", DateTime.Today) { DateChange = DateTime.Today });
        }

        [Test(Description = "Тест сериализации")]
        public void TestSerialize_CorrectValue()
        {
            var expected = _notesForSave;
            var path = _path;
            var actualList = _actualList;

            ProjectManager.SaveToFile(expected, path);

            var actual = _notesForLoad;

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(path))

            using (JsonReader reader = new JsonTextReader(sr))

            actual = (Project)serializer.Deserialize<Project>(reader);


            for (int i = 0; i < actual.Notes.Count; i++)
            {
                actualList.Add(actual.Notes[i]);
            }

            for (int i = 0; i < expected.Notes.Count; i++)
            {
                Assert.AreEqual(expected.Notes[i].Title, actualList[i].Title);
                Assert.AreEqual(expected.Notes[i].Category, actualList[i].Category);
                Assert.AreEqual(expected.Notes[i].Text, actualList[i].Text);
                Assert.AreEqual(expected.Notes[i].DateChange, actualList[i].DateChange);
                Assert.AreEqual(expected.Notes[i].DateCreate, actualList[i].DateCreate);
            }
        }

        [Test(Description = "Тест десериализации")]
        public void TestDeserialize_CorrectValue()
        {
            var expected = _notesForSave;
            var path = _path;
            var actualList = _actualList;

            var actual = ProjectManager.LoadFromFile(path);

            for (int i = 0; i < actual.Notes.Count; i++)
            {
                actualList.Add(actual.Notes[i]);
            }

            for (int i = 0; i < expected.Notes.Count; i++)
            {
                Assert.AreEqual(expected.Notes[i].Title, actualList[i].Title);
                Assert.AreEqual(expected.Notes[i].Category, actualList[i].Category);
                Assert.AreEqual(expected.Notes[i].Text, actualList[i].Text);
                Assert.AreEqual(expected.Notes[i].DateChange, actualList[i].DateChange);
                Assert.AreEqual(expected.Notes[i].DateCreate, actualList[i].DateCreate);
            }
        }
    }
}
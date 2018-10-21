using System;
using System.Collections.Generic;
using NUnit.Framework;
using NoteApp;
using NUnit.Framework.Constraints;
using NUnit.Framework.Interfaces;


namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void InitNote()
        {
            _note = new Note("Заголовок", NoteCategory.Work, "Текст", DateTime.Today){DateChange = DateTime.Today};
        }

        [TestCase("Заголовок", "Геттер Title возвращает неправильный заголовок",
            TestName = "Позитивный тест геттера Title")]
        [TestCase("Заголовок", "Сеттер Title записывает неправильный заголовок",
            TestName = "Позитивный тест сеттера Title")]
        public void TestTitleGetSet_CorrectValue(string expected, string message)
        {
            _note.Title = expected;
            var actual = _note.Title;

            Assert.AreEqual(expected, actual, message);
        }

        [Test(Description = "Негативный тест set, если поле Title больше 50 символов")]
        public void TestTitleSet_Longer50Symbols()
        {
            var wrongTitle = "ЗаголовокЗаголовокЗаголовокЗаголовокЗаголовокЗаголовокЗаголовок";

            Assert.Throws<ArgumentException>(
                () => { _note.Title = wrongTitle; },
                "Должно возникнуть исключение, если длина Title больше 50 символов");
        }

        [Test(Description = "Тест значения поля Title по умолчанию")]
        public void TestTitleSet_CorrectValue()
        {
            var expected = "Без названия";
            _note.Title = String.Empty;
            var actual = _note.Title;

            Assert.AreEqual(expected, actual, "Если поле пустое, сеттер Title не ставит заголовок Без названия");
        }

        [Test(Description = "Позитивный тест геттера Category")]
        public void TestCategoryGet_CorrectValue()
        {
            var expected = NoteCategory.Work;
            var actual = _note.Category;

            Assert.AreEqual(expected, actual, "Геттер Category возвращает неправильную категорию");
        }

        [Test(Description = "Позитивный тест сеттера Category")]
        public void TestCategorySet_CorrectValue()
        {
            var expected = NoteCategory.Work;
            _note.Category = expected;
            var actual = _note.Category;

            Assert.AreEqual(expected, actual, "Сеттер Category возвращает неправильную категорию");
        }

        [Test(Description = "Позитивный тест геттера Text")]
        public void TestTextGet_CorrectValue()
        {
            var expected = "Текст";
            var actual = _note.Text;

            Assert.AreEqual(expected, actual, "Геттер Text возвращает неправильный текст");
        }
        [Test(Description = "Позитивный тест сеттера Text")]
        public void TestTextSet_CorrectValue()
        {
            var expected = "Текст";
            _note.Text = expected;
            var actual = _note.Text;

            Assert.AreEqual(expected, actual, "Сеттер Text возвращает неправильную категорию");
        }

        [TestCase("Геттер DateChange возвращает неправильную дату",
            TestName = "Позитивный тест геттера DateChange")]
        [TestCase("Сеттер DateChange записывает неправильную дату",
            TestName = "Позитивный тест сеттера DateChange")]
        public void TestDateChangeGetSet_CorrectValue(string message)
        {
            var expected = DateTime.Now;
            _note.DateChange = expected;
            var actual = _note.DateChange;

            Assert.AreEqual(expected, actual, message);
        }

        [Test(Description = "Негативный тест set, если DateChange больше текущей даты")]
        public void TestDateChangeSet_LongerDateTimeNow()
        {
            var date = DateTime.Now;
            var wrongTitle = date.AddSeconds(1);

            Assert.Throws<ArgumentException>(
                () => { _note.DateChange = wrongTitle; },
                "Должно возникнуть исключение, если длина DateChange больше текущей даты");
        }

        [Test(Description = "Негативный тест set, если DateChange меньше DateCreate")]
        public void TestDateChangeSet_LessDateCreate()
        {
            var date = _note.DateCreate;
            var wrongTitle = date.AddSeconds(-1);

            Assert.Throws<ArgumentException>(
                () => { _note.DateChange = wrongTitle; },
                "Должно возникнуть исключение, если длина DateChange меньше DateCreate");
        }

        [Test(Description = "Позитивный тест геттера DateCreate")]
        public void TestDateCreateGet_CorrectValue()
        {
            var expected = DateTime.Today;
            var actual = _note.DateCreate;

            Assert.AreEqual(expected, actual, "Геттер DateCreate возвращает неправильную дату");
        }

        [Test(Description = "Тест коструктора класса Note")]
        public void TestNoteConstructor_CorrectValue()
        {
            var expectedNote = new Note("Заголовок", NoteCategory.Work, "Текст", DateTime.Today){DateChange =  DateTime.Today};
            var actual = _note;

            Assert.AreEqual(expectedNote.Title, actual.Title,"Неправиьное значение в поле Title");
            Assert.AreEqual(expectedNote.Category, actual.Category, "Неправиьное значение в поле Category");
            Assert.AreEqual(expectedNote.Text, actual.Text, "Неправиьное значение в поле Text");
            Assert.AreEqual(expectedNote.DateCreate, actual.DateCreate, "Неправиьное значение в поле DateCreate");
            Assert.AreEqual(expectedNote.DateChange, actual.DateChange, "Неправиьное значение в поле DateChange");
        }

        [Test(Description = "Тест Clone в классе Note")]
        public void TestClone_CorrectValue()
        {
            var expectedNote = new Note("Заголовок", NoteCategory.Work, "Текст", DateTime.Today) { DateChange = DateTime.Today };
            var actual = (Note)_note.Clone();
            
            Assert.AreEqual(expectedNote.Title, actual.Title, "Неправиьное значение в поле Title");
            Assert.AreEqual(expectedNote.Category, actual.Category, "Неправиьное значение в поле Category");
            Assert.AreEqual(expectedNote.Text, actual.Text, "Неправиьное значение в поле Text");
            Assert.AreEqual(expectedNote.DateCreate, actual.DateCreate, "Неправиьное значение в поле DateCreate");
            Assert.AreEqual(expectedNote.DateChange, actual.DateChange, "Неправиьное значение в поле DateChange");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки, хранящий информацию о заголовке, категории, тексте и времени создания и изменении
    /// </summary>
    public class Note : ICloneable
    {
        private string _title;

        private NoteCategory _noteCategory;

        private string _text;

        private DateTime _dateCreate;

        private DateTime _dateChange;

        /// <summary>
        /// Возвращает и задает заголовок заметки
        /// </summary>
        public string Title
        {
            get { return _title; }

            set
            {
                if (value.Length == 0)
                {
                    _title = "Без названия";
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина заголовка должна быть в интервале (1;50) знаков");
                }
                else
                {
                    _title = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает категорию заметки
        /// </summary>
        public NoteCategory Category
        {
            get { return _noteCategory; }

            set
            {
                _noteCategory = value;
            }
        }

        /// <summary>
        /// Возвращает и задает текст заметки
        /// </summary>
        public string Text
        {
            get { return _text; }

            set
            {
                _text = value;
            }
        }

        /// <summary>
        /// Возвращает время создания заметки
        /// </summary>
        public DateTime DateCreate { get; private set; }

        /// <summary>
        /// Возвращает время изменения заметки
        /// </summary>
        public DateTime DateChange
        {
            get { return _dateChange; }

            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата изменения не может быть больше текущей даты");
                }
                else if (value < DateCreate)
                {
                    throw new ArgumentException("Дата изменения не может быть меньше даты создания");
                }
                else
                {
                    _dateChange = value;
                }
            }
        }

        /// <summary>
        /// Созддание заметки
        /// </summary>
        ///<param name="title">Заголовок новой заметки</param>
        ///<param name="noteCategory">Категория новой заметки</param>
        ///<param name="text">Текст новой заметки</param>
        ///<param name="dateCreate">Дата создания новой заметки</param>
        public Note(string title, NoteCategory noteCategory, string text, DateTime dateCreate)
        {
            Title = title;
            Category = noteCategory;
            Text = text;
            DateCreate = dateCreate;
        }



        /// <summary>
        /// Клонирование заметки
        /// </summary>
        /// <returns>Возвращает копию заметки</returns>
        public object Clone()
        {
            return new Note(this.Title, this.Category, this.Text, this.DateCreate)
            {
                DateChange = this.DateChange
            };
        }
    }
}
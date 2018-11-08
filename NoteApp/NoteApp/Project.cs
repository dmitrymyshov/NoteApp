using System.Collections.Generic;

namespace NoteApp
{
    /// <summary>
    /// Класс заметок, содержащий список всех заметок.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes = new List<Note>();

        /// <summary>
        /// Список реальных индексов сортированного списка
        /// </summary>
        public List<int> RealIndexes = new List<int>();

        /// <summary>
        /// Индекс текущей заметки
        /// </summary>
        public int _currentNote = -1;

        private void Sort()
        {
            Notes.Sort((a, b) => b.DateChange.CompareTo(a.DateChange));
        }

        public List<Note> SortWithSelectionCategory(int category)
        {
            var sortNotes = new List<Note>();

            Sort();

            //если выбрана категория All
            if (category == 0)
            {
                RealIndexes.Clear();

                for (int i = 0; i < Notes.Count; i++)
                {
                    sortNotes.Add(Notes[i]);
                    RealIndexes.Add(i);
                }
            }
            //если другая категория
            else
            {
                RealIndexes.Clear();

                for (int i = 0; i < Notes.Count; i++)
                {
                    if ((int)Notes[i].Category == category - 1)
                    {
                        sortNotes.Add(Notes[i]);
                        RealIndexes.Add(i);
                    }
                }
            }
            return sortNotes;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Класс, отвечающий за сериализацию заметок
    /// </summary>
    public class ProjectManager
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\NoteApp.notes";  //Закрытая константа, содержащая путь 

        /// <summary>
        /// Сохранение списка заметок
        /// </summary>
        /// <param name="data">Список заметок</param>
        /// <param name="fileName">Путь к файлу</param>
        public static void SaveToFile(Project data, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            
            using (StreamWriter sw = new StreamWriter(fileName))

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, (Project)data);
            }

        }

        /// <summary>
        /// Сохранения списка заметок в путь по умолчанию
        /// </summary>
        /// <param name="data">Список заметок</param>
        public static void SaveToFile(Project data)
        {
            SaveToFile(data, _path);
        }

        /// <summary>
        /// Загрузка списка заметок
        /// </summary>
        /// <returns>Список заметок</returns>
        public static Project LoadFromFile(string fileName)
        {
            Project data = null;

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(fileName))

            using (JsonReader reader = new JsonTextReader(sr))
            {
                data = (Project)serializer.Deserialize<Project>(reader);
            }
            return data;
        }

        /// <summary>
        /// Загрузка списка из файла в путь по умолчанию
        /// </summary>
        /// <returns>Возвращает список заметок</returns>
        public static Project LoadFromFile()
        {
            return LoadFromFile(_path);
        }
    }
}

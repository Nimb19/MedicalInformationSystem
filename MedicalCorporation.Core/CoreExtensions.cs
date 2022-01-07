using MedicalCorporation.Core.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MedicalCorporation.Core
{
    public static class CoreExtensions
    {
        public static DateTime RoundUp(this DateTime dt, TimeSpan d)
        {
            return new DateTime((dt.Ticks + d.Ticks - 1) / d.Ticks * d.Ticks, dt.Kind);
        }

        public static string GetFIO(this User userBase)
        {
            return $"{userBase.Surname} {userBase.Name} {userBase.Patronymic}";
        }

        public static string ValidateString(string tbtext, string fieldName)
        {
            return string.IsNullOrWhiteSpace(tbtext)
                ? throw new ArgumentNullException(fieldName)
                : tbtext.Trim();
        }

        public static void WriteToFile(string text, string pathToFile, bool append = false)
        {
            using (var sw = new StreamWriter(pathToFile, append, CoreConstants.Encoding))
                sw.Write(text);
        }

        public static T DeserializeFile<T>(string pathToFile)
        {
            var fileText = ReadFile(pathToFile);
            return JsonConvert.DeserializeObject<T>(fileText);
        }

        public static void SerializeToFile<T>(T obj, string pathToFile)
        {
            var text = JsonConvert.SerializeObject(obj, Formatting.Indented);
            WriteToFile(text, pathToFile, append: false);
        }

        public static string FormatToDate(this DateTime dateTime, bool fullDate = false)
        {
            if (fullDate)
            {
                var postfix = string.Empty;
                if (dateTime.Hour > 12)
                    postfix = "PM";
                else
                    postfix = "AM";

                return dateTime.ToString($"yyyy-dd-MM hh:mm") + $" {postfix}";
            }
            else
                return dateTime.ToString("yyyy-MM-dd");
        }

        internal static T CloneBySerialize<T>(T obj)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj));
        }

        public static string ReadFile(string pathToFile)
        {
            using (var sr = new StreamReader(pathToFile, CoreConstants.Encoding))
                return sr.ReadToEnd();
        }

        public static int ValidateInt(string text, string fieldName)
        {
            return int.TryParse(ValidateString(text, fieldName), out var result)
                ? result
                : throw new ArgumentNullException(fieldName);
        }

        public static void SerializeToFile(object obj, string pathToFile)
        {
            var text = JsonConvert.SerializeObject(obj, Formatting.Indented);
            WriteToFile(text, pathToFile, false);
        }
    }
}

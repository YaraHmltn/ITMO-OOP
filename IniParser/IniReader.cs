using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


namespace Parser
{
    class iniReader
    {
        public string FilePath;

        private Dictionary<string, Dictionary<string, string>> Tree = new Dictionary<string, Dictionary<string, string>>();



        public iniReader(string text)
        {
            FilePath = text;
            Read();
        }

        public void Read()
        {


            if (!File.Exists(FilePath))
            {
                throw new InvalidPathException("Не удалось считать файл");
            }


            if (Path.GetExtension(FilePath) != ".ini")
            {
                throw new InvalidExtensionException("Неверное расширение");
            }

            StreamReader fileReader = new StreamReader(FilePath);

            string s = fileReader.ReadLine();
            string CurrentSection = "";
            while (s != null)
            {
                if (Regex.IsMatch(s, @"^\[\w*"))
                {
                    s = s.Trim(new char[] { '[', ']' });
                    Tree.Add(s, new Dictionary<string, string>());
                    CurrentSection = s;
                }
                else if (String.IsNullOrEmpty(s) || Regex.IsMatch(s, @"^;\w*")) { }
                else
                {

                    if (s.Contains(";"))
                    {
                        s = s.Remove(s.IndexOf(';'));
                    }


                    string[] words = s.Split(new char[] { '=' });

                    string key = words[0].Trim();
                    string value = words[1].Trim();

                    Tree[CurrentSection].Add(key, value);

                }

                s = fileReader.ReadLine();
            }

        }

        public T TryGetValue<T>(string Section, string Key)
        {
            string Value = Tree[Section][Key];

            if (!Tree.ContainsKey(Section) || !Tree[Section].ContainsKey(Key))
            {
                throw new SectionKeyPairDoesntExistsException("Заданной пары СЕКЦИЯ ПАРАМЕТР нет в конфигурационном файл");
            }


            try
            {
                T tmp = (T)Convert.ChangeType(Value, typeof(T));
            }
            catch
            {
                throw new ConversionErrorException("Неверный тип значения");
            }


            return (T)Convert.ChangeType(Value, typeof(T));
        }

    }
}
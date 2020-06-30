using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;

namespace DeadLine6
{
    public static class FileWorker
    {
        public static List<T> GetObjects<T>(string Path)
        {
            string content = File.ReadAllText(Path);
            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
                return new List<T>();
            return JsonConvert.DeserializeObject<List<T>>(content);
        }

        public static void SaveObjects<T>(List<T> Objects, string Path)
        {
            string content = JsonConvert.SerializeObject(Objects);
            File.WriteAllText(Path, content);
        }
    }
}

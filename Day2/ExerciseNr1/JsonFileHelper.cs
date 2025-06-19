using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNr1
{
    public class JsonFileHelper<T> where T: new()
    {
        private readonly string _filePath;

        public JsonFileHelper(string filePath)
        {
            _filePath = filePath;
        }

        public void SerializeToFile(T data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public T DeserializeFromFile()
        {
            if(!File.Exists(_filePath))
            return new T();

            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<T>(json);

        }
    }
}

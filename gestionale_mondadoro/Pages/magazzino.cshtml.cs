using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace gestionale_mondadoro.Pages
{
    public class StorageItem
    {
        public string Name { get; set; }
        public int Qnty { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var storageItem = new StorageItem
            {
                Name = "test",
                Qnty = 1
            };

            //string fileName = "StorageItem.json";
            //using FileStream createStream = File.Create(fileName);
            //await JsonSerializer.SerializeAsync(createStream, storageItem);
            //await createStream.DisposeAsync();

            //Console.WriteLine(File.ReadAllText(fileName));

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(storageItem, options);

            Console.WriteLine(jsonString);
        }
        
    }
}
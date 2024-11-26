using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace WpfApp1
{
    public class Film
    {
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }
        [CustomValidation(ErrorMessage = "Quantity must be either 'In Stock' or 'Out Stock'")]
        public string Quantity { get; set; }
        public void SerializeToJson(string filePath, List<Film> n)
        {
            string json = JsonConvert.SerializeObject(n);
            File.WriteAllText(filePath, json);
        }
        public List<Film> ReadJsonFile(string filePath)
        {
            List<Film> description = null;
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                description = JsonConvert.DeserializeObject<List<Film>>(json);
            }
            return description;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace WeatherApp.OpenWeather
{
    class weather
    {
        public int id; 
        public string main;
        public string description;

        public string icon;

        public Bitmap Icon
        {
            get
            {
               return new Bitmap(Image.FromFile($"icons\\{icon}.png"));
               // string imagePath = $"icons\\{icon}.png";
               // Console.WriteLine($"Загрузка изображения из: {imagePath}");
               // return new Bitmap(Image.FromFile(imagePath));
            }
        }
    }
}

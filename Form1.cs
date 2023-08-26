using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=Moscow&APPID=002a6743b86ec6babf91ae2161124b9d");

            request.Method = "POST";

            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }
            response.Close();

            richTextBox1.Text = answer;

            OpenWeather.OpenWeather oW = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);

            panel1.BackgroundImage = oW.weather[0].Icon;

            label1.Text = oW.weather[0].main;

            label2.Text = oW.weather[0].description;

            label3.Text = "Средняя температрура ('C): " + oW.main.temp.ToString("0.##");

            label6.Text = "Скорость (м/с): " + oW.wind.speed.ToString();

            label7.Text = "Направление : "+oW.wind.deg.ToString();

            label4.Text = "Влажность (%): "+oW.main.humidity.ToString();

            label5.Text ="Давление (мм): "+((int)oW.main.pressure).ToString();
        }
    }
}
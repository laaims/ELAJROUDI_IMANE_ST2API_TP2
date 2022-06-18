using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

public class Program

{
    
public partial class WeatherApp
    {
        public WeatherApp()
        {
            HttpClient= new HttpClient();
        }
//public async Task GetWeatherAtCoord(Coordinates coord){
    //var uri = BuildUri(coord.Lat, cood.lon)
    //await Connect(uri)}
        // API key
        private const string APIKey = "d09d85ca6f9120e8d0c2857a93e05f9b";
        private HttpClient HttpClient{get;set;}

        // Graphical Interface
        private void WeatherApp_Load(object sender, EventArgs e)
        {
            getWeather();
        }

         void getWeather()
        {
            
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={APIKey}", APIKey);
                var json = HttpClient.Downloadstring(url);

                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + myDeserializedClass.Weather[0].icon + ".png";

                String Condition = myDeserializedClass.Weather[0].main;
                double temp = myDeserializedClass.Weather[0].description;
                long sunset= myDeserializedClass.Sys.sunset.ToString();
                long sunrise = myDeserializedClass.Sys.sunrise.ToString();
                double humidity = myDeserializedClass.Main.humidity.ToString();
                double pressure = myDeserializedClass.Main.pressure.ToString;
                double speed = myDeserializedClass.Wind.speed.ToString();
                
            }
        }

    }       

}






//public static async Task Main()
  //  {
    //    var class = new Class1();
//
     //   Console.WriteLine("Please enter the coord of a city to get its weather(lat,lon); ");
  ///      var input = Console.ReadLine();
       // var coord= Coordinates.BuildFromInput(input);
        //var weatherObject=await class.GetWeatherAtCoord(coord);
        //var weather= weather.data.weather.description;
        //Console.WriteLine($"At coord({lat},{lon}), the weater is : {weather.data.weather.description}");

    //}
    //catch (Excepyion e){
        //Console.Writeline(e);
        //throw;
    //}

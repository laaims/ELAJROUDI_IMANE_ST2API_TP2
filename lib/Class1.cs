using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace lib;
public class Class1
{
    public class Coordinates
    {
        public float latittude { get; set; }
        public float longitude { get; set; }
    }

    public Coordinates (float lat, float lon){
        latittude = lat;
        longitude =lon;


    }
    public static Coordinates BuildFromInput(string input){
        if (string.IsNullOrWhiteSpace(input)) return new Coordinates(39.31f, -74.5f);
        var result = input.Split(',');
        float.TryParse(new string(result[0].Where(char.IsDigit).ToArray()), out var lat);
        float.TryParse(new string(result[1].Where(char.IsDigit).ToArray()), out var lon);

    }
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
    }

     public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }

    }

    public class Clouds
    {
        public int all { get; set; }
    }
    public class Root
    {
        public Coordinates coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}

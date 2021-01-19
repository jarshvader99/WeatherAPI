using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherAPI.Models
{
 
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Weather
        {
            [JsonPropertyName("icon")]
            public string Icon;

            [JsonPropertyName("code")]
            public int Code;

            [JsonPropertyName("description")]
            public string Description;
        }

        public class Datum
        {
            [JsonPropertyName("rh")]
            public double Rh;

            [JsonPropertyName("pod")]
            public string Pod;

            [JsonPropertyName("lon")]
            public double Lon;

            [JsonPropertyName("pres")]
            public double Pres;

            [JsonPropertyName("timezone")]
            public string Timezone;

            [JsonPropertyName("ob_time")]
            public string ObTime;

            [JsonPropertyName("country_code")]
            public string CountryCode;

            [JsonPropertyName("clouds")]
            public double Clouds;

            [JsonPropertyName("ts")]
            public double Ts;

            [JsonPropertyName("solar_rad")]
            public double SolarRad;

            [JsonPropertyName("state_code")]
            public string StateCode;

            [JsonPropertyName("city_name")]
            public string CityName;

            [JsonPropertyName("wind_spd")]
            public double WindSpd;

            [JsonPropertyName("wind_cdir_full")]
            public string WindCdirFull;

            [JsonPropertyName("wind_cdir")]
            public string WindCdir;

            [JsonPropertyName("slp")]
            public double Slp;

            [JsonPropertyName("vis")]
            public double Vis;

            [JsonPropertyName("h_angle")]
            public double HAngle;

            [JsonPropertyName("sunset")]
            public string Sunset;

            [JsonPropertyName("dni")]
            public double Dni;

            [JsonPropertyName("dewpt")]
            public double Dewpt;

            [JsonPropertyName("snow")]
            public double Snow;

            [JsonPropertyName("uv")]
            public double Uv;

            [JsonPropertyName("precip")]
            public double Precip;

            [JsonPropertyName("wind_dir")]
            public double WindDir;

            [JsonPropertyName("sunrise")]
            public string Sunrise;

            [JsonPropertyName("ghi")]
            public double Ghi;

            [JsonPropertyName("dhi")]
            public double Dhi;

            [JsonPropertyName("aqi")]
            public object Aqi;

            [JsonPropertyName("lat")]
            public double Lat;

            [JsonPropertyName("weather")]
            public Weather Weather;

            [JsonPropertyName("datetime")]
            public string Datetime;

            [JsonPropertyName("temp")]
            public double Temp;

            [JsonPropertyName("station")]
            public string Station;

            [JsonPropertyName("elev_angle")]
            public double ElevAngle;

            [JsonPropertyName("app_temp")]
            public double AppTemp;
        }

        public class CurrentWeatherModel
        {
            [JsonPropertyName("data")]
            public List<Datum> Data;

            [JsonPropertyName("count")]
            public int Count;
        }

    
}

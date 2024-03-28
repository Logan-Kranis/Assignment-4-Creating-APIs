using System.ComponentModel.DataAnnotations;
//Logan Kranis
namespace assigment4_api.entities
{
  

    public class Weather
    {
        public decimal? Temperature { get; set; }
        public decimal? Pressure { get; set; }
        public decimal? Humidity { get; set; }
        public decimal? Precipitation { get; set; }
        public decimal? WindSpeed { get; set; }
        public int Id { get; set; }
        public DateTime? Date { get; set; }
    }

}
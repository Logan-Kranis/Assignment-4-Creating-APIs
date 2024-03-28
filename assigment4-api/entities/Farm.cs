using System.ComponentModel.DataAnnotations;
//Logan Kranis
namespace assigment4_api.entities
{
    public class Farm
    {
            public string Address { get; set; }
            public string ZipCode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Name { get; set; }
            public int Id { get; set; }
            public decimal Latitude { get; set; }
            public decimal Longitude { get; set; }
        

    }
}

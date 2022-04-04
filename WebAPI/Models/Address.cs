namespace WebAPI.Models
{
    public class Address
    {
        public int id { get; set; }
        public float number { get; set; }
        public string street { get; set; }
        public string side { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public string timezone { get; set; }
        public string airport_code { get; set; }
        public int location_property_id { get; set; }
        public int weather_id { get; set; }
    }
}
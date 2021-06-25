namespace TestApp.DataAccessLayer.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string OfficeName { get; set; }
        public string Adds { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public ContactInfo ContactInfo { get; set; }

    }
}

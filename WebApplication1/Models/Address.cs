

public class Address
{
    public int AddressId { get; set; }
    public int UserId { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    //public User User { get; set; } // Navigation property to the user entity
}

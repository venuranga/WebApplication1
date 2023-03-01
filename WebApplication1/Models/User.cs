
// User entity model
public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public int AddressId { get; set; }
   /* public Address Address { get; set; } // Navigation property to the address entity
    public ICollection<Bid> Bids { get; set; } // Navigation property to the bid entity
   */
}
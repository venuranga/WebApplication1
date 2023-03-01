using System.Security.Cryptography;

public class Car
{
    public int CarId { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }
    public decimal CurrentBidPrice { get; set; }
   // public ICollection<Bid> Bids { get; set; } // Navigation property to the bid entity
   // public ICollection<Auction> Auctions { get; set; } // Navigation property to the auction entity
}
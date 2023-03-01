public class Payment
{
    public int PaymentId { get; set; }
    public int UserId { get; set; }
    public int CarId { get; set; }
    public decimal PaymentAmount { get; set; }
    public DateTime PaymentTimestamp { get; set; }

    public int AuctionId { get; set; }
    /*public User User { get; set; } // Navigation property to the user entity
    public Car Car { get; set; } // Navigation property to the car entity

    public Auction Auction { get; set; }
    */
}
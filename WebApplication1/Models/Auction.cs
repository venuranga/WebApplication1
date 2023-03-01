public class Auction
{
    public int AuctionId { get; set; }
    public int CarId { get; set; }
    public decimal StartingBidPrice { get; set; }
    public DateTime AuctionStartTime { get; set; }
    public DateTime AuctionEndTime { get; set; }
    /*public Car Car { get; set; } // Navigation property to the car entity

    public Payment Payment { get; set; }

    public ICollection<Bid> Bids { get; set; }
    */
}
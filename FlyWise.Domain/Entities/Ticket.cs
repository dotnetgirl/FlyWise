using FlyWise.Domain.Commons;

namespace FlyWise.Domain.Entities;

public class Ticket : Auditable
{
    public string FlightNumber { get; set; }
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTIme { get; set; }
    public int DurationOfFlying { get; set; }
    public decimal Price { get; set; }
}

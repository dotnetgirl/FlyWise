using FlyWise.Domain.Commons;

namespace FlyWise.Domain.Entities;

public class Flight : Auditable
{
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public DateTime? DepartureTime { get; set; }
    public DateTime? ArrivalTime { get; set; }
    public string Airline { get; set; }
    public string TypeAirplane { get; set; }
    public decimal Price { get; set; }
}
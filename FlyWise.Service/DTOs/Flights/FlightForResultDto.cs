namespace FlyWise.Service.DTOs.Flights;
public class FlightForResultDto
{
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public DateTime? DepartureTime { get; set; }
    public DateTime? ArrivalTime { get; set; }
    public decimal Price { get; set; }
}
namespace FlyWise.Service.DTOs.Tıckets;
public class TicketForCreationDto
{
    public string FlightNumber { get; set; }
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int DurationOfFlying { get; set; }
    public decimal Price { get; set; }
}
namespace FlyWise.Service.DTOs.Tıckets;
public class TicketForResultDto
{
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int DurationOfFlying { get; set; }
}

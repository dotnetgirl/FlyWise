using System.ComponentModel;
using System.Text.Json.Serialization;
namespace FlyWise.Service.DTOs.Users;
public class UserForResultDto
{
    public long Id { get; set; }

    [DisplayName("FirstName")]
    public string FirstName { get; set; }

    [DisplayName("LastName")]
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}
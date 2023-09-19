﻿using FlyWise.Domain.Commons;
using FlyWise.Domain.Enums;`
namespace FlyWise.Domain.Entities;

public class User : Auditable
{
    [MinLength(3), MaxLength(50)]
    public string FirstName { get; set; }
    [MinLength(3), MaxLength(50)]
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public UserRole Role { get; set; }
}
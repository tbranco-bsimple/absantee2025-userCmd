using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.DTO;

public record UserFromCollabDTO
{
    public string Names { get; set; }
    public string Surnames { get; set; }
    public string Email { get; set; }
    public DateTime DeactivationDate { get; set; }

    public UserFromCollabDTO()
    {
    }

    public UserFromCollabDTO(string names, string surnames, string email, DateTime deactivationDate)
    {
        Names = names;
        Surnames = surnames;
        Email = email;
        DeactivationDate = deactivationDate;
    }
}

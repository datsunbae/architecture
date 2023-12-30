using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Contracts.Authentication
{
    public record RegisterRequest
    (
        string FirstName,
        string LastName,
        string Email,
        string Password
    );
}

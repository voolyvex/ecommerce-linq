using System;
using System.Collections.Generic;

namespace DatabaseFirstLINQ.Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
    public virtual ICollection<UserRole> UserRoles { get; set; }
}

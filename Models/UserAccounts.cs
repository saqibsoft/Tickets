﻿using System;
using System.Collections.Generic;

namespace Tickets.Models
{
    public partial class UserAccounts
    {
        public int UserId { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}

﻿using ApplicationLayer.IRepoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace InfrastructurLayer.Services
{
    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string hashedPassword, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}

﻿namespace SharedMomentsBackend.App.Models.DTOs.User
{
    public class LoginResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Token { get; set; }
        public string? ProfilePicture { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Identity;

namespace src.Entities
{
    public class ApplicationUser:IdentityUser
    {

        public string PostAddress { get; set; }
        public string Language { get; set; } = "english";
        public bool LargeText { get; set; }
        public bool ScreenReader { get; set; }
        public bool HighContrast { get; set; }
    }
}

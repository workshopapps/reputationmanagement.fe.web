﻿namespace src.Models.Dtos
{
    public class ExternalAuthDto
    {
        public string? Provider { get; set; }
        public string? IdToken { get; set; }
        public string? BusinessName { get; set; }
    }
}

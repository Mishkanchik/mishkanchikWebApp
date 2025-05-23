﻿using Microsoft.AspNetCore.Http;

namespace pd311_web_api.BLL.DTOs.Car
{
    public class CreateCarDto
    {
        public required string Model { get; set; }
        public required string Brand { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string? Color { get; set; }
        public string? Gearbox { get; set; }
        public string? Manufacture { get; set; }
        public List<IFormFile> Images { get; set; } = [];
    }
}

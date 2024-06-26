﻿using System.ComponentModel.DataAnnotations;

namespace ASP_EF_Core_MVC_Test2.Models;

public class Product
{
    public int Id { get; set; }
    [MaxLength(100)]
    public required string Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }
    public required int Price { get; set; }
    [MaxLength(200)]
    public string? ImageUrl { get; set; }
    [MaxLength(100)]
    public string? ImageAltText { get; set; }

    public List<OrderItem> OrderItems { get; set; } = []; // Navigation property
}
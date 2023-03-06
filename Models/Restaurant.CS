using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Restaurant
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime VisitDate { get; set; }
    public string? Cuisine { get; set; }
}
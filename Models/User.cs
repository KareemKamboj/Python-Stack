using System.ComponentModel.DataAnnotations;

public class User
{
    [Required(ErrorMessage = "is required.")] 
    [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
    public string Name {get; set; }

    [Required(ErrorMessage = "is required.")] 
    public string Location { get; set; }

    [Required(ErrorMessage = "is required.")] 
    public string Language { get; set; }

    [MinLength(20, ErrorMessage = "Must be at least 20 characters")]
    public string? Comments { get; set; }

}
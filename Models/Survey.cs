using System.ComponentModel.DataAnnotations;
namespace FirstFormValidation.Models
{
  public class Survey
  {
    [Required]
    [MinLength(2)]
    public string Name { get; set; }
    [Required]
    public string Dojo { get; set; }
    [Required]
    public string Language { get; set; }

    [MaxLength(20)]
    public string Comment { get; set; }

    // public Survey(string name, string dojo, string language)
    // {
    //   Name = name;
    //   Dojo = dojo;
    //   Language = language;

    // }
    // public Survey(string name, string dojo, string language, string comment)
    // {
    //   Name = name;
    //   Dojo = dojo;
    //   Language = language;
    //   Comment = comment;
    // }
  }
}
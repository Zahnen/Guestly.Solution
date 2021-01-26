using System.ComponentModel.DataAnnotations;

namespace Guestly.ViewModels
{
  public class CreateRoleViewModel
  {
    [Required]
    public string RoleName { get; set; }
  }
}
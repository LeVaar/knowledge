using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure.Design;
using System.Windows;

namespace FinalProject.ViewModel
{
    public class Disease : BaseVM
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}
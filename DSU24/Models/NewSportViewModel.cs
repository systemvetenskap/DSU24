using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DSU24.Models
{
    public class NewSportViewModel
    {
        [Required(ErrorMessage ="Du måste fylla i namnet")]
        public string Name { get; set; }

        public int SelectedCategory { get; set; }
        public List<SelectListItem> Categories { get; set; }

        public NewSportViewModel()
        {
            Categories = new List<SelectListItem>
            {
                new SelectListItem{Value="1", Text="Vintersport"},
                new SelectListItem{Value="2", Text="Sommarsport"},
            };
        }
    }
}

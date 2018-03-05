using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CheeseMVC.Models2;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must give your cheese a description.")]
        public string Description { get; set; } 

        [Required]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        public CheeseCategory Category { get; set; }
        public List<SelectListItem> Categories { get; set; }

        public AddCheeseViewModel(IEnumerable<CheeseCategory> categories)
        {

            Categories = new List<SelectListItem>();

            foreach (CheeseCategory cat in categories)
            {
                Categories.Add(new SelectListItem
                {
                    Value = cat.ID.ToString(),
                    Text = cat.Name
                });
            }
        }

        public AddCheeseViewModel() { }


    }
}



/*CheeseTypes = new List<SelectListItem>();

CheeseTypes.Add(new SelectListItem {

    Value = ((int)CheeseCategory.Hard).ToString(),
    Text = CheeseType.Hard.ToString()
})

CheeseTypes.Add(new SelectListItem
{

    Value = ((int)CheeseType.Soft).ToString(),
    Text = CheeseType.Soft.ToString()
});

CheeseTypes.Add(new SelectListItem
{

    Value = ((int)CheeseType.Fake).ToString(),
    Text = CheeseType.Fake.ToString()
});*/

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ePlants.Data
{
    public enum PlantCategory
    {
        [Display(Name = "Planta de interior")]
        Indoor,
        [Display(Name = "Planta de exterior")]
        Outdoor,
        [Display(Name = "Planta de interior & exterior")]
        IndoorOutdoor
    }
}

using MedarbejderVagtKaos.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using static MedarbejderVagtKaos.Models.Vagtplan.Vagt;

namespace MedarbejderVagtKaos.Pages.Vagtplan
{
    public class CreateVagtModel : PageModel
    {
        private readonly IVagtService _vagtService;

        [BindProperty]
        public Models.Vagtplan.Vagt Vagt { get; set; } = new Models.Vagtplan.Vagt();
        public SelectList MedarbejderOptions { get; set; }

        public CreateVagtModel(IVagtService vagtService)
        {
            _vagtService = vagtService;
            Vagt = new Models.Vagtplan.Vagt
            {
                AssignedMedarbejder = new Models.Vagtplan.Vagt.Medarbejder("", "", 0)
            };

            MedarbejderOptions = new SelectList(Models.Vagtplan.Vagt.MedarbejderOptions(), nameof(Medarbejder.MedarbejderName), nameof(Medarbejder.MedarbejderName), nameof(Medarbejder.MedarbejderEmail));

        }

        public SelectList StartTidOptions()
        {
            return new SelectList(Models.Vagtplan.Vagt.StartTidOptions());
        }

        public SelectList SlutTidOptions()
        {
            return new SelectList(Models.Vagtplan.Vagt.SlutTidOptions());
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Get the selected Medarbejder from the dropdown
            var selectedMedarbejderName = Vagt.AssignedMedarbejder.MedarbejderName;

            // Retrieve the complete Medarbejder with all information
            var selectedMedarbejder = Models.Vagtplan.Vagt.MedarbejderOptions()
                .Where(m => m.MedarbejderName == selectedMedarbejderName)
                .FirstOrDefault();

            if (selectedMedarbejder == null)
            {
                // Handle the case where selectedMedarbejder is not found
                // You might want to add proper error handling or redirect back to the page with an error message
                return Page();
            }

            // Set AssignedMedarbejder with the selected Medarbejder
            Vagt.AssignedMedarbejder = selectedMedarbejder;

            // Add the Vagt
            _vagtService.AddVagt(Vagt);

            return RedirectToPage("GetAllVagter");
        }
    }
}


//_vagtService.AddVagt(Vagt);
//Console.WriteLine("1");
//if (!ModelState.IsValid)
//{
//    Console.WriteLine("2");
//    return Page();
//    Console.WriteLine("3");
//}
//_vagtService.AddVagt(Vagt);

//return RedirectToPage("GetAllVagter");

using MedarbejderVagtKaos.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MedarbejderVagtKaos.Pages.Vagtplan
{
    public class CreateVagtModel : PageModel
    {
        #region Properties

        private readonly IVagtService _vagtService;
		
		

        [BindProperty]
        public Models.Vagtplan.Vagt Vagt { get; set; }
		#endregion

		#region Constructor
		public CreateVagtModel(IVagtService vagtService)
		{
			_vagtService = vagtService;
			
		}

		#endregion

		#region Methods
		public SelectList MedarbejderOptions()
		{
			return new SelectList(Models.Vagtplan.Vagt.MedarbejderOptions());
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

			_vagtService.AddVagt(Vagt);

			return RedirectToPage("GetAllVagter");
		}

		#endregion
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
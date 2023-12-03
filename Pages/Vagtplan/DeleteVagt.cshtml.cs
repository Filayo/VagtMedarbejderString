using MedarbejderVagtKaos.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedarbejderVagtKaos.Pages.Vagtplan
{
	public class DeleteVagtModel : PageModel
	{
		private IVagtService _vagtService;

		public DeleteVagtModel(IVagtService vagtService)
		{
			_vagtService = vagtService;
		}

		[BindProperty]
		public Models.Vagtplan.Vagt Vagt { get; set; }


		public IActionResult OnGet(int id)
		{
			Vagt = _vagtService.GetVagt(id);
			if (Vagt == null)
				return RedirectToPage("/Error"); 

			return Page();
		}

		public IActionResult OnPost()
		{
			Models.Vagtplan.Vagt deletedVagt = _vagtService.DeleteVagt(Vagt.Id);
			if (deletedVagt == null)
				return RedirectToPage("/Error");

			return RedirectToPage("GetAllVagter");
		}
	}
}

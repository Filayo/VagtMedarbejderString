using MedarbejderVagtKaos.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MedarbejderVagtKaos.Pages.Vagtplan
{
	public class EditVagtModel : PageModel
	{
		private IVagtService _vagtService;

		public EditVagtModel(IVagtService vagtService)
		{
			_vagtService = vagtService;
		}

		[BindProperty]
		public Models.Vagtplan.Vagt Vagt { get; set; }

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

		public IActionResult OnGet(int id)
		{
			Vagt = _vagtService.GetVagt(id);
			if (Vagt == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			return Page();
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_vagtService.UpdateVagt(Vagt);
			return RedirectToPage("GetAllVagter");
		}
	}
}

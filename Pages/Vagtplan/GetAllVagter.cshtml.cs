using MedarbejderVagtKaos.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedarbejderVagtKaos.Pages.Vagtplan
{
	public class GetAllVagterModel : PageModel
	{
		private IVagtService _vagtService;

		public GetAllVagterModel(IVagtService vagtService)
		{
			_vagtService = vagtService;
		}

		public List<Models.Vagtplan.Vagt>? Vagter { get; private set; }

		public void OnGet()
		{
			Vagter = _vagtService.GetVagter();
		}
	}
}

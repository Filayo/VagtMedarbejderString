using MedarbejderVagtKaos.Models.Vagtplan;

namespace MedarbejderVagtKaos.Service
{
	public interface IVagtService
	{
		List<Vagt> GetVagter();
		void AddVagt(Vagt vagt);
		//void UpdateVagt(Vagt vagt);
		Vagt GetVagt(int id);
		Vagt DeleteVagt(int? vagtId);
	}
}

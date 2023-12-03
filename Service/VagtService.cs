using MedarbejderVagtKaos.MockData;
using MedarbejderVagtKaos.Models.Vagtplan;

namespace MedarbejderVagtKaos.Service
{
	public class VagtService : IVagtService
	{
		private List<Vagt> _vagter;
		public VagtService()
		{
	
			_vagter = MockVagter.GetMockVagter();
			//_vagter = JsonFileVagtService.GetJsonVagter().ToList();
		}
		public void AddVagt(Vagt vagt)
		{
			_vagter.Add(vagt);
			//JsonFileVagtService.SaveJsonVagter(_vagter);
		}

		public Vagt GetVagt(int id)
		{
			foreach (Vagt vagt in _vagter)
			{
				if (vagt.Id == id)
					return vagt;
			}

			return null;
		}
		public void UpdateVagt(Vagt vagt)
		{
			if (vagt != null)
			{
				foreach (Vagt i in _vagter)
				{
					if (i.Id == i.Id)
					{
						i.MedarbejderName = vagt.MedarbejderName;
						i.StartTid = vagt.StartTid;
						i.SlutTid = vagt.SlutTid;
					}
				}
			}
		}

		public Vagt DeleteVagt(int? vagtId)
		{
			
			foreach (Vagt vagt in _vagter)
			{
				if (vagt.Id == vagtId)
				{
					_vagter.Remove(vagt);
					
				}
			}

			return null;
		}
		public List<Vagt> GetVagter() { return _vagter; }

		}
	}

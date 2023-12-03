using MedarbejderVagtKaos.Models.Vagtplan;
using System.Text.Json;

namespace MedarbejderVagtKaos.Service
{
	public class JsonFileVagtService
	{
		//public IWebHostEnvironment WebHostEnvironment { get; }

		//public JsonFileVagtService(IWebHostEnvironment webHostEnvironment)
		//{
		//	WebHostEnvironment = webHostEnvironment;
		//}

		//private string JsonFileName
		//{
		//	get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Vagter.json"); }
		//}

		//public void SaveJsonVagter(List<Vagt> vagter)
		//{
		//	using (FileStream jsonFileWriter = File.Create(JsonFileName))
		//	{
		//		Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
		//		{
		//			SkipValidation = false,
		//			Indented = true
		//		});
		//		JsonSerializer.Serialize<Vagt[]>(jsonWriter, vagter.ToArray());
		//	}
		//}

		//public IEnumerable<Vagt> GetJsonVagter()
		//{
		//	using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
		//	{
		//		return JsonSerializer.Deserialize<Vagt[]>(jsonFileReader.ReadToEnd());
		//	}
		//}
	}
}

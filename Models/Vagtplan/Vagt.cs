
using System.ComponentModel.DataAnnotations;

namespace MedarbejderVagtKaos.Models.Vagtplan
{
    public class Vagt
    {
        static int nextId = 1;
        public int Id { get; }
        public string MedarbejderName { get; set; }
        public string MedarbejderEmail { get; set; }
        public int MedarbejderTlf { get; set; }
        public string StartTid { get; set; }
        public string SlutTid { get; set; }

        public Vagt()
        {
            Id = nextId++;
        }

        public Vagt(string medarbejderName, string medarbejderEmail, int medarbejderTlf, string startTid, string slutTid)
        {
            Id = nextId++;
            MedarbejderName = medarbejderName;
            MedarbejderEmail = medarbejderEmail;
            MedarbejderTlf = medarbejderTlf;
            StartTid = startTid;
            SlutTid = slutTid;
        }
		public static IEnumerable<string> MedarbejderOptions()
		{
			return new[]
			{
			    "Hans Christian Andersen", "Joakim Von And", "Erik", "Odin", "Irene",
				"Astrid", "Anni", "Jørgen", "Ib", "Åbæk"
			};
		}


		public static IEnumerable<string> StartTidOptions()
        {
            return new[]
            {
                "08:00", "09:00", "10:00", "11:00", "12:00",
                "13:00", "14:00", "15:00", "16:00", "17:00"
            };
        }

        public static IEnumerable<string> SlutTidOptions()
        {
            return new[]
            {
                "12:00", "13:00", "14:00", "15:00", "16:00",
                "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"
            };
        }
    }
}

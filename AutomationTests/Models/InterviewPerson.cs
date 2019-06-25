using Newtonsoft.Json;

namespace HRMsQA.Models
{
	public class InterviewPerson
	{
		[JsonProperty("firstName")]
		public string FirstName { get; set; }

		[JsonProperty("middleName")]
		public string MiddleName { get; set; }

		[JsonProperty("lastName")]
		public string LastName { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("area")]
		public string Area { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("address")]
		public string Address { get; set; }

		[JsonProperty("interviewDate")]
		public string InterviewDate { get; set; }
		public static InterviewPerson FromJson(string json) => JsonConvert.DeserializeObject<InterviewPerson>(json, HRMsQA.Models.Converter.Settings);
	}

}


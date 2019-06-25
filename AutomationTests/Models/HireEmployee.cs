using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMsQA.Models
{
	public class HireEmployee
	{
		[JsonProperty("firstName")]
		public string FirstName { get; set; }

		[JsonProperty("middleName")]
		public string MiddleName { get; set; }

		[JsonProperty("lastName")]
		public string LastName { get; set; }

		[JsonProperty("age")]
		public string Age { get; set; }

		[JsonProperty("address")]
		public string Address { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("IBAN")]
		public string Iban { get; set; }

		[JsonProperty("JobID")]
		public string JobId { get; set; }

		[JsonProperty("Salary")]
		public string Salary { get; set; }

		[JsonProperty("StratingDate")]
		public string StratingDate { get; set; }

		[JsonProperty("VacationDays")]
		public string VacationDays { get; set; }
		public static HireEmployee FromJson(string json) => JsonConvert.DeserializeObject<HireEmployee>(json, HRMsQA.Models.Converter.Settings);
	}
		
	

}

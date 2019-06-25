using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMsQA.Models
{
	public static class Serialize
	{
		public static string ToJson(this InterviewPerson self) => JsonConvert.SerializeObject(self, Converter.Settings);
		public static string ToJson(this HireEmployee self) => JsonConvert.SerializeObject(self, Converter.Settings);
	}
}

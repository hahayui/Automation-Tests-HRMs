using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMsQA.Pages.HRMainPage
{
	public partial class HRMainPage
	{
		public IWebElement interviewBtn => Driver.FindElement(By.Id("interviewBtn"));
		public IWebElement hireBtn => Driver.FindElement(By.Id("hireBtn"));
		public IWebElement employeeBtn => Driver.FindElement(By.Id("employeeBtn"));
		public IWebElement salariesBtn => Driver.FindElement(By.Id("salariesBtn"));
		public IWebElement projectBtn => Driver.FindElement(By.Id("projectBtn"));
	}
}

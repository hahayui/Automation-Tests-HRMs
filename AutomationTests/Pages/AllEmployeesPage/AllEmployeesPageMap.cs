using OpenQA.Selenium;
using System.Collections.Generic;

namespace HRMsQA.Pages.AllEmployeesPage
{
	public partial class AllEmployeesPage
	{
		public IList<IWebElement> fireBtns => Driver.FindElements(By.ClassName("btn-danger"));
		public IWebElement fireBtn => Driver.FindElement(By.ClassName("btn-outline-danger"));
	}
}
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HRMsQA.Pages.AllEmployeesPage
{
	public partial class AllEmployeesPage:BasePage
	{
		public AllEmployeesPage(IWebDriver driver):base(driver){}
		public IWebElement firstFire()
		{
			return fireBtns[0];
		}
		public int fireEmployee()
		{

			firstFire().Click();
			Thread.Sleep(1000);
			Driver.SwitchTo().ActiveElement();
			fireBtn.Click();
			return fireBtns.Count;

		}
	}
}

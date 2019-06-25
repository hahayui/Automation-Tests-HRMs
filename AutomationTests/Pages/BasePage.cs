using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HRMsQA.Pages
{
	public abstract class BasePage
	{
		private readonly IWebDriver _driver;
		public BasePage(IWebDriver driver)
		{
			_driver = driver;
		}
		public IWebDriver Driver => _driver;

		public WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

		public String BaseUrl => "http://localhost:4200/hr";

		//public String BaseUrl => "http://localhost:4200/hr";
	}
}

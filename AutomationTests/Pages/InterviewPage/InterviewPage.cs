using HRMsQA.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HRMsQA.Pages.InterviewPage
{
	public partial class InterviewPage:BasePage
	{
		public InterviewPage(IWebDriver driver) : base(driver) { }
		//Picking random gender
		public IWebElement randomGender()
		{
			Random random = new Random();
			int index = random.Next(genderRadios.Count);
			return genderRadios[index];
		}

		public void fillRegistrationForm(InterviewPerson user)
		{
			firstNameInput.SendKeys(user.FirstName);
			middleNameInput.SendKeys(user.MiddleName);
			lastNameInput.SendKeys(user.LastName);
			emailInput.SendKeys(user.Email);
			randomGender().Click();
			areaInput.SendKeys(user.Area);
			cityInput.SendKeys(user.City);
			addressInput.SendKeys(user.Address);
			chooseFileBtn.SendKeys("C:\\Users\\Elian\\Desktop\\CV_EK.pdf");
			uploadFileBtn.Click();
			datePickerInput.SendKeys(user.InterviewDate);
			addBtn.Click();
			
		}
	}
}

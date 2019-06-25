using HRMsQA.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace HRMsQA.Pages.HireEmployeePage
{
	public partial class HireEmployeePage:BasePage
	{
		public HireEmployeePage(IWebDriver driver):base(driver){}
		public IWebElement randomGender()
		{
			Random random = new Random();
			int index = random.Next(genderRadios.Count);
			return genderRadios[index];
		}
		public IWebElement randomJobID()
		{
			Random random = new Random();
			int index = random.Next(jobIDRadios.Count);
			return jobIDRadios[index];
		}
		public IWebElement randomGrade()
		{
			Random random = new Random();
			int index = random.Next(gradesRadios.Count);
			return gradesRadios[index];
		}

		public void fillRegistrationForm(HireEmployee employee)
		{
			firstNameInput.SendKeys(employee.FirstName);
			middleNameInput.SendKeys(employee.MiddleName);
			lastNameInput.SendKeys(employee.LastName);
			ageInput.SendKeys(employee.Age);
			randomGender().Click();
			addressInput.SendKeys(employee.Address);
			IBANInput.SendKeys(employee.Iban);
			randomJobID().Click();
			Thread.Sleep(3000);
			email.SendKeys(employee.Email);
			salary.SendKeys(employee.Salary);
			startingDate.SendKeys(employee.StratingDate);
			vacationDays.SendKeys(employee.VacationDays);
			var selectWorkingHours = new SelectElement(workingHours);
			selectWorkingHours.SelectByText("Four hours a day");
			var selectWorkingDays = new SelectElement(workingDays);
			selectWorkingDays.SelectByText("Five days a week Five days a week");
			randomGrade().Click();
			skillsSelect.Click();
			allSkills.Click();
			submitEmployeeBtn.Click();
		}
	}

}

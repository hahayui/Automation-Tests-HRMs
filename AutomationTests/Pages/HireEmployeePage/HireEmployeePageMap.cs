using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMsQA.Pages.HireEmployeePage
{
	public partial class HireEmployeePage
	{
		public IWebElement firstNameInput => Wait.Until((d) =>
		{
			return d.FindElement(By.Name("firstName"));
		});
		public IWebElement middleNameInput => Wait.Until((d) =>
		{
			return d.FindElement(By.Name("middleName"));
		});
		public IWebElement lastNameInput => Wait.Until((d) => {
			return d.FindElement(By.Name("lastName"));
		});
		public IWebElement ageInput => Wait.Until((d) => {
			return d.FindElement(By.XPath(@"//*[@id=""ageInput""]"));
		});
		public IList<IWebElement> genderRadios => Driver.FindElements(By.ClassName("genders"));

		public IWebElement addressInput => Wait.Until((d) => {
			return d.FindElement(By.Name("address"));
		});
		public IWebElement IBANInput => Wait.Until((d) => {
			return d.FindElement(By.Name("iban"));
		});
		public IList<IWebElement> jobIDRadios => Driver.FindElements(By.ClassName("jobID"));
		public IWebElement email => Wait.Until((d) => {
			return d.FindElement(By.Name("email"));
		});
		public IWebElement salary => Wait.Until((d) => {
			return d.FindElement(By.Name("salary"));
		});
		public IWebElement startingDate => Wait.Until((d) => {
			return d.FindElement(By.Name("startingDate"));
		});
		public IWebElement vacationDays => Wait.Until((d) => {
			return d.FindElement(By.Name("vacation"));
		});
		public IWebElement workingHours => Wait.Until((d) => {
			return d.FindElement(By.Id("workingHoursSelect"));
		});
		public IWebElement workingDays => Wait.Until((d) => {
			return d.FindElement(By.Id("workingDaysSelect"));
		});
		public IWebElement skillsSelect => Wait.Until((d) => {
			return d.FindElement(By.XPath("/html/body/app-root/app-hire-employee/div/div[2]/div/form/div[7]/div[2]/div/ng-multiselect-dropdown/div/div[1]/span/span[2]/span"));
		});
		
		public IWebElement allSkills => Wait.Until((d) => {
			return d.FindElement(By.XPath("/html/body/app-root/app-hire-employee/div/div[2]/div/form/div[7]/div[2]/div/ng-multiselect-dropdown/div/div[2]/ul[1]/li[1]/div"));
		});
		

		public IList<IWebElement> gradesRadios => Driver.FindElements(By.ClassName("grades"));

		public IWebElement submitEmployeeBtn => Wait.Until((d) => {
			return d.FindElement(By.XPath("/html/body/app-root/app-hire-employee/div/div[2]/div/form/button[1]"));
		});

	}
}

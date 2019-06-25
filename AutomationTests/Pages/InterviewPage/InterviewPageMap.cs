using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMsQA.Pages.InterviewPage
{
	public partial class InterviewPage
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
		public IWebElement emailInput => Wait.Until((d) =>
		{
			return d.FindElement(By.Name("email"));
		});
		public IWebElement interviewBtn => Wait.Until((d) =>
		{
			return d.FindElement(By.Name("interviewBtn"));
		});
		public IList<IWebElement> genderRadios => Wait.Until((d) =>
		{
			return d.FindElements(By.ClassName("custom-control-label"));
		});
		public IWebElement areaInput => Wait.Until((d) =>
		{
			return d.FindElement(By.Name("area"));
		});
		public IWebElement cityInput => Wait.Until((d) =>
		{
			return d.FindElement(By.Name("city"));
		});
		public IWebElement addressInput => Wait.Until((d) =>
		{
			return d.FindElement(By.Name("address"));
		});
		public IWebElement chooseFileBtn => Wait.Until((d) =>
		{
			return d.FindElement(By.XPath("/html/body/app-root/app-interview-person/div/div[2]/div/form/div[5]/div[1]/div/form-upload/label/input"));
		});
		public IWebElement uploadFileBtn => Wait.Until((d) =>
		{
			return d.FindElement(By.XPath("/html/body/app-root/app-interview-person/div/div[2]/div/form/div[5]/div[1]/div/form-upload/button"));
		});
		public IWebElement datePickerBtn => Wait.Until((d) =>
		{
			return d.FindElement(By.XPath("/html/body/app-root/app-interview-person/div/div[2]/div/form/div[5]/div[2]/div/span"));
		});
		public IWebElement datePickerInput => Wait.Until((d) =>
		{
			return d.FindElement(By.Name("interviewDate"));
		});

		//public IWebElement setDateBtn => Driver.FindElement(By.XPath("//*[@id=""owl-dt-picker-0""]/div[2]/div/button[2]"));
		public IWebElement addBtn => Wait.Until((d) =>
		{
			return d.FindElement(By.XPath("/html/body/app-root/app-interview-person/div/div[2]/div/form/button[1]"));
		});
		public IWebElement invalidInput => Wait.Until((d) =>
		{
			return d.FindElement(By.ClassName("invalid-feedback"));
		});

		
	}
}

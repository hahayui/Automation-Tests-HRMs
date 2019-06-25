using FluentAssertions;
using HRMsQA.Models;
using HRMsQA.Pages.AllEmployeesPage;
using HRMsQA.Pages.HireEmployeePage;
using HRMsQA.Pages.HRMainPage;
using HRMsQA.Pages.InterviewPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace AutomationTests
{
	[TestFixture]
	[Author("Elian Dimov Kurtev, eliankurtev@gmail.com")]
	public class Tests
	{
		private IWebDriver driver;
		private WebDriverWait wait;
		private HRMainPage HRMainPage;
		private InterviewPage interviewPage;
		private HireEmployeePage hireEmployeePage;
		private AllEmployeesPage allEmployeesPage;

		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
			wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			driver.Manage().Window.Maximize();
			HRMainPage = new HRMainPage(driver);
			interviewPage = new InterviewPage(driver);
			hireEmployeePage = new HireEmployeePage(driver);
			allEmployeesPage = new AllEmployeesPage(driver);
			driver.Navigate().GoToUrl("http://localhost:4200/hr");
		}
		[TearDown]
		public void CleanUp()
		{
			driver.Quit();
		}

		[Order(0)]
		[Test]
		public void OpenInterviewPage()
		{
			HRMainPage.interviewBtn.Click();
			string tabTitle = driver.Title;
			tabTitle.Should().Be("Interview Person");

		}
		[Order(1)]
		[Test]
		public void OpenHirePage()
		{
			HRMainPage.hireBtn.Click();
			string tabTitle = driver.Title;
			tabTitle.Should().Be("Hire Employee");
		}
		[Order(2)]
		[Test]
		public void OpenAllEmployeesPage()
		{
			HRMainPage.employeeBtn.Click();
			string tabTitle = driver.Title;
			tabTitle.Should().Be("All Employees");
		}
		[Order(3)]
		[Test]
		public void OpenSalariesPage()
		{
			HRMainPage.salariesBtn.Click();
			string tabTitle = driver.Title;
			tabTitle.Should().Be("Salaries");
		}
		[Order(4)]
		[Test]
		public void OpenProjectPage()
		{
			HRMainPage.projectBtn.Click();
			string tabTitle = driver.Title;
			tabTitle.Should().Be("Project");
		}
		[Order(5)]
		[Test]
		public void CreateInterviewWithValidInputs()
		{
			HRMainPage.interviewBtn.Click();
			var path = Path.GetFullPath(Directory.GetCurrentDirectory()
				+ "/../../../Jsons/InterviewPerson/InterviewPersonValidInputs.json");
			var interviewPerson = InterviewPerson.FromJson(File.ReadAllText(path));
			interviewPage.fillRegistrationForm(interviewPerson);
			Thread.Sleep(2000);
			string tabTitle = driver.Title;
			Thread.Sleep(3000);
			tabTitle.Should().Be("Human Resources");
		}
		[Order(6)]
		[Test]
		public void CreateInterviewWithInvalidData()
		{
			HRMainPage.interviewBtn.Click();
			var path = Path.GetFullPath(Directory.GetCurrentDirectory()
				+ "/../../../Jsons/InterviewPerson/InterviewPersonInvalidInput.json");
			var interviewPerson = InterviewPerson.FromJson(File.ReadAllText(path));
			interviewPage.fillRegistrationForm(interviewPerson);
			bool isItDisplayed = interviewPage.invalidInput.Displayed;
			isItDisplayed.Should().BeTrue();
			Thread.Sleep(3000);
		}
		[Order(7)]
		[Test]
		public void HirePersonWithValidData()
		{
			HRMainPage.hireBtn.Click();
			var path = Path.GetFullPath(Directory.GetCurrentDirectory()
				+ "/../../../Jsons/HirePerson/HirePersonValidInputs.json");
			var hirePerson = HireEmployee.FromJson(File.ReadAllText(path));
			hireEmployeePage.fillRegistrationForm(hirePerson);
			Thread.Sleep(2000);
			string tabTitle = driver.Title;
			Thread.Sleep(3000);
			tabTitle.Should().Be("Human Resources");
		}
		[Order(8)]
		[Test]
		public void HirePersonWithInvalidData()
		{
			HRMainPage.hireBtn.Click();
			var path = Path.GetFullPath(Directory.GetCurrentDirectory()
				+ "/../../../Jsons/HirePerson/HirePersonInvalidInput.json");
			var hirePerson = HireEmployee.FromJson(File.ReadAllText(path));
			hireEmployeePage.fillRegistrationForm(hirePerson);
			Thread.Sleep(2000);
			string tabTitle = driver.Title;
			Thread.Sleep(3000);
			tabTitle.Should().Be("Hire Employee");
		}
		/*[Order(9)]
		[Test]
		public void FireEmployee()
		{
			HRMainPage.employeeBtn.Click();
			int currentEmployees = allEmployeesPage.fireBtns.Count;
			allEmployeesPage.fireEmployee();
			currentEmployees.Should().BeGreaterThan(allEmployeesPage.fireBtns.Count);
		}*/
	}
}

	

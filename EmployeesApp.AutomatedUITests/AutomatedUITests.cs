using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace EmployeesApp.AutomatedUITests
{
  /* public class AutomatedUITests : IDisposable
    {
        private readonly IWebDriver _driver;
        public AutomatedUITests() => _driver = new ChromeDriver();
       
        public void Dispose() 
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void Create_WhenExecuted_ReturnsCreateView()
        {
            _driver.Navigate()
                .GoToUrl("https://localhost:5001/Employees/Create");

            Assert.Equal("Create - EmployeesApp", _driver.Title);
            Assert.Contains("Please provide a new employee data", _driver.PageSource);
        }
    }*/
   
}

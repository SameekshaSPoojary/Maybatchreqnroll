using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ReqnrollProject.Pages
{
    internal class registrationpage
    {
        private readonly IWebDriver _driver;


        public registrationpage(IWebDriver driver)
        {
            _driver = driver;
        }


        // locators on the login page


        By firstnameField = By.XPath("//input[@id='name']");
        By email = By.XPath("//input[@id='email']");
        By gender = By.XPath("//input[@id='gender']");
        By mobilenumber = By.XPath("//input[@id='mobile']");
        By dateofbirth = By.XPath("//input[@id='dob']");
        By subjects = By.XPath("//input[@id='subjects']");
        By hobbies_music = By.XPath("(//input[@type='checkbox'])[3]");

        By hobbies_read = By.XPath("(//input[@type='checkbox'])[1]");
        By browsepicture = By.XPath("//input[@id='picture']");

        By currentaddress = By.XPath("//textarea[@id='picture']");
        By state = By.XPath("//select[@id='state']");
        By city = By.XPath("//select[@id='city']");
        By loginbutton = By.XPath("//input[@value='Login']");


        // laucnh browser

        public void launchbrowser()
        {

            _driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/selenium_automation_practice.php");
        }


        public void EnterFirstname(string firstname_e)
        {
            _driver.FindElement(firstnameField).SendKeys(firstname_e);
            Thread.Sleep(2000);


        }

        public void EnterEmail(string email_e)
        {
            _driver.FindElement(email).SendKeys(email_e);
            Thread.Sleep(2000);
        }
        public void SelectGender(string gender_e)
        {
            if (gender_e == "Male")
                _driver.FindElement(gender).Click();
            Thread.Sleep(2000);
        }
        public void EnterMobile(string mobilenumber_e)
        {
            _driver.FindElement(mobilenumber).SendKeys(mobilenumber_e);
            Thread.Sleep(2000);
        }

        public void EnterDateOfBirth(string ddMMyyyy)
        {
            var dateInput = _driver.FindElement(dateofbirth);
            dateInput.Clear();
            dateInput.SendKeys(ddMMyyyy);
            Thread.Sleep(2000);
        }
        public void EnterSubjects(string subjects_e)
        {
            _driver.FindElement(subjects).SendKeys(subjects_e);
            Thread.Sleep(2000);
        }

        public void SelectHobbies(string hobbies)
        {
            if (hobbies.Contains("Reading"))
            {
                _driver.FindElement(hobbies_read).Click();
            }
            if (hobbies.Contains("Music"))
            {
                _driver.FindElement(hobbies_music).Click();
            }
            Thread.Sleep(2000);
        }

        public void UploadPicture(string path)
        {
            _driver.FindElement(browsepicture).SendKeys(path);
            Thread.Sleep(2000);
        }

        public void EnterAddress(string address)
        {
            _driver.FindElement(currentaddress).SendKeys(address);
            Thread.Sleep(2000);
        }


        public void SelectState(string state_e)
        {
            //var dropdown = new SelectElement(_driver.FindElement(state));
            //dropdown.SelectByText(state_e);
            //Thread.Sleep(2000);
        }
        public void SelectCity(string city_e)
        {
            //var dropdown = new SelectElement(_driver.FindElement(city));
            //dropdown.SelectByText(city_e);
            //Thread.Sleep(2000);
        }





        // submit method

        public void submit()
        {
            _driver.FindElement(loginbutton).Click();

        }
    }
}

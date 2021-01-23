using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LoginPage : DriverHelper
    {

        IWebElement txtUserName => Driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Id("Password"));
        IWebElement BtnLogin => Driver.FindElement(By.XPath("//input[@type='submit']"));
        public void ClickLoginBtn() => BtnLogin.Click();
        public void EnterUserName(string username) => txtUserName.SendKeys(username);
        public void EnterPassword(string password) => txtPassword.SendKeys(password);
    }
}

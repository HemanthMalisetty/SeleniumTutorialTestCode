﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTutorialTestCode.PageOBJ
{
    public class LyricTesting2LoginPage
    {

        IWebDriver webDriver;

        public IWebElement txtBoxUSR => webDriver.FindElement(By.Id("login_username"));

        public IWebElement txtBoxPWD => webDriver.FindElement(By.Id("login_password"));

        //public IWebElement btnLogin  => webDriver.FindElement(By.ClassName("btn btn-primary btn-lg btn-block js-btn-login"));
        public IWebElement btnLogin => webDriver.FindElement(By.XPath(@"/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button"));
       

        //    public IWebElement btnLogin => webDriver.FindElement(By.XPath(@"/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button"));
        //*[@id="login-form"]/div[4]/button

        public LyricTesting2LoginPage(IWebDriver driver)
        {
            webDriver = driver;
        }
        /// <summary>
        /// input the username
        /// </summary>
        public void usernameEnter(string username)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("login_username")));
            txtBoxUSR.SendKeys(username);
        }


        /// <summary>
        /// input the password
        /// </summary>
        public void passwordEnter(string password)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            txtBoxPWD.SendKeys(password);
            txtBoxPWD.Click();
        }


        /// <summary>
        /// click "登陆"
        /// </summary>
        public void btnLoginClick()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(@"/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button")));
            btnLogin.Click();
        }

        public void Login(string username,string password)
        {
            usernameEnter(username);
            passwordEnter(password);
            btnLoginClick();

        }
    }
}
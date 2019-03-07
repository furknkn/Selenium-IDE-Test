using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace uncleSoftwareTest
{
    [TestClass]
    public class Test
    {
        IWebDriver driver = new ChromeDriver();
        
        [TestMethod]
        public void kurumsalHesapKaybolma()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/");

            // TODO: Add your test code here
            driver.FindElement(By.XPath("/ html / body / div[1] / div / div[1] / ul / li[1] / a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("name")).SendKeys("Emre Böcek");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("mail")).SendKeys("bocekemre358@gmail.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password")).SendKeys("Emrebocek57");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/form/div[2]/div[4]/label[2]/span[1]")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("nick")).SendKeys("emre57");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("phoneUser")).SendKeys("05384088515");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("companyName")).SendKeys("Bocek Yazılım");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("phoneCompany")).SendKeys("05384088515");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("companyDate")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("companyDate")).SendKeys("2018-12-18");
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.Name("companyMail")).SendKeys("emrebocek21@gmail.com");
            System.Threading.Thread.Sleep(3000);
            
            driver.FindElement(By.Name("companyWeb")).SendKeys("www.emrebocek.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("companyAbout")).SendKeys("Çok güzel bir firmadır.Her şey vardır.");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[2]/a")).Click();
            System.Threading.Thread.Sleep(3000);
          
        }
        [TestMethod]
        public void paylasimYapma()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("emailorname")).SendKeys("Emre578");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password")).SendKeys("Emrebocek57");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/ul/li[6]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[6]/ul/li[1]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div[3]/div/div/form/div/div/textarea")).SendKeys("Merhaba");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div[3]/div/div/form/div[2]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            
        }
        [TestMethod]
        public void profiliDüzenleme()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("emailorname")).SendKeys("Emre578");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password")).SendKeys("Emrebocek57");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click();
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/ul/li[6]/a")).Click();
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[6]/ul/li[1]/a")).Click();
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div[1]/div/div/div[1]/div[3]/a/button")).Click();
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.Name("user_title")).SendKeys("Grafik Tasarımcısı");
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[2]/table/tbody/tr[6]/td[2]/button")).Click();
            System.Threading.Thread.Sleep(10000);
           
        }
    }
}

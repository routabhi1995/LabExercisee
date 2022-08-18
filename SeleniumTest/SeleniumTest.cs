using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace LabExercise
{
     [TestClass]
     public class SeleniumTest
    {
        

        [DataTestMethod]
        
        [DataRow("FF","abhishek@google.com","Abhishek","Cigniti")]
        [DataRow("CH","ashok@google.com","ashok","Cigniti")]
        [DataRow("EDGE","kalyani@google.com","kalyani","Cigniti")]
        public void LaunchBrowser(string op1, string op2, string op3 ,string op4)
        {
            IWebDriver driver;
            if(op1=="FF")
            {
             driver = new FirefoxDriver(@"C:\Root Folder\Web Driver");

            }
            else if (op1=="CH")
            {
            driver = new ChromeDriver(@"C:\Root Folder\Web Driver");
            }    
            else
            {
            driver = new EdgeDriver(@"C:\Root Folder\Web Driver");
            }
            
            driver.Navigate().GoToUrl("https://www.demoblaze.com");
            IWebElement Contact = driver.FindElement(By.LinkText("Contact"));
            Contact.Click();
            Thread.Sleep(3000);

            IWebElement ContactEmail = driver.FindElement(By.Id("recipient-email"));
            ContactEmail.SendKeys(op2);
            Thread.Sleep(3000);

            IWebElement ContactName = driver.FindElement(By.Id("recipient-name"));
            ContactName.SendKeys(op3);
            Thread.Sleep(2000);

            IWebElement Message = driver.FindElement(By.Id("message-text"));
            Message.SendKeys(op4);
            Thread.Sleep(2000);

            IWebElement Close = driver.FindElement(By.XPath("//button[text()='Send message']//preceding-sibling::button[text()='Close']"));
            Close.Click();
            Thread.Sleep(3000);
            driver.Quit();


            

            
        
        }        
    
         

    }
        
        
}



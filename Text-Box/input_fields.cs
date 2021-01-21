
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


class input_fields
{

    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        string url = "https://testing.todorvachev.com/special-elements/text-input-field/";
        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Name("username"));

        element.SendKeys("test text");

        Thread.Sleep(3000);

        System.Console.WriteLine(element.GetAttribute("value"));

        Thread.Sleep(3000);
        driver.Quit();
    }
}

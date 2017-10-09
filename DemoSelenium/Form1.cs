using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace DemoSelenium
{
    public partial class Form1 : Form
    {
        private IWebDriver _browser;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _browser = new ChromeDriver();
            _browser.Manage().Window.Maximize();
            _browser.Navigate().GoToUrl("http://google.com");
            IWebElement searchInput = _browser.FindElement(By.Id("lst-ib"));
            searchInput.SendKeys("как вырастить гомункула" + OpenQA.Selenium.Keys.Enter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _browser.Quit();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace AI_Chat__C_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void bingProcess()
        {
            



        }



        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string inputText = txtAskFor.Text;
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-site-isolation-trials");
            options.AddArgument("--disable-features=NetworkService,NetworkServiceInProcess");
            options.AddArgument("--allow-cross-origin-auth-prompt");
            options.AddArgument("--allow-reading-third-party-cookies");
            options.AddArgument("--allow-third-party-cookies");


            try {

                         var driver = new ChromeDriver(options);

                try
                {

                    // Navigate to website and login
                    driver.Url = "https://www.koala.sh";
                    IWait<IWebDriver> loading = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                    var loginbtn = driver.FindElement(By.XPath("//body/div[@id='__next']/div[1]/div[1]/div[1]/a[5]"));
                    loginbtn.Click();
                    IWait<IWebDriver> wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                    var mail = driver.FindElement(By.CssSelector("#email"));
                    mail.SendKeys("lerid25798@aaorsi.com"); //test  temp mail 
                    var password = driver.FindElement(By.CssSelector("#password"));
                    password.SendKeys("roadstar2000"); //test temp password 
                    var loginbtnforum = driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
                    loginbtnforum.Submit();
                    IEnumerable<OpenQA.Selenium.Cookie> cookies = driver.Manage().Cookies.AllCookies;
                    SaveCookiesToFile(cookies, "cookies.txt");
                    // Later, restore the session using the saved cookies

                    //  IWait<IWebDriver> wtime = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                    ChromeDriver driver1 = RestoreSessionFromCookiesFile("cookies.txt");
                    driver1.Quit();
                    var txtarea = driver.FindElement(By.TagName("textarea"));
                    txtarea.SendKeys(inputText);
                    txtarea.SendKeys(Keys.Enter);
                    Thread.Sleep(15000);

                    var txtchat = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/main[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/p[1]"));
                    String chats = txtchat.Text;
                    string text = txtchat.GetAttribute("innerText");
                    rTxtResult.Text = text+"\n";

                    driver.Quit();

                }


                catch (NoSuchElementException)
                {

                    IWebDriver driver2 = new ChromeDriver(options);
                    driver2.Url = "https://shuffle.dev/chat";
                    var inputTxt = driver2.FindElement(By.CssSelector("#chat-message-input"));
                    inputTxt.Click();
                    inputTxt.SendKeys(inputText);
                    inputTxt.SendKeys(Keys.Enter);
                    Thread.Sleep(20000);
                    var textchat = driver2.FindElement(By.XPath("/html/body/section/div[2]/div[2]/div[2]/div[5]/div/div[1]/div/div[2]/div/div/div/p"));
                    String chats = textchat.Text;
                    string text = textchat.GetAttribute("innerText");
                    rTxtResult.Text = text;

          
                  
                     driver2.Quit();


                }



            }



            catch (NoSuchElementException)
            {
                IWebDriver driver2 = new ChromeDriver(options);
                driver2.Quit();

                // Create a new instance of ChromeDriver
                IWebDriver driver3 = new ChromeDriver(options);

                // Navigate to www.you.com
                driver3.Navigate().GoToUrl("https://www.you.com");
                Thread.Sleep(5000);
                var textbox = driver3.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[3]/section[1]/main[1]/div[3]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/textarea[1]"));
                textbox.Click();
                var textsend = driver3.FindElement(By.TagName("textarea"));
                textsend.SendKeys(inputText);
                textsend.SendKeys(Keys.Enter);
                Thread.Sleep(10000);
                var chats = driver3.FindElements(By.XPath("//p[@class='sc-98942fc5-0 JcSiB']"));

                // Iterate through the elements and get their full text
                foreach (var chat in chats)
                {
                    string text = chat.GetAttribute("innerText");
                    rTxtResult.Text = text + "\n";
                }
                // Close the browser
                driver3.Quit();
            }
                

            }
           
        private void txtAskFor_TextChanged(object sender, EventArgs e)
        {

        }

        private void rTxtResult_TextChanged(object sender, EventArgs e)
        {

        }
        static ChromeDriver RestoreSessionFromCookiesFile(string filePath)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            ChromeDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.koala.sh/");

            // Load cookies from file
            IEnumerable<OpenQA.Selenium.Cookie> cookies = LoadCookiesFromFile(filePath);

            // Add cookies to the current session
            foreach (OpenQA.Selenium.Cookie cookie in cookies)
            {
                driver.Manage().Cookies.AddCookie(cookie);
            }

            // Refresh the page to apply the cookies
            driver.Navigate().Refresh();

            return driver;
        }

        static bool SaveCookiesToFile(IEnumerable<OpenQA.Selenium.Cookie> cookies, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (OpenQA.Selenium.Cookie cookie in cookies)
                    {
                        writer.WriteLine($"{cookie.Name}|{cookie.Value}|{cookie.Domain}|{cookie.Path}|{cookie.Expiry}");
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving cookies to file: {ex.Message}");
                return false;
            }
        }

        static IEnumerable<OpenQA.Selenium.Cookie> LoadCookiesFromFile(string filePath)
        {
            List<OpenQA.Selenium.Cookie> cookies = new List<OpenQA.Selenium.Cookie>();

            using (System.IO.StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    OpenQA.Selenium.Cookie cookie = new OpenQA.Selenium.Cookie(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]));
                    cookies.Add(cookie);
                }
            }

            return cookies;
        }




    }
}

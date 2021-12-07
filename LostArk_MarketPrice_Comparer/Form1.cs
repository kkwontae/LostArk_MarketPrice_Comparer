using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MetroSet_UI;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Remote;
using System.Net.NetworkInformation;
using System.Net;

namespace LostArk_MarketPrice_Comparer
{
    public partial class MainForm : MetroSetForm
    {
        //protected ChromeDriverService _driverService = null;
        //protected ChromeOptions _options = null;
        //protected ChromeDriver _driver = null;

        protected ChromeDriverService _driverService = null;
        protected ChromeOptions _options = null;
        protected RemoteWebDriver _driver = null;


        public MainForm()
        {
            InitializeComponent();
            InitializeStrings();
            InitializeChart();
            metroSetControlBox1.Location = new Point(this.Size.Width-metroSetControlBox1.Size.Width, 0);
        }

        private void InitializeStrings()
        {
            //textBox_price.Text = "https://lostark.game.onstove.com/Market/GetMarketItemStats?itemNo=101061&belongCode=0&tradeCompleteCount=0&bundleCount=1&_=1630855986297";

            //textBox_bundleCount.Text = "";
        }
        private void InitializeChart()
        {
            chart1.Series[0].Points.Clear();

            System.Windows.Forms.DataVisualization.Charting.Axis axis = new Axis();
            axis.LineColor = Color.Gray;
            return;
        }

        // chrome 실행
        private void InitializeChrome()
        {
            metroSetButton_Login.Text = "크롬 실행 중";
            ProcessStartInfo psi = new ProcessStartInfo();

            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            psi.Arguments = @"--remote-debugging-port=9222 --user-data-dir=C:\selenum\AutomationProfile --headless";

            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            metroSetButton_Login.Text = "크롬 실행 완료";
        }

        // driver 연결
        private void SetSeleniumDriver()
        {
            try
            {
                metroSetButton_Login.Text = "크롬 연결 중";
                _driverService = ChromeDriverService.CreateDefaultService();
                _driverService.HideCommandPromptWindow = true;

                _options = new ChromeOptions();
                _options.AddArgument("disable-gpu");
                _options.DebuggerAddress = "127.0.0.1:9222";

                _driver = new ChromeDriver(_driverService, _options);
                metroSetButton_Login.Text = "크롬 연결 완료";
            }
            catch (Exception exc)
            {
                //Trace.WriteLine(exc.Message);
            }
        }

        private void InitializeSelenium()
        {
            if(findProcess() == -1)
            {
                SetSeleniumDriver();
            }
            else if (findProcess() == -2)
            {
                InitializeChrome();
                SetSeleniumDriver();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_driver != null)
                _driver.Quit();

            if(metroSetCheckBox_KillChrome.Checked)
                chromeForceClose(false);

            Process[] con = Process.GetProcessesByName("chromedriver");
            foreach (var item in con)
                item.Kill();
        }

        private void chromeForceClose(bool question)
        {
            if(!question)
            {
                Process[] con = Process.GetProcessesByName("chrome");
                foreach (var item in con)
                    item.Kill();
            }
            else
            {
                if (MetroSetMessageBox.Show(this, "Are you sure you want to FORCEFULLY exit chrome?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process[] con = Process.GetProcessesByName("chrome");
                    foreach (var item in con)
                        item.Kill();
                }
            }
            
        }

        /// <summary>
        /// 9222 포트가 Listening or Established 인지 검사
        /// </summary>
        /// <returns>
        /// 1 : Established - driver까지 연결된 상태 -> 정상 연결중
        /// -1 : Listening - chrome(remote=922, headless)이 실행중 -> driver 연결 필요
        /// -2 : error -> chrome 실행, driver 연결 필요.
        /// </returns>
        private int findProcess()
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();


            TcpConnectionInformation[] tcpConnInfoArray = ipProperties.GetActiveTcpConnections();
            foreach (TcpConnectionInformation tcpConnInfo in tcpConnInfoArray)
            {
                if (tcpConnInfo.LocalEndPoint.Port == 9222 || tcpConnInfo.RemoteEndPoint.Port == 9222)
                {
                    if (tcpConnInfo.State.ToString() == "Established") 
                    {
                        // 정상 연결
                        return 1;
                    }
                }
            }
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();
            foreach (IPEndPoint endPoint in ipEndPoints)
            {
                if (endPoint.Port == 9222)
                {
                    // driver 연결필요
                    return -1;
                }

            }
            // chrome 실행, driver 연결 필요
            return -2; 

        }
        private void OTPLogin()
        {
            try
            {
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                var tag_otp = _driver.FindElementByXPath("//*[@id='otp']");
                tag_otp.Clear();
                tag_otp.SendKeys(metroSetTextBox_OTP.Text);
                var OKbutton = _driver.FindElementByXPath("/html/body/div[1]/section[1]/div/div/section/article[2]/nav/a");
                OKbutton.Click();
            }
            catch(Exception e)
            {
                //Trace.WriteLine(e);
            }
        }

        private void GoogleLogin()
        {
            try
            {
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                var LoginButton = _driver.FindElementByXPath("//*[@id='google_login']/i");
                LoginButton.Click();
            }
            catch(Exception e)
            {
                //Trace.WriteLine(e);
            }
        }



        private void metroSetButton_Search_Click(object sender, EventArgs e)
        {
            InitializeSelenium();
            DataBase _db = LoadJson();
            if (_db == null)
            {
                MetroSetMessageBox.Show(this, "No result!");
                return;
            }
            try
            {
                _driver.Navigate().GoToUrl("https://lostark.game.onstove.com/Market/GetMarketItemStats?itemNo=" + _db.ITEM_CODE);
                
                //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                var itemName = _driver.FindElement(By.XPath("//*[@id='modal-deal-price']/div/div/div/div[1]"));
                var itemPrice = _driver.FindElement(By.XPath("//*[@id='modal-deal-price']/div/div/div/div[2]/table/tbody/tr/td[1]/div"));

                double price = Double.Parse(
                    itemPrice.Text == "-"
                    ? "0"
                    : itemPrice.Text);

                metroSetTextBox_ItemName.Text = itemName.Text;
                metroSetTextBox_Price.Text = price.ToString();

                metroSetTextBox_PricePerEach.Text = (price / (Double.Parse(_db.BUNDLE_COUNT))).ToString();
                var imgsrc = _driver.FindElement(By.XPath("//*[@id='modal-deal-price']/div/div/div/div[1]/span[1]/img"));
                pictureBox1.ImageLocation = imgsrc.GetAttribute("src");

                chart1.Series[0].Points.Clear();

                string[,] chartPointXY =
                {
                    { _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[7]/td[1]/div")).Text,
                    _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[7]/td[2]/div/em")).Text },

                    { _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[6]/td[1]/div")).Text,
                    _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[6]/td[2]/div/em")).Text },

                    { _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[5]/td[1]/div")).Text,
                    _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[5]/td[2]/div/em")).Text },

                    { _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[4]/td[1]/div")).Text,
                    _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[4]/td[2]/div/em")).Text },

                    { _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[3]/td[1]/div")).Text,
                    _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[3]/td[2]/div/em")).Text },

                    { _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[2]/td[1]/div")).Text,
                    _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[2]/td[2]/div/em")).Text },

                    { _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[1]/td[1]/div")).Text,
                    _driver.FindElement(By.XPath("//*[@id='weekInfo']/tr[1]/td[2]/div/em")).Text },

                    { DateTime.Now.ToString("yyyy-MM-dd"),
                        price.ToString()
                    }
                };
                double min = 1000;
                double max = 0;
                for (int i=0; i<chartPointXY.Length/2;  i++)
                {
                    chart1.Series[0].Points.AddXY(
                        i < 7
                        ? DateTime.ParseExact(chartPointXY[i, 0],"yyyy-MM-dd", null).ToString("dd\n(ddd)")
                        : "오늘",
                        Double.Parse(chartPointXY[i, 1]));
                    min = Math.Min(Double.Parse(chartPointXY[i, 1]), min);
                    max = Math.Max(double.Parse(chartPointXY[i, 1]), max);
                }

                double k = (max - min) / 4;

                double minimum;
                double maximum;
                // minimum
                for (int i = 0; ; i++)
                {
                    minimum = i * k;
                    if (minimum > min)
                    {
                        Console.WriteLine(i.ToString());
                        break;
                    }

                }
                minimum -= k;
                maximum = minimum + 5 * k;

                chart1.ChartAreas[0].AxisY.Minimum = Math.Truncate(minimum);
                chart1.ChartAreas[0].AxisY.Maximum = maximum;

                //chart1.ChartAreas[0].AxisY.Minimum = (3 * min - max) / 2; // min - (avg - min)
                //chart1.ChartAreas[0].AxisY.Maximum = (3 * max - min) / 2; // max - (avg - max);

                string listItemName = itemName.Text + "(" + itemPrice.Text + ")";
                if(!metroSetListBox_Bookmark.Items.Cast<string>().Contains(listItemName))
                {
                    if (metroSetListBox_Bookmark.Items.Count > 5)
                        metroSetListBox_Bookmark.Items.RemoveAt(0);
                    metroSetListBox_Bookmark.AddItem(listItemName);

                }
            }
            catch (Exception exc)
            {
                MetroSetMessageBox.Show(this, exc.Message);
                Trace.WriteLine(exc.Message);
            }
        }
        public double IntRound(double Value, int Digit)
        {
            double Temp = Math.Pow(10.0, Digit);
            return Math.Round(Value * Temp) / Temp;
        }

        private void InputJson(string path)
        {
            var items = new[] { "101061", "101062", "101063" };

            JObject itemSpec = new JObject(
                new JProperty("ITEM_NAME", "회복약"),
                new JProperty("BUNDLE_COUNT", 1)
                );

            itemSpec.Add("ITEMS", JArray.FromObject(items));

            File.WriteAllText(path, itemSpec.ToString());
        }

        private DataBase LoadJson()
        {
            string jsonPath = @".\itemcode.json";


            if(!File.Exists(jsonPath))
            {
                File.Create(jsonPath);
            }
            else
            {
                try
                {
                    StreamReader file = File.OpenText(jsonPath);
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject json = (JObject)JToken.ReadFrom(reader);

                        DataBase _db = new DataBase();
                        string itemName = textBox1.Text.Replace(" ","");
                        _db.ITEM_CODE = (string)json[itemName]["ITEM_CODE"].ToString();
                        _db.BUNDLE_COUNT = (string)json[itemName]["BUNDLE_COUNT"].ToString();

                        metroSetTextBox_No.Text = _db.ITEM_CODE;
                        metroSetTextBox_ItemName.Text = itemName;
                        metroSetTextBox_BundleCount.Text = _db.BUNDLE_COUNT;

                        return _db;
                    }
                }
                catch (Exception e)
                {
                    //MetroSetMessageBox.Show(this, "No result!");
                }
            }
            return null;
        }

        public class DataBase
        {
            public string ITEM_CODE = string.Empty;
            public string BUNDLE_COUNT = string.Empty;
        }

        private void metroSetCheckBox_OTP_CheckedChanged(object sender)
        {
            if (metroSetCheckBox_OTP.Checked)
                metroSetTextBox_OTP.Enabled = true;
            else
                metroSetTextBox_OTP.Enabled = false;
        }

        private void metroSetButton_Login_Click(object sender, EventArgs e)
        {
            InitializeSelenium();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            _driver.Navigate().GoToUrl("https://lostark.game.onstove.com/Market/");

            if (metroSetCheckBox_Google.Checked)
            {
                GoogleLogin();
            }
            if (metroSetCheckBox_OTP.Checked)
            {
                OTPLogin();
            }
        }

        private void metroSetButton_KillChrome_Click(object sender, EventArgs e)
        {
            chromeForceClose(true);
        }

        private void metroSetTextBox_SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            MetroSetMessageBox.Show(this, e.KeyCode.ToString());
            if(e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                metroSetButton_Search_Click(sender, e);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                metroSetButton_Search_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(Environment.NewLine, "");
        }

        private void metroSetListBox_Bookmark_Click(object sender, EventArgs e)
        {
        }

        private void metroSetListBox_Bookmark_SelectedIndexChanged(object sender)
        {
            textBox1.Text = metroSetListBox_Bookmark.SelectedItem.ToString().Split('(')[0];
            metroSetButton_Search_Click(sender, null);
        }
    }
}

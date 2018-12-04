using RevenueMonsterOpenAPI;
using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Authorization authorization = new Authorization();
        Payment payment = new Payment();

        private async void button1_Click(object sender, EventArgs e)
        {
            var clientId = Properties.Settings.Default["clientId"].ToString();
            var clientSecret = Properties.Settings.Default["clientSecret"].ToString();
            var result = await authorization.GetClientCredentials(clientId, clientSecret, "sandbox");
            Properties.Settings.Default["accessToken"] = result.accessToken;
            Properties.Settings.Default["refreshToken"] = result.refreshToken;
            Properties.Settings.Default.Save();
            MessageBox.Show(result.ToString());
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var clientId = Properties.Settings.Default["clientId"].ToString();
            var clientSecret = Properties.Settings.Default["clientSecret"].ToString();
            var refreshToken = Properties.Settings.Default["refreshToken"].ToString();
            var result = await authorization.RefreshToken(clientId, clientSecret, refreshToken, "sandbox");
            Properties.Settings.Default["accessToken"] = result.accessToken;
            Properties.Settings.Default.Save();
            MessageBox.Show(result.ToString());
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var data = new
            {
                authCode = tbAuthCode.Text,
                order = new { amount = Convert.ToInt32(Convert.ToDouble(tbAmount.Text)*100), currencyType = "MYR", id = tbOrderID.Text, title = "title", detail = "desc", additionalData = "API Test" },
                ipAddress = "127.0.0.1",
                storeId = tbStoreID.Text,
            };
            var accessToken = Properties.Settings.Default["accessToken"].ToString();
            string privateKey;
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\\privateKey.txt";
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                privateKey = streamReader.ReadToEnd();
            }
            var result = await payment.QuickPay(data, accessToken, privateKey, "sandbox");
            MessageBox.Show(result.ToString());
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var data = new
            {
                transactionId = tbTransactionID.Text,
                refund = new { type = "FULL", currencyType = "MYR", amount = Convert.ToInt32(Convert.ToDouble(tbRefundAmount.Text) * 100) },
                reason = tbReason.Text,
            };
            var accessToken = Properties.Settings.Default["accessToken"].ToString();
            string privateKey;
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\\privateKey.txt";
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                privateKey = streamReader.ReadToEnd();
            }
            var result = await payment.Refund(data, accessToken, privateKey, "sandbox");
            MessageBox.Show(result.ToString());
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var data = new
            {
                orderId = tbReverseOrderID,Text,
            };
            var accessToken = Properties.Settings.Default["accessToken"].ToString();
            string privateKey;
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\\privateKey.txt";
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                privateKey = streamReader.ReadToEnd();
            }
            var result = await payment.Reverse(data, accessToken, privateKey, "sandbox");
            MessageBox.Show(result.ToString());
        }
    }
}

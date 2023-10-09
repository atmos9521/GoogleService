using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetGoogleExcel
{
    public partial class get_google_excel_form : Form
    {
        public get_google_excel_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void get_google_excel_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void read_google_excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string file_path = "./google_excel.json";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    file_path = openFileDialog.FileName;
            //}
            //else
            //{
            //    return;
            //}

            // 替換為Json憑證文件路徑
            //string credentialFilePath = "path/to/your/credentials.json";
            string google_excel_url = "https://docs.google.com/spreadsheets/d/1yejADfPXru_r9qJzGSQvrr7t9lrlouGdmGvk-vaYnYo/edit#gid=0";
            string spreadsheetId = "";

            // 匹配 URL 中的 spreadsheetId 部分
            Regex regex = new Regex(@"/spreadsheets/d/([a-zA-Z0-9-_]+)");
            Match match = regex.Match(google_excel_url);

            if (match.Success)
            {
                spreadsheetId = match.Groups[1].Value;
            }

            // 使用google sheets Api v4憑證構建服務
            //var service = GetSheetsService(credentialFilePath);
            var service = GetSheetsService(file_path);

            // 读取数据
            IList<IList<object>> values = ReadDataFromSheet(service, spreadsheetId, "Sheet1");

            // 处理数据
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    foreach (var cell in row)
                    {
                        Console.Write($"{cell}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }

            Console.ReadLine();
        }

        private static SheetsService GetSheetsService(string credentialFilePath)
        {
            GoogleCredential credential;

            using (var stream = new System.IO.FileStream(credentialFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(SheetsService.Scope.Spreadsheets);
            }

            // 創建Google Sheets服務
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Google Sheets API C# Example"
            });

            return service;
        }

        private static IList<IList<object>> ReadDataFromSheet(SheetsService service, string spreadsheetId, string range)
        {
            SpreadsheetsResource.ValuesResource.GetRequest request =
                service.Spreadsheets.Values.Get(spreadsheetId, range);

            ValueRange response = request.Execute();
            IList<IList<object>> values = response.Values;

            return values;
        }
    }
}

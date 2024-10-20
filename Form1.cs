using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlViewerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            string url = urlTextBox.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Пожалуйста, введите URL.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Добавляем http://, если пользователь не указал протокол
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            try
            {
                string htmlContent = await LoadHtmlAsync(url);
                htmlTextBox.Text = htmlContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке страницы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> LoadHtmlAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Добавляем User-Agent, чтобы имитировать браузер
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.102 Safari/537.36");

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Бросит исключение, если статус код неуспешный (4xx или 5xx)

                string htmlContent = await response.Content.ReadAsStringAsync();
                return htmlContent;
            }
        }
    }
}

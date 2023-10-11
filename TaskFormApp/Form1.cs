using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int counter { get; set; } = 0;
        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            string data = String.Empty;
            Task<String> okuma = ReadFileAsync();
            await ReadFileAsync();

            richTextBox2.Text = await new HttpClient().GetStringAsync("https://www.google.com");

            data = await okuma; 


            rchFile.Text = data;
        }

        private void btnCounterPlus_Click(object sender, EventArgs e)
        {
            txtCounter.Text = counter++.ToString();
        }

        private string ReadFile()
        {
            string data = string.Empty;
            using (StreamReader s = new StreamReader("TestData.txt"))
            {
                Thread.Sleep(5000);
                data = s.ReadToEnd();
            }
            return data;
        }

        // Void == Task
        // String == Task<String>

        public async Task<string> ReadFileAsync()
        {
            string data = string.Empty;
            using (StreamReader s = new StreamReader("TestData.txt"))
            {
                Task<string> myTask = s.ReadToEndAsync();
                // 10 sn sürdü

                await Task.Delay(5000);

                data = await myTask;
                return data;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

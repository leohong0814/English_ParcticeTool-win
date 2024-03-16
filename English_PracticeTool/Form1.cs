using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace English_PracticeTool
{
    public partial class Form1 : Form
    {
        List<string> orgQuizBank = new List<string>();
        List<string> passQuiz = new List<string>();
        List<string> failQuiz = new List<string>();
        List<string> remainQuiz = new List<string>();
        string currentQuiz { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string jsonContent = File.ReadAllText("./WordsFile/Words.json");
            orgQuizBank = JsonConvert.DeserializeObject<List<string>>(jsonContent);
            string[] copiedArray = new string[orgQuizBank.Count];
            orgQuizBank.CopyTo(copiedArray);
            remainQuiz = new List<string>(copiedArray); 
            shuffleList(remainQuiz);
            updateQuiz();
            UpdateResultStatus();
            webBrowser1.Navigate("https://translate.google.com/?hl=zh-TW");
        }

        public string TranslateText(string input)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "en", "zh-TW", Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }

        private void button_ShowChinese_Click(object sender, EventArgs e)
        {
            label_QuizChinese.Text = TranslateText(currentQuiz);
        }

        private void button_Add2Pass_Click(object sender, EventArgs e)
        {
            passQuiz.Add(currentQuiz);
            remainQuiz.RemoveAt(0);
            updateQuiz();
            UpdateResultStatus();
        }

        private void button_Add2Fail_Click(object sender, EventArgs e)
        {
            failQuiz.Add(currentQuiz);
            remainQuiz.RemoveAt(0);
            updateQuiz();
            UpdateResultStatus();
        }

        void updateQuiz()
        {
            currentQuiz = remainQuiz.FirstOrDefault();
            label_Quiz.Text = currentQuiz;
            label_QuizChinese.Text = string.Empty;
        }

        void UpdateResultStatus()
        {
            label_PassCount.Text = passQuiz.Count.ToString();
            label_FailCount.Text = failQuiz.Count.ToString();
            label_TatalCount.Text = orgQuizBank.Count.ToString();
        }

        void shuffleList<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void loadWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = Directory.GetCurrentDirectory();
                dlg.Filter = "JSON (*.json)|*.json";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string jsonContent = File.ReadAllText(dlg.FileName);
                    orgQuizBank = JsonConvert.DeserializeObject<List<string>>(jsonContent);
                    passQuiz.Clear();
                    failQuiz.Clear();
                    remainQuiz.Clear();
                    shuffleList(remainQuiz);
                    updateQuiz();
                    UpdateResultStatus();
                }
            }
        }

        private void saveFailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.InitialDirectory = Directory.GetCurrentDirectory();
                dlg.Filter = "JSON (*.json)|*.json";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string jsonContent = JsonConvert.SerializeObject(failQuiz, Formatting.Indented);
                    File.WriteAllText(dlg.FileName, jsonContent);
                }
            }
        }

        private void saveFailRemainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.InitialDirectory = Directory.GetCurrentDirectory();
                dlg.Filter = "JSON (*.json)|*.json";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string jsonContent = JsonConvert.SerializeObject(failQuiz)+ JsonConvert.SerializeObject(remainQuiz);
                    File.WriteAllText(dlg.FileName, jsonContent);
                }
            }
        }

        private void saveRemainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.InitialDirectory = Directory.GetCurrentDirectory();
                dlg.Filter = "JSON (*.json)|*.json";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string jsonContent = JsonConvert.SerializeObject(remainQuiz);
                    File.WriteAllText(dlg.FileName, jsonContent);
                }
            }
        }
    }
}

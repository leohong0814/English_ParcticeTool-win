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

namespace English_PracticeTool
{
    public partial class Form1 : Form
    {
        List<KeyValuePair<string, string>> orgQuizBank = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> passQuiz = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> failQuiz = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> remainQuiz = new List<KeyValuePair<string, string>>();
        KeyValuePair<string, string> currentQuiz { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string jsonContent = File.ReadAllText("./WordsFile/Words.json");
            orgQuizBank = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent).ToList();
            remainQuiz = shuffleDic(orgQuizBank);
            updateQuiz();
            UpdateResultStatus();
        }

        private void button_ShowChinese_Click(object sender, EventArgs e)
        {
            label_QuizChinese.Text = currentQuiz.Value;
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
            label_Quiz.Text = currentQuiz.Key.ToString();
            label_QuizChinese.Text = string.Empty;
        }

        void UpdateResultStatus()
        {
            label_PassCount.Text = passQuiz.Count.ToString();
            label_FailCount.Text = failQuiz.Count.ToString();
            label_TatalCount.Text = orgQuizBank.Count.ToString();
        }

        List<KeyValuePair<string, string>> shuffleDic(List<KeyValuePair<string, string>> doc)
        {
            Random rng = new Random();
            int n = doc.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                KeyValuePair<string, string> value = doc[k];
                doc[k] = doc[n];
                doc[n] = value;
            }
            
            return doc;
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
                    orgQuizBank = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent).ToList();
                    passQuiz.Clear();
                    failQuiz.Clear();
                    remainQuiz.Clear();
                    remainQuiz = shuffleDic(orgQuizBank);
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

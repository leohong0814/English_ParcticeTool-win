
namespace English_PracticeTool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_Framwork = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Result = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_PassCount = new System.Windows.Forms.Label();
            this.label_FailCount = new System.Windows.Forms.Label();
            this.label_TatalCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Quiz = new System.Windows.Forms.Label();
            this.label_QuizChinese = new System.Windows.Forms.Label();
            this.button_ShowChinese = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Add2Fail = new System.Windows.Forms.Button();
            this.button_Add2Pass = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFailWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRemainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFailRemainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel_Framwork.SuspendLayout();
            this.tableLayoutPanel_Result.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Framwork
            // 
            this.tableLayoutPanel_Framwork.AutoSize = true;
            this.tableLayoutPanel_Framwork.ColumnCount = 2;
            this.tableLayoutPanel_Framwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Framwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_Framwork.Controls.Add(this.tableLayoutPanel_Result, 0, 1);
            this.tableLayoutPanel_Framwork.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel_Framwork.Controls.Add(this.button_ShowChinese, 1, 0);
            this.tableLayoutPanel_Framwork.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel_Framwork.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel_Framwork.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel_Framwork.Name = "tableLayoutPanel_Framwork";
            this.tableLayoutPanel_Framwork.RowCount = 2;
            this.tableLayoutPanel_Framwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Framwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Framwork.Size = new System.Drawing.Size(487, 501);
            this.tableLayoutPanel_Framwork.TabIndex = 0;
            // 
            // tableLayoutPanel_Result
            // 
            this.tableLayoutPanel_Result.AutoSize = true;
            this.tableLayoutPanel_Result.ColumnCount = 2;
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Result.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel_Result.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel_Result.Controls.Add(this.label_PassCount, 1, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_FailCount, 1, 1);
            this.tableLayoutPanel_Result.Controls.Add(this.label_TatalCount, 1, 2);
            this.tableLayoutPanel_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Result.Location = new System.Drawing.Point(3, 253);
            this.tableLayoutPanel_Result.Name = "tableLayoutPanel_Result";
            this.tableLayoutPanel_Result.RowCount = 3;
            this.tableLayoutPanel_Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Result.Size = new System.Drawing.Size(334, 245);
            this.tableLayoutPanel_Result.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 75);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pass Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 75);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fail Count:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 77);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Count:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PassCount
            // 
            this.label_PassCount.AutoSize = true;
            this.label_PassCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PassCount.ForeColor = System.Drawing.Color.Green;
            this.label_PassCount.Location = new System.Drawing.Point(170, 3);
            this.label_PassCount.Margin = new System.Windows.Forms.Padding(3);
            this.label_PassCount.Name = "label_PassCount";
            this.label_PassCount.Size = new System.Drawing.Size(161, 75);
            this.label_PassCount.TabIndex = 3;
            this.label_PassCount.Text = "#";
            this.label_PassCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FailCount
            // 
            this.label_FailCount.AutoSize = true;
            this.label_FailCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FailCount.ForeColor = System.Drawing.Color.Red;
            this.label_FailCount.Location = new System.Drawing.Point(170, 84);
            this.label_FailCount.Margin = new System.Windows.Forms.Padding(3);
            this.label_FailCount.Name = "label_FailCount";
            this.label_FailCount.Size = new System.Drawing.Size(161, 75);
            this.label_FailCount.TabIndex = 4;
            this.label_FailCount.Text = "#";
            this.label_FailCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TatalCount
            // 
            this.label_TatalCount.AutoSize = true;
            this.label_TatalCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TatalCount.Location = new System.Drawing.Point(170, 165);
            this.label_TatalCount.Margin = new System.Windows.Forms.Padding(3);
            this.label_TatalCount.Name = "label_TatalCount";
            this.label_TatalCount.Size = new System.Drawing.Size(161, 77);
            this.label_TatalCount.TabIndex = 5;
            this.label_TatalCount.Text = "#";
            this.label_TatalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_Quiz, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_QuizChinese, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 244);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label_Quiz
            // 
            this.label_Quiz.AutoSize = true;
            this.label_Quiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Quiz.Location = new System.Drawing.Point(3, 3);
            this.label_Quiz.Margin = new System.Windows.Forms.Padding(3);
            this.label_Quiz.Name = "label_Quiz";
            this.label_Quiz.Size = new System.Drawing.Size(328, 116);
            this.label_Quiz.TabIndex = 0;
            this.label_Quiz.Text = "Quiz";
            this.label_Quiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_QuizChinese
            // 
            this.label_QuizChinese.AutoSize = true;
            this.label_QuizChinese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_QuizChinese.Location = new System.Drawing.Point(3, 125);
            this.label_QuizChinese.Margin = new System.Windows.Forms.Padding(3);
            this.label_QuizChinese.Name = "label_QuizChinese";
            this.label_QuizChinese.Size = new System.Drawing.Size(328, 116);
            this.label_QuizChinese.TabIndex = 1;
            this.label_QuizChinese.Text = "Chinese";
            this.label_QuizChinese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ShowChinese
            // 
            this.button_ShowChinese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ShowChinese.Location = new System.Drawing.Point(343, 3);
            this.button_ShowChinese.Name = "button_ShowChinese";
            this.button_ShowChinese.Size = new System.Drawing.Size(141, 244);
            this.button_ShowChinese.TabIndex = 2;
            this.button_ShowChinese.Text = "Show Chinese";
            this.button_ShowChinese.UseVisualStyleBackColor = true;
            this.button_ShowChinese.Click += new System.EventHandler(this.button_ShowChinese_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button_Add2Fail, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_Add2Pass, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(343, 253);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(141, 245);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // button_Add2Fail
            // 
            this.button_Add2Fail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Add2Fail.Location = new System.Drawing.Point(3, 125);
            this.button_Add2Fail.Name = "button_Add2Fail";
            this.button_Add2Fail.Size = new System.Drawing.Size(135, 117);
            this.button_Add2Fail.TabIndex = 4;
            this.button_Add2Fail.Text = "Fail";
            this.button_Add2Fail.UseVisualStyleBackColor = true;
            this.button_Add2Fail.Click += new System.EventHandler(this.button_Add2Fail_Click);
            // 
            // button_Add2Pass
            // 
            this.button_Add2Pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Add2Pass.Location = new System.Drawing.Point(3, 3);
            this.button_Add2Pass.Name = "button_Add2Pass";
            this.button_Add2Pass.Size = new System.Drawing.Size(135, 116);
            this.button_Add2Pass.TabIndex = 3;
            this.button_Add2Pass.Text = "Pass";
            this.button_Add2Pass.UseVisualStyleBackColor = true;
            this.button_Add2Pass.Click += new System.EventHandler(this.button_Add2Pass_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFailWordToolStripMenuItem,
            this.loadWordsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveFailWordToolStripMenuItem
            // 
            this.saveFailWordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveRemainToolStripMenuItem,
            this.saveFailToolStripMenuItem,
            this.saveFailRemainToolStripMenuItem});
            this.saveFailWordToolStripMenuItem.Name = "saveFailWordToolStripMenuItem";
            this.saveFailWordToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveFailWordToolStripMenuItem.Text = "Save";
            // 
            // saveRemainToolStripMenuItem
            // 
            this.saveRemainToolStripMenuItem.Name = "saveRemainToolStripMenuItem";
            this.saveRemainToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveRemainToolStripMenuItem.Text = "Save Remain";
            this.saveRemainToolStripMenuItem.Click += new System.EventHandler(this.saveRemainToolStripMenuItem_Click);
            // 
            // saveFailToolStripMenuItem
            // 
            this.saveFailToolStripMenuItem.Name = "saveFailToolStripMenuItem";
            this.saveFailToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveFailToolStripMenuItem.Text = "Save Fail";
            this.saveFailToolStripMenuItem.Click += new System.EventHandler(this.saveFailToolStripMenuItem_Click);
            // 
            // saveFailRemainToolStripMenuItem
            // 
            this.saveFailRemainToolStripMenuItem.Name = "saveFailRemainToolStripMenuItem";
            this.saveFailRemainToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveFailRemainToolStripMenuItem.Text = "Save Fail and Remain";
            this.saveFailRemainToolStripMenuItem.Click += new System.EventHandler(this.saveFailRemainToolStripMenuItem_Click);
            // 
            // loadWordsToolStripMenuItem
            // 
            this.loadWordsToolStripMenuItem.Name = "loadWordsToolStripMenuItem";
            this.loadWordsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadWordsToolStripMenuItem.Text = "LoadWords";
            this.loadWordsToolStripMenuItem.Click += new System.EventHandler(this.loadWordsToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(489, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(669, 492);
            this.webBrowser1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 525);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tableLayoutPanel_Framwork);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel_Framwork.ResumeLayout(false);
            this.tableLayoutPanel_Framwork.PerformLayout();
            this.tableLayoutPanel_Result.ResumeLayout(false);
            this.tableLayoutPanel_Result.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Framwork;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_PassCount;
        private System.Windows.Forms.Label label_FailCount;
        private System.Windows.Forms.Label label_TatalCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_ShowChinese;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFailWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWordsToolStripMenuItem;
        private System.Windows.Forms.Button button_Add2Fail;
        private System.Windows.Forms.Button button_Add2Pass;
        private System.Windows.Forms.ToolStripMenuItem saveRemainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFailRemainToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Quiz;
        private System.Windows.Forms.Label label_QuizChinese;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


using System;

using System.Windows.Forms;
using System.IO;
using EBook.Properties;
using System.Resources;
using CheckRule;
using System.Drawing;

namespace EBook
{
    public partial class Form1 : Form
    {
        private int number = 1;
        Type res = typeof(Resources);
        Resources r = new Resources();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            String Chapter = "c" + number;
            
            String ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;
            this.richTextBox1.Text = ChapterContent;
            markText(ChapterContent);
            number++;    
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = " ";
            number = 1;
            this.SetCover();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel LinkChapter = sender as LinkLabel;
            number = int.Parse(LinkChapter.Name);
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            string Chapter = "c" + number;
            string ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;
            
            this.richTextBox1.Text = ChapterContent;
            markText(ChapterContent);
           

            number++;
        }
        private void markText(string ChapterContent)
        {
            string[] wrongWords = CheckVietnamese.Check(ChapterContent);
            int len = richTextBox1.TextLength;
            foreach (string wrongWord in wrongWords)
            {
                int index = 0;

                int lastIndex = richTextBox1.Text.LastIndexOf(wrongWord);
                while (index < lastIndex)
                {

                    int indexTemp = richTextBox1.Find(wrongWord, index, len, RichTextBoxFinds.None);

                    richTextBox1.SelectionBackColor = Color.Yellow;

                    index = indexTemp + 1;

                }
            }

        }
    }


}

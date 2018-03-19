using EBook.Properties;
using System;
using System.Windows.Forms;

namespace EBook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.AutoScroll = true;

            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
         
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1051, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBox1.Location = new System.Drawing.Point(290, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(827, 469);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "   ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Perpetua Titling MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(485, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(471, 87);
            this.button2.TabIndex = 3;
            this.button2.Text = "射雕英雄传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            int x = 12;
            const int y = 162;
            const int width = 60;
            const int height = 50;
            int step = 0;
            for (int i = 0; i < Number_Chapter; i++)
            {
               if (i % 10 == 0 && i > 9)
                {
                    step = i;
                    x += width;
                }

                LinkLabel linkLabel1 = new LinkLabel();
                Console.WriteLine("Haha");
                linkLabel1.AutoSize = true;
                linkLabel1.Location = new System.Drawing.Point(x, y + (i - step)*height + 4);
                linkLabel1.Size = new System.Drawing.Size(width, height);
                linkLabel1.TabIndex = 4;
                linkLabel1.TabStop = true;
                linkLabel1.Text = "Hồi " +(i+1);
                linkLabel1.Name = (i+1).ToString();
                linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
                flow.Controls.Add(linkLabel1);
                //this.Controls.Add(linkLabel1);
            }
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 661);
            this.Controls.Add(flow);
            
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            SetCover();
        }

        private void SetCover()
        {
            Clipboard.SetImage(Resources.cover);
            this.richTextBox1.Paste();
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Button button2;
    
        private const int Number_Chapter = 37;
    }
}


﻿namespace RemoveDuplicateFromList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            buttonSelect = new Button();
            buttonGo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "File :";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 30);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 2;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(53, 62);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(75, 23);
            buttonSelect.TabIndex = 4;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(157, 62);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(75, 23);
            buttonGo.TabIndex = 5;
            buttonGo.Text = "Go !";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(284, 95);
            Controls.Add(buttonGo);
            Controls.Add(buttonSelect);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Cursor = Cursors.Cross;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "RDFL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button buttonSelect;
        private Button buttonGo;
    }
}

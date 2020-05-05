﻿namespace Cryptograthy
{
    partial class FrequenAnalyzDialog
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.save_file_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.analyze_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.read_file_button = new System.Windows.Forms.Button();
            this.letters_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lettersGridView = new System.Windows.Forms.DataGridView();
            this.replaceGridView = new System.Windows.Forms.DataGridView();
            this.replace_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.letters_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // save_file_button
            // 
            this.save_file_button.Location = new System.Drawing.Point(465, 12);
            this.save_file_button.Name = "save_file_button";
            this.save_file_button.Size = new System.Drawing.Size(113, 23);
            this.save_file_button.TabIndex = 29;
            this.save_file_button.Text = "Сохранить в файл";
            this.save_file_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            // 
            // analyze_button
            // 
            this.analyze_button.Location = new System.Drawing.Point(347, 102);
            this.analyze_button.Name = "analyze_button";
            this.analyze_button.Size = new System.Drawing.Size(93, 35);
            this.analyze_button.TabIndex = 25;
            this.analyze_button.Text = "Отправить на анализ";
            this.analyze_button.UseVisualStyleBackColor = true;
            this.analyze_button.Click += new System.EventHandler(this.analyze_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(454, 41);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(292, 140);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(283, 141);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // read_file_button
            // 
            this.read_file_button.Location = new System.Drawing.Point(58, 8);
            this.read_file_button.Name = "read_file_button";
            this.read_file_button.Size = new System.Drawing.Size(133, 26);
            this.read_file_button.TabIndex = 18;
            this.read_file_button.Text = "Считать с файла";
            this.read_file_button.UseVisualStyleBackColor = true;
            // 
            // letters_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.letters_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.letters_chart.Legends.Add(legend3);
            this.letters_chart.Location = new System.Drawing.Point(377, 324);
            this.letters_chart.Name = "letters_chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.letters_chart.Series.Add(series3);
            this.letters_chart.Size = new System.Drawing.Size(369, 114);
            this.letters_chart.TabIndex = 30;
            this.letters_chart.Text = "chart1";
            // 
            // lettersGridView
            // 
            this.lettersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lettersGridView.Location = new System.Drawing.Point(377, 207);
            this.lettersGridView.Name = "lettersGridView";
            this.lettersGridView.Size = new System.Drawing.Size(369, 104);
            this.lettersGridView.TabIndex = 31;
            // 
            // replaceGridView
            // 
            this.replaceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.replaceGridView.Location = new System.Drawing.Point(58, 207);
            this.replaceGridView.Name = "replaceGridView";
            this.replaceGridView.RowHeadersWidth = 25;
            this.replaceGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.replaceGridView.Size = new System.Drawing.Size(214, 205);
            this.replaceGridView.TabIndex = 32;
            // 
            // replace_button
            // 
            this.replace_button.Location = new System.Drawing.Point(278, 302);
            this.replace_button.Name = "replace_button";
            this.replace_button.Size = new System.Drawing.Size(93, 35);
            this.replace_button.TabIndex = 33;
            this.replace_button.Text = " Заменить символы";
            this.replace_button.UseVisualStyleBackColor = true;
            this.replace_button.Click += new System.EventHandler(this.replace_button_Click);
            // 
            // FrequenAnalyzDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.replace_button);
            this.Controls.Add(this.replaceGridView);
            this.Controls.Add(this.lettersGridView);
            this.Controls.Add(this.letters_chart);
            this.Controls.Add(this.save_file_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.analyze_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.read_file_button);
            this.Name = "FrequenAnalyzDialog";
            this.Text = "FrequenAnalyz";
            ((System.ComponentModel.ISupportInitialize)(this.letters_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_file_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button analyze_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button read_file_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart letters_chart;
        private System.Windows.Forms.DataGridView lettersGridView;
        private System.Windows.Forms.DataGridView replaceGridView;
        private System.Windows.Forms.Button replace_button;
    }
}
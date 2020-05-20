namespace Cryptograthy
{
    partial class Polyalph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fieldKey = new System.Windows.Forms.TextBox();
            this.f15_ButtonSaveOriginal = new System.Windows.Forms.Label();
            this.f15_label4 = new System.Windows.Forms.Label();
            this.fieldOriginal = new System.Windows.Forms.TextBox();
            this.f15_ButtonReadCiphertext = new System.Windows.Forms.Label();
            this.f15_label2 = new System.Windows.Forms.Label();
            this.fieldCiphertext = new System.Windows.Forms.TextBox();
            this.useFoundedKey = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statistic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f15_label8 = new System.Windows.Forms.Label();
            this.foundedKey = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.keyLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.f15_label5 = new System.Windows.Forms.Label();
            this.buttonFindKeyLength = new System.Windows.Forms.Button();
            this.buttonFindKeys = new System.Windows.Forms.Button();
            this.f15_label6 = new System.Windows.Forms.Label();
            this.alfExtended = new System.Windows.Forms.TextBox();
            this.f15_label7 = new System.Windows.Forms.Label();
            this.alfTextBox = new System.Windows.Forms.TextBox();
            this.label_plus = new System.Windows.Forms.Label();
            this.checkBox_alfEx = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Casiski_radioButton = new System.Windows.Forms.RadioButton();
            this.Autocorr_radioButton = new System.Windows.Forms.RadioButton();
            this.MatchIndex_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyLengthUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldKey
            // 
            this.fieldKey.Location = new System.Drawing.Point(15, 18);
            this.fieldKey.Margin = new System.Windows.Forms.Padding(2);
            this.fieldKey.Name = "fieldKey";
            this.fieldKey.Size = new System.Drawing.Size(122, 20);
            this.fieldKey.TabIndex = 74;
            this.fieldKey.TextChanged += new System.EventHandler(this.fieldKey_TextChanged);
            this.fieldKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fieldKey_KeyPress);
            // 
            // f15_ButtonSaveOriginal
            // 
            this.f15_ButtonSaveOriginal.AutoSize = true;
            this.f15_ButtonSaveOriginal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.f15_ButtonSaveOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f15_ButtonSaveOriginal.ForeColor = System.Drawing.Color.Black;
            this.f15_ButtonSaveOriginal.Location = new System.Drawing.Point(534, 6);
            this.f15_ButtonSaveOriginal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f15_ButtonSaveOriginal.Name = "f15_ButtonSaveOriginal";
            this.f15_ButtonSaveOriginal.Size = new System.Drawing.Size(62, 15);
            this.f15_ButtonSaveOriginal.TabIndex = 81;
            this.f15_ButtonSaveOriginal.Text = "Сохранить";
            this.f15_ButtonSaveOriginal.Click += new System.EventHandler(this.ButtonSaveOriginal_Click);
            // 
            // f15_label4
            // 
            this.f15_label4.AutoSize = true;
            this.f15_label4.Location = new System.Drawing.Point(322, 8);
            this.f15_label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f15_label4.Name = "f15_label4";
            this.f15_label4.Size = new System.Drawing.Size(89, 13);
            this.f15_label4.TabIndex = 79;
            this.f15_label4.Text = "Исходный текст";
            // 
            // fieldOriginal
            // 
            this.fieldOriginal.Location = new System.Drawing.Point(325, 24);
            this.fieldOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.fieldOriginal.Multiline = true;
            this.fieldOriginal.Name = "fieldOriginal";
            this.fieldOriginal.ReadOnly = true;
            this.fieldOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fieldOriginal.Size = new System.Drawing.Size(298, 114);
            this.fieldOriginal.TabIndex = 75;
            this.fieldOriginal.TextChanged += new System.EventHandler(this.fieldOriginal_TextChanged);
            // 
            // f15_ButtonReadCiphertext
            // 
            this.f15_ButtonReadCiphertext.AutoSize = true;
            this.f15_ButtonReadCiphertext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.f15_ButtonReadCiphertext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f15_ButtonReadCiphertext.ForeColor = System.Drawing.Color.Black;
            this.f15_ButtonReadCiphertext.Location = new System.Drawing.Point(229, 6);
            this.f15_ButtonReadCiphertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f15_ButtonReadCiphertext.Name = "f15_ButtonReadCiphertext";
            this.f15_ButtonReadCiphertext.Size = new System.Drawing.Size(49, 15);
            this.f15_ButtonReadCiphertext.TabIndex = 78;
            this.f15_ButtonReadCiphertext.Text = "Считать";
            this.f15_ButtonReadCiphertext.Click += new System.EventHandler(this.f15_ButtonReadCiphertext_Click);
            // 
            // f15_label2
            // 
            this.f15_label2.AutoSize = true;
            this.f15_label2.Location = new System.Drawing.Point(8, 9);
            this.f15_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f15_label2.Name = "f15_label2";
            this.f15_label2.Size = new System.Drawing.Size(64, 13);
            this.f15_label2.TabIndex = 76;
            this.f15_label2.Text = "Шифртекст";
            // 
            // fieldCiphertext
            // 
            this.fieldCiphertext.Location = new System.Drawing.Point(11, 24);
            this.fieldCiphertext.Margin = new System.Windows.Forms.Padding(2);
            this.fieldCiphertext.Multiline = true;
            this.fieldCiphertext.Name = "fieldCiphertext";
            this.fieldCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fieldCiphertext.Size = new System.Drawing.Size(297, 114);
            this.fieldCiphertext.TabIndex = 73;
            this.fieldCiphertext.TextChanged += new System.EventHandler(this.fieldCiphertext_TextChanged);
            // 
            // useFoundedKey
            // 
            this.useFoundedKey.Location = new System.Drawing.Point(289, 19);
            this.useFoundedKey.Margin = new System.Windows.Forms.Padding(2);
            this.useFoundedKey.Name = "useFoundedKey";
            this.useFoundedKey.Size = new System.Drawing.Size(76, 20);
            this.useFoundedKey.TabIndex = 83;
            this.useFoundedKey.Text = "Применить";
            this.useFoundedKey.UseVisualStyleBackColor = true;
            this.useFoundedKey.Click += new System.EventHandler(this.useFoundedKey_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Letter,
            this.Amount,
            this.Frequency,
            this.Statistic});
            this.dataGridView.Location = new System.Drawing.Point(23, 356);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(291, 89);
            this.dataGridView.TabIndex = 89;
            // 
            // Letter
            // 
            this.Letter.HeaderText = "Буква";
            this.Letter.Name = "Letter";
            this.Letter.Width = 62;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Кол-во";
            this.Amount.Name = "Amount";
            this.Amount.Width = 66;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Частота";
            this.Frequency.Name = "Frequency";
            this.Frequency.Width = 74;
            // 
            // Statistic
            // 
            this.Statistic.HeaderText = "Табличная";
            this.Statistic.Name = "Statistic";
            this.Statistic.Width = 86;
            // 
            // f15_label8
            // 
            this.f15_label8.AutoSize = true;
            this.f15_label8.Location = new System.Drawing.Point(22, 332);
            this.f15_label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f15_label8.Name = "f15_label8";
            this.f15_label8.Size = new System.Drawing.Size(280, 13);
            this.f15_label8.TabIndex = 88;
            this.f15_label8.Text = "Частота встречаемости символов в исходном тексте";
            // 
            // foundedKey
            // 
            this.foundedKey.Location = new System.Drawing.Point(49, 19);
            this.foundedKey.Margin = new System.Windows.Forms.Padding(2);
            this.foundedKey.Name = "foundedKey";
            this.foundedKey.ReadOnly = true;
            this.foundedKey.Size = new System.Drawing.Size(156, 20);
            this.foundedKey.TabIndex = 82;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(29, 449);
            this.chart.Margin = new System.Windows.Forms.Padding(2);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Реальная частота";
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.EmptyPointStyle.Color = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Теоретическая частота";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(583, 159);
            this.chart.TabIndex = 90;
            this.chart.Text = "Chart";
            // 
            // keyLengthUpDown
            // 
            this.keyLengthUpDown.Location = new System.Drawing.Point(83, 17);
            this.keyLengthUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.keyLengthUpDown.Name = "keyLengthUpDown";
            this.keyLengthUpDown.Size = new System.Drawing.Size(51, 20);
            this.keyLengthUpDown.TabIndex = 92;
            // 
            // f15_label5
            // 
            this.f15_label5.AutoSize = true;
            this.f15_label5.Location = new System.Drawing.Point(5, 19);
            this.f15_label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f15_label5.Name = "f15_label5";
            this.f15_label5.Size = new System.Drawing.Size(74, 13);
            this.f15_label5.TabIndex = 93;
            this.f15_label5.Text = "Длина ключа";
            // 
            // buttonFindKeyLength
            // 
            this.buttonFindKeyLength.Location = new System.Drawing.Point(138, 17);
            this.buttonFindKeyLength.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFindKeyLength.Name = "buttonFindKeyLength";
            this.buttonFindKeyLength.Size = new System.Drawing.Size(76, 20);
            this.buttonFindKeyLength.TabIndex = 94;
            this.buttonFindKeyLength.Text = "Вычислить";
            this.buttonFindKeyLength.UseVisualStyleBackColor = true;
            this.buttonFindKeyLength.Click += new System.EventHandler(this.buttonFindKeyLength_Click);
            // 
            // buttonFindKeys
            // 
            this.buttonFindKeys.Location = new System.Drawing.Point(209, 18);
            this.buttonFindKeys.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFindKeys.Name = "buttonFindKeys";
            this.buttonFindKeys.Size = new System.Drawing.Size(76, 20);
            this.buttonFindKeys.TabIndex = 95;
            this.buttonFindKeys.Text = "Найти";
            this.buttonFindKeys.UseVisualStyleBackColor = true;
            this.buttonFindKeys.Click += new System.EventHandler(this.buttonFindKeys_Click);
            // 
            // f15_label6
            // 
            this.f15_label6.AutoSize = true;
            this.f15_label6.Location = new System.Drawing.Point(10, 22);
            this.f15_label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f15_label6.Name = "f15_label6";
            this.f15_label6.Size = new System.Drawing.Size(33, 13);
            this.f15_label6.TabIndex = 99;
            this.f15_label6.Text = "Ключ";
            // 
            // alfExtended
            // 
            this.alfExtended.Location = new System.Drawing.Point(240, 292);
            this.alfExtended.Margin = new System.Windows.Forms.Padding(2);
            this.alfExtended.Name = "alfExtended";
            this.alfExtended.Size = new System.Drawing.Size(80, 20);
            this.alfExtended.TabIndex = 100;
            this.alfExtended.TextChanged += new System.EventHandler(this.alfExtended_TextChanged);
            // 
            // f15_label7
            // 
            this.f15_label7.AutoSize = true;
            this.f15_label7.Location = new System.Drawing.Point(20, 294);
            this.f15_label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f15_label7.Name = "f15_label7";
            this.f15_label7.Size = new System.Drawing.Size(51, 13);
            this.f15_label7.TabIndex = 101;
            this.f15_label7.Text = "Алфавит";
            // 
            // alfTextBox
            // 
            this.alfTextBox.Location = new System.Drawing.Point(73, 292);
            this.alfTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.alfTextBox.Name = "alfTextBox";
            this.alfTextBox.Size = new System.Drawing.Size(150, 20);
            this.alfTextBox.TabIndex = 102;
            this.alfTextBox.TextChanged += new System.EventHandler(this.alfExtended_TextChanged);
            // 
            // label_plus
            // 
            this.label_plus.AutoSize = true;
            this.label_plus.Location = new System.Drawing.Point(226, 294);
            this.label_plus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_plus.Name = "label_plus";
            this.label_plus.Size = new System.Drawing.Size(13, 13);
            this.label_plus.TabIndex = 103;
            this.label_plus.Text = "+";
            // 
            // checkBox_alfEx
            // 
            this.checkBox_alfEx.AutoSize = true;
            this.checkBox_alfEx.Location = new System.Drawing.Point(324, 293);
            this.checkBox_alfEx.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_alfEx.Name = "checkBox_alfEx";
            this.checkBox_alfEx.Size = new System.Drawing.Size(179, 17);
            this.checkBox_alfEx.TabIndex = 104;
            this.checkBox_alfEx.Text = "Отправить в начало алфавита";
            this.checkBox_alfEx.UseVisualStyleBackColor = true;
            this.checkBox_alfEx.CheckedChanged += new System.EventHandler(this.checkBox_alfEx_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Casiski_radioButton);
            this.groupBox1.Controls.Add(this.Autocorr_radioButton);
            this.groupBox1.Controls.Add(this.MatchIndex_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 125);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите режим дешифрвоания";
            // 
            // Casiski_radioButton
            // 
            this.Casiski_radioButton.AutoSize = true;
            this.Casiski_radioButton.Location = new System.Drawing.Point(21, 68);
            this.Casiski_radioButton.Name = "Casiski_radioButton";
            this.Casiski_radioButton.Size = new System.Drawing.Size(106, 17);
            this.Casiski_radioButton.TabIndex = 2;
            this.Casiski_radioButton.TabStop = true;
            this.Casiski_radioButton.Text = "Метод Касиски.";
            this.Casiski_radioButton.UseVisualStyleBackColor = true;
            // 
            // Autocorr_radioButton
            // 
            this.Autocorr_radioButton.AutoSize = true;
            this.Autocorr_radioButton.Location = new System.Drawing.Point(21, 43);
            this.Autocorr_radioButton.Name = "Autocorr_radioButton";
            this.Autocorr_radioButton.Size = new System.Drawing.Size(172, 17);
            this.Autocorr_radioButton.TabIndex = 1;
            this.Autocorr_radioButton.TabStop = true;
            this.Autocorr_radioButton.Text = "Автокорреляционный метод.";
            this.Autocorr_radioButton.UseVisualStyleBackColor = true;
            // 
            // MatchIndex_radioButton
            // 
            this.MatchIndex_radioButton.AutoSize = true;
            this.MatchIndex_radioButton.Location = new System.Drawing.Point(21, 20);
            this.MatchIndex_radioButton.Name = "MatchIndex_radioButton";
            this.MatchIndex_radioButton.Size = new System.Drawing.Size(168, 17);
            this.MatchIndex_radioButton.TabIndex = 0;
            this.MatchIndex_radioButton.TabStop = true;
            this.MatchIndex_radioButton.Text = "Метод индекса совпадений.";
            this.MatchIndex_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFindKeyLength);
            this.groupBox2.Controls.Add(this.f15_label5);
            this.groupBox2.Controls.Add(this.keyLengthUpDown);
            this.groupBox2.Location = new System.Drawing.Point(382, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 54);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рассчитать длину ключа";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.f15_label6);
            this.groupBox3.Controls.Add(this.buttonFindKeys);
            this.groupBox3.Controls.Add(this.useFoundedKey);
            this.groupBox3.Controls.Add(this.foundedKey);
            this.groupBox3.Location = new System.Drawing.Point(225, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 58);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вычислить возможный ключ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fieldKey);
            this.groupBox4.Location = new System.Drawing.Point(225, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 53);
            this.groupBox4.TabIndex = 108;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редактировать ключ";
            // 
            // Polyalph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 614);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_alfEx);
            this.Controls.Add(this.label_plus);
            this.Controls.Add(this.alfTextBox);
            this.Controls.Add(this.f15_label7);
            this.Controls.Add(this.alfExtended);
            this.Controls.Add(this.fieldOriginal);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.f15_label8);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.f15_ButtonSaveOriginal);
            this.Controls.Add(this.f15_label4);
            this.Controls.Add(this.f15_ButtonReadCiphertext);
            this.Controls.Add(this.f15_label2);
            this.Controls.Add(this.fieldCiphertext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Polyalph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Криптоанализ полиалфавитных шифров";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyLengthUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fieldKey;
        private System.Windows.Forms.Label f15_ButtonSaveOriginal;
        private System.Windows.Forms.Label f15_label4;
        private System.Windows.Forms.TextBox fieldOriginal;
        private System.Windows.Forms.Label f15_ButtonReadCiphertext;
        private System.Windows.Forms.Label f15_label2;
        private System.Windows.Forms.TextBox fieldCiphertext;
        private System.Windows.Forms.Button useFoundedKey;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statistic;
        private System.Windows.Forms.Label f15_label8;
        private System.Windows.Forms.TextBox foundedKey;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.NumericUpDown keyLengthUpDown;
        private System.Windows.Forms.Label f15_label5;
        private System.Windows.Forms.Button buttonFindKeyLength;
        private System.Windows.Forms.Button buttonFindKeys;
        private System.Windows.Forms.Label f15_label6;
        private System.Windows.Forms.TextBox alfExtended;
        private System.Windows.Forms.Label f15_label7;
        private System.Windows.Forms.TextBox alfTextBox;
        private System.Windows.Forms.Label label_plus;
        private System.Windows.Forms.CheckBox checkBox_alfEx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Casiski_radioButton;
        private System.Windows.Forms.RadioButton Autocorr_radioButton;
        private System.Windows.Forms.RadioButton MatchIndex_radioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}
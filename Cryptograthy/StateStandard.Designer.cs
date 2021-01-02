namespace Cryptograthy
{
    partial class StateStandard
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crypt_file_button = new System.Windows.Forms.Button();
            this.decrypt_file_button = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.write_key_button = new System.Windows.Forms.Button();
            this.read_key_button = new System.Windows.Forms.Button();
            this.generate_key_button = new System.Windows.Forms.Button();
            this.paste_key_button = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.feedback_mode_butt = new System.Windows.Forms.RadioButton();
            this.usual_mode_butt = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Руковдство пользователя";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.crypt_file_button);
            this.groupBox3.Controls.Add(this.decrypt_file_button);
            this.groupBox3.Controls.Add(this.pb);
            this.groupBox3.Location = new System.Drawing.Point(503, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 117);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Работа с файлом";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // crypt_file_button
            // 
            this.crypt_file_button.Location = new System.Drawing.Point(23, 18);
            this.crypt_file_button.Name = "crypt_file_button";
            this.crypt_file_button.Size = new System.Drawing.Size(91, 49);
            this.crypt_file_button.TabIndex = 3;
            this.crypt_file_button.Text = "Зашифровать файл";
            this.toolTip1.SetToolTip(this.crypt_file_button, "Подходит файл любого формата");
            this.crypt_file_button.UseVisualStyleBackColor = true;
            this.crypt_file_button.Click += new System.EventHandler(this.crypt_file_button_Click);
            // 
            // decrypt_file_button
            // 
            this.decrypt_file_button.Location = new System.Drawing.Point(120, 18);
            this.decrypt_file_button.Name = "decrypt_file_button";
            this.decrypt_file_button.Size = new System.Drawing.Size(99, 49);
            this.decrypt_file_button.TabIndex = 4;
            this.decrypt_file_button.Text = "Расшифровать файл";
            this.decrypt_file_button.UseVisualStyleBackColor = true;
            this.decrypt_file_button.Click += new System.EventHandler(this.decrypt_file_button_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(23, 73);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(196, 20);
            this.pb.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.write_key_button);
            this.groupBox2.Controls.Add(this.read_key_button);
            this.groupBox2.Controls.Add(this.generate_key_button);
            this.groupBox2.Controls.Add(this.paste_key_button);
            this.groupBox2.Controls.Add(this.keyTextBox);
            this.groupBox2.Location = new System.Drawing.Point(60, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 117);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с ключом";
            // 
            // write_key_button
            // 
            this.write_key_button.Location = new System.Drawing.Point(14, 42);
            this.write_key_button.Name = "write_key_button";
            this.write_key_button.Size = new System.Drawing.Size(96, 25);
            this.write_key_button.TabIndex = 16;
            this.write_key_button.Text = "Ключ в файл";
            this.toolTip1.SetToolTip(this.write_key_button, "Записывает ключ побайтово!");
            this.write_key_button.UseVisualStyleBackColor = true;
            this.write_key_button.Click += new System.EventHandler(this.write_key_button_Click_1);
            // 
            // read_key_button
            // 
            this.read_key_button.Location = new System.Drawing.Point(14, 17);
            this.read_key_button.Name = "read_key_button";
            this.read_key_button.Size = new System.Drawing.Size(96, 25);
            this.read_key_button.TabIndex = 15;
            this.read_key_button.Text = "Ключ из файла";
            this.toolTip1.SetToolTip(this.read_key_button, "Считывает первые 16 байт файла!");
            this.read_key_button.UseVisualStyleBackColor = true;
            this.read_key_button.Click += new System.EventHandler(this.read_key_button_Click_1);
            // 
            // generate_key_button
            // 
            this.generate_key_button.Location = new System.Drawing.Point(202, 18);
            this.generate_key_button.Name = "generate_key_button";
            this.generate_key_button.Size = new System.Drawing.Size(97, 49);
            this.generate_key_button.TabIndex = 2;
            this.generate_key_button.Text = "Сгенерировать \r\nключ";
            this.toolTip1.SetToolTip(this.generate_key_button, "Формат ключа - 16 байт слитно - Пример: 1A2B3C4D9E6F70...");
            this.generate_key_button.UseVisualStyleBackColor = true;
            this.generate_key_button.Click += new System.EventHandler(this.generate_key_button_Click);
            // 
            // paste_key_button
            // 
            this.paste_key_button.Location = new System.Drawing.Point(113, 18);
            this.paste_key_button.Name = "paste_key_button";
            this.paste_key_button.Size = new System.Drawing.Size(86, 49);
            this.paste_key_button.TabIndex = 5;
            this.paste_key_button.Text = "Задать ключ";
            this.toolTip1.SetToolTip(this.paste_key_button, "Применяет введенный Вами ключ");
            this.paste_key_button.UseVisualStyleBackColor = true;
            this.paste_key_button.Click += new System.EventHandler(this.paste_key_button_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(14, 72);
            this.keyTextBox.MaxLength = 14;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(417, 20);
            this.keyTextBox.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Запись в файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Расшифровать";
            this.toolTip1.SetToolTip(this.button2, "0x00 байт не отображается в окне, поэтому могут иногда возникать ошибки расшифров" +
        "ки, в отличие от работы с файлами");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Защифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feedback_mode_butt);
            this.groupBox1.Controls.Add(this.usual_mode_butt);
            this.groupBox1.Location = new System.Drawing.Point(60, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 53);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим работы";
            // 
            // feedback_mode_butt
            // 
            this.feedback_mode_butt.AutoSize = true;
            this.feedback_mode_butt.Location = new System.Drawing.Point(154, 20);
            this.feedback_mode_butt.Name = "feedback_mode_butt";
            this.feedback_mode_butt.Size = new System.Drawing.Size(128, 17);
            this.feedback_mode_butt.TabIndex = 1;
            this.feedback_mode_butt.TabStop = true;
            this.feedback_mode_butt.Text = "Гаммирование с ОС";
            this.feedback_mode_butt.UseVisualStyleBackColor = true;
            // 
            // usual_mode_butt
            // 
            this.usual_mode_butt.AutoSize = true;
            this.usual_mode_butt.Location = new System.Drawing.Point(6, 20);
            this.usual_mode_butt.Name = "usual_mode_butt";
            this.usual_mode_butt.Size = new System.Drawing.Size(147, 17);
            this.usual_mode_butt.TabIndex = 0;
            this.usual_mode_butt.TabStop = true;
            this.usual_mode_butt.Text = "Режим простой замены";
            this.usual_mode_butt.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(461, 70);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 140);
            this.textBox2.TabIndex = 21;
            this.toolTip1.SetToolTip(this.textBox2, "0x00 байт не отображается в окне, поэтому могут иногда возникать ошибки расшифров" +
        "ки, в отличие от работы с файлами");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 141);
            this.textBox1.TabIndex = 20;
            // 
            // StateStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "StateStandard";
            this.Text = "шифр ГОСТ";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crypt_file_button;
        private System.Windows.Forms.Button decrypt_file_button;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button write_key_button;
        private System.Windows.Forms.Button read_key_button;
        private System.Windows.Forms.Button generate_key_button;
        private System.Windows.Forms.Button paste_key_button;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton feedback_mode_butt;
        private System.Windows.Forms.RadioButton usual_mode_butt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
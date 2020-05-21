namespace Cryptograthy
{
    partial class DESDialog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.generate_key_button = new System.Windows.Forms.Button();
            this.crypt_file_button = new System.Windows.Forms.Button();
            this.decrypt_file_button = new System.Windows.Forms.Button();
            this.paste_key_button = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OFB_butt = new System.Windows.Forms.RadioButton();
            this.CFB_butt = new System.Windows.Forms.RadioButton();
            this.CBC_butt = new System.Windows.Forms.RadioButton();
            this.ECB_butt = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.read_key_button = new System.Windows.Forms.Button();
            this.write_key_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 141);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(442, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 140);
            this.textBox2.TabIndex = 1;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(116, 72);
            this.keyTextBox.MaxLength = 14;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(110, 20);
            this.keyTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.keyTextBox, "Формат ключа - 7 байт слитно - Пример: 1A2B3C4D9E6F70");
            // 
            // generate_key_button
            // 
            this.generate_key_button.Location = new System.Drawing.Point(116, 17);
            this.generate_key_button.Name = "generate_key_button";
            this.generate_key_button.Size = new System.Drawing.Size(110, 49);
            this.generate_key_button.TabIndex = 2;
            this.generate_key_button.Text = "Сгенерировать \r\nключ";
            this.generate_key_button.UseVisualStyleBackColor = true;
            this.generate_key_button.Click += new System.EventHandler(this.DesGenerate_Innit_Key);
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
            this.crypt_file_button.Click += new System.EventHandler(this.DesFileEncrypt);
            // 
            // decrypt_file_button
            // 
            this.decrypt_file_button.Location = new System.Drawing.Point(120, 18);
            this.decrypt_file_button.Name = "decrypt_file_button";
            this.decrypt_file_button.Size = new System.Drawing.Size(99, 49);
            this.decrypt_file_button.TabIndex = 4;
            this.decrypt_file_button.Text = "Расшифровать файл";
            this.decrypt_file_button.UseVisualStyleBackColor = true;
            this.decrypt_file_button.Click += new System.EventHandler(this.DesFileDecrypt);
            // 
            // paste_key_button
            // 
            this.paste_key_button.Location = new System.Drawing.Point(14, 67);
            this.paste_key_button.Name = "paste_key_button";
            this.paste_key_button.Size = new System.Drawing.Size(96, 25);
            this.paste_key_button.TabIndex = 5;
            this.paste_key_button.Text = "Задать ключ";
            this.toolTip1.SetToolTip(this.paste_key_button, "Применяет введенный Вами ключ");
            this.paste_key_button.UseVisualStyleBackColor = true;
            this.paste_key_button.Click += new System.EventHandler(this.DesReadKey);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(23, 73);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(196, 20);
            this.pb.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OFB_butt);
            this.groupBox1.Controls.Add(this.CFB_butt);
            this.groupBox1.Controls.Add(this.CBC_butt);
            this.groupBox1.Controls.Add(this.ECB_butt);
            this.groupBox1.Location = new System.Drawing.Point(92, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим работы";
            // 
            // OFB_butt
            // 
            this.OFB_butt.AutoSize = true;
            this.OFB_butt.Location = new System.Drawing.Point(6, 89);
            this.OFB_butt.Name = "OFB_butt";
            this.OFB_butt.Size = new System.Drawing.Size(46, 17);
            this.OFB_butt.TabIndex = 3;
            this.OFB_butt.TabStop = true;
            this.OFB_butt.Text = "OFB";
            this.OFB_butt.UseVisualStyleBackColor = true;
            // 
            // CFB_butt
            // 
            this.CFB_butt.AutoSize = true;
            this.CFB_butt.Location = new System.Drawing.Point(6, 66);
            this.CFB_butt.Name = "CFB_butt";
            this.CFB_butt.Size = new System.Drawing.Size(45, 17);
            this.CFB_butt.TabIndex = 2;
            this.CFB_butt.TabStop = true;
            this.CFB_butt.Text = "CFB";
            this.CFB_butt.UseVisualStyleBackColor = true;
            // 
            // CBC_butt
            // 
            this.CBC_butt.AutoSize = true;
            this.CBC_butt.Location = new System.Drawing.Point(6, 43);
            this.CBC_butt.Name = "CBC_butt";
            this.CBC_butt.Size = new System.Drawing.Size(46, 17);
            this.CBC_butt.TabIndex = 1;
            this.CBC_butt.TabStop = true;
            this.CBC_butt.Text = "CBC";
            this.CBC_butt.UseVisualStyleBackColor = true;
            // 
            // ECB_butt
            // 
            this.ECB_butt.AutoSize = true;
            this.ECB_butt.Location = new System.Drawing.Point(6, 20);
            this.ECB_butt.Name = "ECB_butt";
            this.ECB_butt.Size = new System.Drawing.Size(46, 17);
            this.ECB_butt.TabIndex = 0;
            this.ECB_butt.TabStop = true;
            this.ECB_butt.Text = "ECB";
            this.ECB_butt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Защифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Расшифровать";
            this.toolTip2.SetToolTip(this.button2, "0x00 байт не отображается в окне, поэтому могут иногда возникать ошибки расшифров" +
        "ки, в отличие от работы с файлами");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Запись в файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // read_key_button
            // 
            this.read_key_button.Location = new System.Drawing.Point(14, 17);
            this.read_key_button.Name = "read_key_button";
            this.read_key_button.Size = new System.Drawing.Size(96, 25);
            this.read_key_button.TabIndex = 15;
            this.read_key_button.Text = "Ключ из файла";
            this.toolTip1.SetToolTip(this.read_key_button, "Считывает первые 7 байт файла!");
            this.read_key_button.UseVisualStyleBackColor = true;
            this.read_key_button.Click += new System.EventHandler(this.read_key_button_Click);
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
            this.write_key_button.Click += new System.EventHandler(this.write_key_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.write_key_button);
            this.groupBox2.Controls.Add(this.read_key_button);
            this.groupBox2.Controls.Add(this.generate_key_button);
            this.groupBox2.Controls.Add(this.paste_key_button);
            this.groupBox2.Controls.Add(this.keyTextBox);
            this.groupBox2.Location = new System.Drawing.Point(201, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 117);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с ключом";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.crypt_file_button);
            this.groupBox3.Controls.Add(this.decrypt_file_button);
            this.groupBox3.Controls.Add(this.pb);
            this.groupBox3.Location = new System.Drawing.Point(464, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 117);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Работа с файлом";
            this.toolTip1.SetToolTip(this.groupBox3, "Подходит файл любого формата");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Руковдство пользователя";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DESDialog
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
            this.Name = "DESDialog";
            this.Text = " DES ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button generate_key_button;
        private System.Windows.Forms.Button crypt_file_button;
        private System.Windows.Forms.Button decrypt_file_button;
        private System.Windows.Forms.Button paste_key_button;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OFB_butt;
        private System.Windows.Forms.RadioButton CFB_butt;
        private System.Windows.Forms.RadioButton CBC_butt;
        private System.Windows.Forms.RadioButton ECB_butt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button read_key_button;
        private System.Windows.Forms.Button write_key_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
    }
}
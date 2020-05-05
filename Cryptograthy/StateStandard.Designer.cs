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
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OFB_butt = new System.Windows.Forms.RadioButton();
            this.CFB_butt = new System.Windows.Forms.RadioButton();
            this.CBC_butt = new System.Windows.Forms.RadioButton();
            this.ECB_butt = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.generate_key_button = new System.Windows.Forms.Button();
            this.paste_key_button = new System.Windows.Forms.Button();
            this.crypt_file_button = new System.Windows.Forms.Button();
            this.decrypt_file_button = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Запись в файл";
            this.button3.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Дешифровать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Защифровать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OFB_butt);
            this.groupBox1.Controls.Add(this.CFB_butt);
            this.groupBox1.Controls.Add(this.CBC_butt);
            this.groupBox1.Controls.Add(this.ECB_butt);
            this.groupBox1.Location = new System.Drawing.Point(105, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 118);
            this.groupBox1.TabIndex = 24;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 78);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 140);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 141);
            this.textBox1.TabIndex = 15;
            // 
            // generate_key_button
            // 
            this.generate_key_button.Location = new System.Drawing.Point(344, 284);
            this.generate_key_button.Name = "generate_key_button";
            this.generate_key_button.Size = new System.Drawing.Size(96, 39);
            this.generate_key_button.TabIndex = 17;
            this.generate_key_button.Text = "Сгенерировать \r\nключ";
            this.generate_key_button.UseVisualStyleBackColor = true;
            // 
            // paste_key_button
            // 
            this.paste_key_button.Location = new System.Drawing.Point(228, 334);
            this.paste_key_button.Name = "paste_key_button";
            this.paste_key_button.Size = new System.Drawing.Size(96, 29);
            this.paste_key_button.TabIndex = 20;
            this.paste_key_button.Text = "Задать ключ";
            this.paste_key_button.UseVisualStyleBackColor = true;
            // 
            // crypt_file_button
            // 
            this.crypt_file_button.Location = new System.Drawing.Point(454, 284);
            this.crypt_file_button.Name = "crypt_file_button";
            this.crypt_file_button.Size = new System.Drawing.Size(91, 39);
            this.crypt_file_button.TabIndex = 18;
            this.crypt_file_button.Text = "Зашифровать файл";
            this.crypt_file_button.UseVisualStyleBackColor = true;
            // 
            // decrypt_file_button
            // 
            this.decrypt_file_button.Location = new System.Drawing.Point(551, 284);
            this.decrypt_file_button.Name = "decrypt_file_button";
            this.decrypt_file_button.Size = new System.Drawing.Size(99, 39);
            this.decrypt_file_button.TabIndex = 19;
            this.decrypt_file_button.Text = "Расшифровать файл";
            this.decrypt_file_button.UseVisualStyleBackColor = true;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(330, 339);
            this.keyTextBox.MaxLength = 14;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(110, 20);
            this.keyTextBox.TabIndex = 21;
            // 
            // lb
            // 
            this.lb.Location = new System.Drawing.Point(225, 375);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(328, 27);
            this.lb.TabIndex = 22;
            this.lb.Text = "Формат ключа - 7 байт слитно - Пример: 1A2B3C4D9E6F70";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(454, 339);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(196, 20);
            this.pb.TabIndex = 23;
            // 
            // StateStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.generate_key_button);
            this.Controls.Add(this.paste_key_button);
            this.Controls.Add(this.crypt_file_button);
            this.Controls.Add(this.decrypt_file_button);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.pb);
            this.Name = "StateStandard";
            this.Text = "StateStandard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OFB_butt;
        private System.Windows.Forms.RadioButton CFB_butt;
        private System.Windows.Forms.RadioButton CBC_butt;
        private System.Windows.Forms.RadioButton ECB_butt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button generate_key_button;
        private System.Windows.Forms.Button paste_key_button;
        private System.Windows.Forms.Button crypt_file_button;
        private System.Windows.Forms.Button decrypt_file_button;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ProgressBar pb;
    }
}
﻿namespace Cryptograthy
{
    partial class Kazakevich
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.atbash_button = new System.Windows.Forms.Button();
            this.skytala_button = new System.Windows.Forms.Button();
            this.caesar_button = new System.Windows.Forms.Button();
            this.polybius_button = new System.Windows.Forms.Button();
            this.cardan_button = new System.Windows.Forms.Button();
            this.richelieu_button = new System.Windows.Forms.Button();
            this.alberti_button = new System.Windows.Forms.Button();
            this.gronsfeild_button = new System.Windows.Forms.Button();
            this.vigenere_button = new System.Windows.Forms.Button();
            this.playfair_button = new System.Windows.Forms.Button();
            this.vername_button = new System.Windows.Forms.Button();
            this.hill_button = new System.Windows.Forms.Button();
            this.xor_cipher_button = new System.Windows.Forms.Button();
            this.freq_button = new System.Windows.Forms.Button();
            this.polyalph_button = new System.Windows.Forms.Button();
            this.des_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_each = new System.Windows.Forms.Panel();
            this.crypt_label = new System.Windows.Forms.Label();
            this.decypher = new System.Windows.Forms.Button();
            this.cypher = new System.Windows.Forms.Button();
            this.exchange = new System.Windows.Forms.Button();
            this.state_standard_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel_each.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.atbash_button);
            this.flowLayoutPanel2.Controls.Add(this.skytala_button);
            this.flowLayoutPanel2.Controls.Add(this.caesar_button);
            this.flowLayoutPanel2.Controls.Add(this.polybius_button);
            this.flowLayoutPanel2.Controls.Add(this.cardan_button);
            this.flowLayoutPanel2.Controls.Add(this.richelieu_button);
            this.flowLayoutPanel2.Controls.Add(this.alberti_button);
            this.flowLayoutPanel2.Controls.Add(this.gronsfeild_button);
            this.flowLayoutPanel2.Controls.Add(this.vigenere_button);
            this.flowLayoutPanel2.Controls.Add(this.playfair_button);
            this.flowLayoutPanel2.Controls.Add(this.vername_button);
            this.flowLayoutPanel2.Controls.Add(this.hill_button);
            this.flowLayoutPanel2.Controls.Add(this.xor_cipher_button);
            this.flowLayoutPanel2.Controls.Add(this.freq_button);
            this.flowLayoutPanel2.Controls.Add(this.polyalph_button);
            this.flowLayoutPanel2.Controls.Add(this.des_button);
            this.flowLayoutPanel2.Controls.Add(this.state_standard_button);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(156, 484);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // atbash_button
            // 
            this.atbash_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.atbash_button.Location = new System.Drawing.Point(3, 3);
            this.atbash_button.Name = "atbash_button";
            this.atbash_button.Size = new System.Drawing.Size(133, 67);
            this.atbash_button.TabIndex = 0;
            this.atbash_button.Text = " АТБАШ";
            this.atbash_button.UseVisualStyleBackColor = true;
            this.atbash_button.Click += new System.EventHandler(this.atbash_button_Click);
            // 
            // skytala_button
            // 
            this.skytala_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.skytala_button.Location = new System.Drawing.Point(3, 76);
            this.skytala_button.Name = "skytala_button";
            this.skytala_button.Size = new System.Drawing.Size(133, 67);
            this.skytala_button.TabIndex = 0;
            this.skytala_button.Text = "\"Сцитала\"";
            this.skytala_button.UseVisualStyleBackColor = true;
            this.skytala_button.Click += new System.EventHandler(this.skytala_button_Click);
            // 
            // caesar_button
            // 
            this.caesar_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.caesar_button.Location = new System.Drawing.Point(3, 149);
            this.caesar_button.Name = "caesar_button";
            this.caesar_button.Size = new System.Drawing.Size(133, 67);
            this.caesar_button.TabIndex = 0;
            this.caesar_button.Text = "шифр Цезаря";
            this.caesar_button.UseVisualStyleBackColor = true;
            this.caesar_button.Click += new System.EventHandler(this.caesar_button_Click);
            // 
            // polybius_button
            // 
            this.polybius_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.polybius_button.Location = new System.Drawing.Point(3, 222);
            this.polybius_button.Name = "polybius_button";
            this.polybius_button.Size = new System.Drawing.Size(133, 67);
            this.polybius_button.TabIndex = 0;
            this.polybius_button.Text = "Квадрат Полибия";
            this.polybius_button.UseVisualStyleBackColor = true;
            this.polybius_button.Click += new System.EventHandler(this.polybius_button_Click);
            // 
            // cardan_button
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.cardan_button, true);
            this.cardan_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cardan_button.Location = new System.Drawing.Point(3, 295);
            this.cardan_button.Name = "cardan_button";
            this.cardan_button.Size = new System.Drawing.Size(133, 67);
            this.cardan_button.TabIndex = 6;
            this.cardan_button.Text = "Шифр Кардано";
            this.cardan_button.UseVisualStyleBackColor = true;
            this.cardan_button.Click += new System.EventHandler(this.cardan_button_Click);
            // 
            // richelieu_button
            // 
            this.richelieu_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.richelieu_button.Location = new System.Drawing.Point(3, 368);
            this.richelieu_button.Name = "richelieu_button";
            this.richelieu_button.Size = new System.Drawing.Size(133, 67);
            this.richelieu_button.TabIndex = 7;
            this.richelieu_button.Text = "Шифр Ришелье";
            this.richelieu_button.UseVisualStyleBackColor = true;
            this.richelieu_button.Click += new System.EventHandler(this.richelieu_button_Click);
            // 
            // alberti_button
            // 
            this.alberti_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.alberti_button.Location = new System.Drawing.Point(3, 441);
            this.alberti_button.Name = "alberti_button";
            this.alberti_button.Size = new System.Drawing.Size(133, 67);
            this.alberti_button.TabIndex = 1;
            this.alberti_button.Text = "Диск Альберти";
            this.alberti_button.UseVisualStyleBackColor = true;
            this.alberti_button.Click += new System.EventHandler(this.alberti_button_Click);
            // 
            // gronsfeild_button
            // 
            this.gronsfeild_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gronsfeild_button.Location = new System.Drawing.Point(3, 514);
            this.gronsfeild_button.Name = "gronsfeild_button";
            this.gronsfeild_button.Size = new System.Drawing.Size(133, 67);
            this.gronsfeild_button.TabIndex = 4;
            this.gronsfeild_button.Text = "Шифр Гронсфелда";
            this.gronsfeild_button.UseVisualStyleBackColor = true;
            this.gronsfeild_button.Click += new System.EventHandler(this.gronsfeild_button_Click);
            // 
            // vigenere_button
            // 
            this.vigenere_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.vigenere_button.Location = new System.Drawing.Point(3, 587);
            this.vigenere_button.Name = "vigenere_button";
            this.vigenere_button.Size = new System.Drawing.Size(133, 67);
            this.vigenere_button.TabIndex = 5;
            this.vigenere_button.Text = "Шифр Виженера";
            this.vigenere_button.UseVisualStyleBackColor = true;
            this.vigenere_button.Click += new System.EventHandler(this.vigenere_button_Click);
            // 
            // playfair_button
            // 
            this.playfair_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.playfair_button.Location = new System.Drawing.Point(3, 660);
            this.playfair_button.Name = "playfair_button";
            this.playfair_button.Size = new System.Drawing.Size(133, 67);
            this.playfair_button.TabIndex = 8;
            this.playfair_button.Text = "Шифр Плейфера";
            this.playfair_button.UseVisualStyleBackColor = true;
            this.playfair_button.Click += new System.EventHandler(this.playfair_button_Click);
            // 
            // vername_button
            // 
            this.vername_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.vername_button.Location = new System.Drawing.Point(3, 733);
            this.vername_button.Name = "vername_button";
            this.vername_button.Size = new System.Drawing.Size(133, 67);
            this.vername_button.TabIndex = 9;
            this.vername_button.Text = "Шифр Вернама";
            this.vername_button.UseVisualStyleBackColor = true;
            this.vername_button.Click += new System.EventHandler(this.vername_button_Click);
            // 
            // hill_button
            // 
            this.hill_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.hill_button.Location = new System.Drawing.Point(3, 806);
            this.hill_button.Name = "hill_button";
            this.hill_button.Size = new System.Drawing.Size(133, 67);
            this.hill_button.TabIndex = 12;
            this.hill_button.Text = "Шифр Хилла";
            this.hill_button.UseVisualStyleBackColor = true;
            this.hill_button.Click += new System.EventHandler(this.hill_button_Click);
            // 
            // xor_cipher_button
            // 
            this.xor_cipher_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xor_cipher_button.Location = new System.Drawing.Point(3, 879);
            this.xor_cipher_button.Name = "xor_cipher_button";
            this.xor_cipher_button.Size = new System.Drawing.Size(133, 67);
            this.xor_cipher_button.TabIndex = 11;
            this.xor_cipher_button.Text = "Метод Гаммирования";
            this.xor_cipher_button.UseVisualStyleBackColor = true;
            this.xor_cipher_button.Click += new System.EventHandler(this.xor_cipher_button_Click);
            // 
            // freq_button
            // 
            this.freq_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.freq_button.Location = new System.Drawing.Point(3, 952);
            this.freq_button.Name = "freq_button";
            this.freq_button.Size = new System.Drawing.Size(133, 67);
            this.freq_button.TabIndex = 13;
            this.freq_button.Text = "Частотный криптоанализ";
            this.freq_button.UseVisualStyleBackColor = true;
            this.freq_button.Click += new System.EventHandler(this.freq_button_Click);
            // 
            // polyalph_button
            // 
            this.polyalph_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.polyalph_button.Location = new System.Drawing.Point(3, 1025);
            this.polyalph_button.Name = "polyalph_button";
            this.polyalph_button.Size = new System.Drawing.Size(133, 67);
            this.polyalph_button.TabIndex = 14;
            this.polyalph_button.Text = "Криптоанализ полиалфавитных шифров";
            this.polyalph_button.UseVisualStyleBackColor = true;
            this.polyalph_button.Click += new System.EventHandler(this.polyalph_button_Click);
            // 
            // des_button
            // 
            this.des_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.des_button.Location = new System.Drawing.Point(3, 1098);
            this.des_button.Name = "des_button";
            this.des_button.Size = new System.Drawing.Size(133, 67);
            this.des_button.TabIndex = 10;
            this.des_button.Text = "DES";
            this.des_button.UseVisualStyleBackColor = true;
            this.des_button.Click += new System.EventHandler(this.des_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(185, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 257);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox2.Location = new System.Drawing.Point(497, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 257);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(260, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(583, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Зашифрованный текст";
            // 
            // panel_each
            // 
            this.panel_each.Controls.Add(this.crypt_label);
            this.panel_each.Controls.Add(this.decypher);
            this.panel_each.Controls.Add(this.cypher);
            this.panel_each.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_each.Location = new System.Drawing.Point(187, 328);
            this.panel_each.Name = "panel_each";
            this.panel_each.Size = new System.Drawing.Size(583, 144);
            this.panel_each.TabIndex = 4;
            this.panel_each.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_each_Paint);
            // 
            // crypt_label
            // 
            this.crypt_label.AutoSize = true;
            this.crypt_label.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.crypt_label.Location = new System.Drawing.Point(459, 17);
            this.crypt_label.Name = "crypt_label";
            this.crypt_label.Size = new System.Drawing.Size(0, 17);
            this.crypt_label.TabIndex = 4;
            // 
            // decypher
            // 
            this.decypher.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decypher.Location = new System.Drawing.Point(293, 11);
            this.decypher.Name = "decypher";
            this.decypher.Size = new System.Drawing.Size(99, 23);
            this.decypher.TabIndex = 1;
            this.decypher.Text = " Расшифровать";
            this.decypher.UseVisualStyleBackColor = true;
            this.decypher.Click += new System.EventHandler(this.decypher_Click);
            // 
            // cypher
            // 
            this.cypher.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cypher.Location = new System.Drawing.Point(194, 11);
            this.cypher.Name = "cypher";
            this.cypher.Size = new System.Drawing.Size(93, 23);
            this.cypher.TabIndex = 0;
            this.cypher.Text = " Зашифровать";
            this.cypher.UseVisualStyleBackColor = true;
            this.cypher.Click += new System.EventHandler(this.cypher_Click);
            // 
            // exchange
            // 
            this.exchange.Location = new System.Drawing.Point(462, 169);
            this.exchange.Name = "exchange";
            this.exchange.Size = new System.Drawing.Size(32, 33);
            this.exchange.TabIndex = 5;
            this.exchange.Text = "<--";
            this.exchange.UseVisualStyleBackColor = true;
            this.exchange.Click += new System.EventHandler(this.exchange_Click);
            // 
            // state_standard_button
            // 
            this.state_standard_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.state_standard_button.Location = new System.Drawing.Point(3, 1171);
            this.state_standard_button.Name = "state_standard_button";
            this.state_standard_button.Size = new System.Drawing.Size(133, 67);
            this.state_standard_button.TabIndex = 15;
            this.state_standard_button.Text = "ГОСТ 28147-89";
            this.state_standard_button.UseVisualStyleBackColor = true;
            this.state_standard_button.Click += new System.EventHandler(this.state_standard_button_Click);
            // 
            // Kazakevich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(812, 484);
            this.Controls.Add(this.exchange);
            this.Controls.Add(this.panel_each);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Kazakevich";
            this.Text = "Form1";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel_each.ResumeLayout(false);
            this.panel_each.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button atbash_button;
        private System.Windows.Forms.Button skytala_button;
        private System.Windows.Forms.Button caesar_button;
        private System.Windows.Forms.Button polybius_button;
        private System.Windows.Forms.Button decypher;
        private System.Windows.Forms.Button cypher;
        private System.Windows.Forms.Button alberti_button;
        private System.Windows.Forms.Button exchange;
        private System.Windows.Forms.Button gronsfeild_button;
        private System.Windows.Forms.Button vigenere_button;
        private System.Windows.Forms.Button cardan_button;
        private System.Windows.Forms.Button richelieu_button;
        private System.Windows.Forms.Button playfair_button;
        private System.Windows.Forms.Button vername_button;
        private System.Windows.Forms.Button des_button;
        private System.Windows.Forms.Button xor_cipher_button;
        public System.Windows.Forms.Panel panel_each;
        private System.Windows.Forms.Label crypt_label;
        private System.Windows.Forms.Button hill_button;
        private System.Windows.Forms.Button freq_button;
        private System.Windows.Forms.Button polyalph_button;
        private System.Windows.Forms.Button state_standard_button;
    }
}


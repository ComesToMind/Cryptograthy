namespace Cryptograthy
{
    partial class Form1
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.alberti_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_each = new System.Windows.Forms.Panel();
            this.decypher = new System.Windows.Forms.Button();
            this.cypher = new System.Windows.Forms.Button();
            this.exchange = new System.Windows.Forms.Button();
            this.gronsfeild_button = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.alberti_button);
            this.flowLayoutPanel2.Controls.Add(this.gronsfeild_button);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(149, 484);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // atbash_button
            // 
            this.atbash_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.skytala_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.caesar_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.polybius_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polybius_button.Location = new System.Drawing.Point(3, 222);
            this.polybius_button.Name = "polybius_button";
            this.polybius_button.Size = new System.Drawing.Size(133, 67);
            this.polybius_button.TabIndex = 0;
            this.polybius_button.Text = "Квадрат Полибия";
            this.polybius_button.UseVisualStyleBackColor = true;
            this.polybius_button.Click += new System.EventHandler(this.polybius_button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(3, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 67);
            this.button5.TabIndex = 0;
            this.button5.Text = "Шифр Кардано";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(3, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 67);
            this.button6.TabIndex = 0;
            this.button6.Text = "Шифр Ришелье";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // alberti_button
            // 
            this.alberti_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alberti_button.Location = new System.Drawing.Point(3, 441);
            this.alberti_button.Name = "alberti_button";
            this.alberti_button.Size = new System.Drawing.Size(133, 67);
            this.alberti_button.TabIndex = 1;
            this.alberti_button.Text = "Диск Альберти";
            this.alberti_button.UseVisualStyleBackColor = true;
            this.alberti_button.Click += new System.EventHandler(this.alberti_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 257);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(497, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 257);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(583, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Зашифрованный текст";
            // 
            // panel_each
            // 
            this.panel_each.Controls.Add(this.decypher);
            this.panel_each.Controls.Add(this.cypher);
            this.panel_each.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_each.Location = new System.Drawing.Point(187, 328);
            this.panel_each.Name = "panel_each";
            this.panel_each.Size = new System.Drawing.Size(583, 144);
            this.panel_each.TabIndex = 4;
            this.panel_each.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_each_Paint);
            // 
            // decypher
            // 
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
            this.cypher.Location = new System.Drawing.Point(199, 11);
            this.cypher.Name = "cypher";
            this.cypher.Size = new System.Drawing.Size(88, 23);
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
            // gronsfeild_button
            // 
            this.gronsfeild_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gronsfeild_button.Location = new System.Drawing.Point(3, 514);
            this.gronsfeild_button.Name = "gronsfeild_button";
            this.gronsfeild_button.Size = new System.Drawing.Size(133, 67);
            this.gronsfeild_button.TabIndex = 4;
            this.gronsfeild_button.Text = "Шифр Гронсфелда";
            this.gronsfeild_button.UseVisualStyleBackColor = true;
            this.gronsfeild_button.Click += new System.EventHandler(this.gronsfeild_button_Click);
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel_each.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_each;
        private System.Windows.Forms.Button atbash_button;
        private System.Windows.Forms.Button skytala_button;
        private System.Windows.Forms.Button caesar_button;
        private System.Windows.Forms.Button polybius_button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button decypher;
        private System.Windows.Forms.Button cypher;
        private System.Windows.Forms.Button alberti_button;
        private System.Windows.Forms.Button exchange;
        private System.Windows.Forms.Button gronsfeild_button;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using static Cryptograthy.Innitial;

namespace Cryptograthy
{
    public partial class Kazakevich : Form
    {
        public Kazakevich()
        {
            InitializeComponent();
        }
        //обернуть в класс
        string rus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string RUS = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string eng = "abcdefghijklmnopqrstuvwxyz";
        string ENG = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        
        
        List<Control> controls = new List<Control>();
        Button PressedButt;
        public enum Kind { ENCRYPT, DECRYPT };
        TextBox tb;
        ///=====
        private void ClearPanel()
        {
            if (controls.Any())
            {
                foreach (Control ctrl in controls)// подписываем каждый элемент списка на клик
                    panel_each.Controls.Remove(ctrl);
                controls.Clear();
            }

        }

        private void InitialazePanel()
        {
            foreach (Control ctrl in controls)// подписываем каждый элемент списка на клик
                panel_each.Controls.Add(ctrl);
        }
        //============

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textBox2.Text = e.KeyChar.ToString();

            if (!Char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
        private void tb_RechelieuPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 32 && number != 40 && number != 41 && number != 44 && number!=8)
            {
                e.Handled = true;
            }
        }



        private void atbash_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            
        }


        private void cypher_Click(object sender, EventArgs e)
        {

            //ШИФРОВКА
            if (PressedButt == atbash_button)
            {
                Atbash();
            }
            else if (PressedButt == skytala_button)
            {
                Skytala(Kind.ENCRYPT);
            }
            else if (PressedButt == caesar_button)
            {
                Caesar(Kind.ENCRYPT);
            }
            else if (PressedButt == polybius_button)
            {
                Polybius();
            }
            else if (PressedButt == alberti_button)
            {
                Alberti_s_disk();
            }
            else if (PressedButt == gronsfeild_button)
            {
                Gronsfield(Kind.ENCRYPT);
            }
            else if (PressedButt == vigenere_button)
            {
                Vigenere(Kind.ENCRYPT);
            }
            else if (PressedButt == playfair_button)
            {
                Playfair();
            }
            else if (PressedButt == cardan_button)
            {
                CardanEncrypt();
            }
            else if (PressedButt == richelieu_button)
            {
                RichelieuEncrypt();
            }
            else if (PressedButt == vername_button)
            {
                Vername();
            }
            //ШИФРОВКА
        }

        private void decypher_Click(object sender, EventArgs e)
        {
            //РАСШИФРОВКА
            if (PressedButt == atbash_button)
            {
                Atbash();
            }
            else if (PressedButt == skytala_button)
            {
                Skytala(Kind.DECRYPT);
            }
            else if (PressedButt == caesar_button)
            {
                Caesar(Kind.DECRYPT);
            }
            else if (PressedButt == polybius_button)
            {
                dePolybius();
            }
            else if (PressedButt == alberti_button)
            {
                deAlberti_s_disk();
            }
            else if (PressedButt == gronsfeild_button)
            {
                Gronsfield(Kind.DECRYPT);
            }
            else if (PressedButt == vigenere_button)
            {
                Vigenere(Kind.DECRYPT);
            }
            else if (PressedButt == playfair_button)
            {
                PlayfairDecrypt();
            }
            else if (PressedButt == cardan_button)
            {
                CardanDecrypt();
            }
            else if (PressedButt == richelieu_button)
            {
                RichelieuDecrypt();
            }
            else if (PressedButt == vername_button)
            {
                Vername();
            }
            
            //РАСШИФРОВКА
        }

        private void skytala_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(21, 16);
            lb.Text = "Количество строк";
            lb.Size = new Size(98, 13);

             tb = new TextBox();
            tb.Location = new Point(125, 13);
            tb.Size = new Size(58, 21);
            tb.KeyPress += tb_KeyPress;
            
            //ComboBox cb = new ComboBox();
            //cb.Location = new Point(125, 13);
            //cb.Size = new Size(58, 21);
            //cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //запрет на ввод 
            //for (int i = 1; i < 34; i++)
            //{
            //    cb.Items.Add(i);
            //}
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
           


        }

        private void caesar_button_Click(object sender, EventArgs e)
        {
            PressedButt = sender as Button;
            ClearPanel();
            Label lb = new Label();
            lb.Location = new Point(56, 16);
            lb.Text = "Ключ";
            lb.Size = new Size(35, 13);
            ComboBox cb = new ComboBox();
            cb.Location = new Point(107, 13);
            cb.Size = new Size(50, 13);
            cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //запрет на ввод 
            for (int i = 1; i < 67; i++)
            {
                cb.Items.Add(i);
            }
            controls.Add(lb);
            controls.Add(cb);
            InitialazePanel();


        }

        private void polybius_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Кодовое слово: ";
            lb.Size = new Size(98, 13);

            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(85, 21);
            //можно сделать проверку на символы 
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();

        }

        private void alberti_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);

            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(45, 21);
            tb.KeyPress += tb_KeyPress;
            //можно сделать проверку на символы 
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();

        }

        private void exchange_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = textBox2.Text;
        }

        private void panel_each_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gronsfeild_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);
                        

            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(45, 21);
            tb.KeyPress += tb_KeyPress;
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
        }

        private void vigenere_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);


            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(60, 21);
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
        }

        private void playfair_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);


            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(60, 21);
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
        }

        private void cardan_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            InitialazePanel();
        }

        private void richelieu_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 55);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);


            tb = new TextBox();
            tb.Location = new Point(105, 50);
            tb.Size = new Size(300, 21);
            tb.KeyPress += tb_RechelieuPress;
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
        }

        private void vername_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 55);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);


            tb = new TextBox();
            tb.Location = new Point(105, 50);
            tb.Size = new Size(300, 21);
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
        }
    }
}

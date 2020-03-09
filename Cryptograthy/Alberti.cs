using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cryptograthy

{
    partial class Form1
    {
        string alberti_rus = "ябгведёлмнктрошщсыюпйцичзажуфъьэх";
        string alberti_eng = "qefsxckhlandjoprvbtyiugwzm";
        public void Alberti_s_disk()
        {
            char[] first_data = textBox1.Text.ToCharArray();
            int innitilaKey = 0, moveKey = 0;
            //считать ключ
            foreach (Control ctrl in controls)// подписываем каждый элемент списка на 
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    TextBox cmb = (TextBox)ctrl;
                    if (cmb.Text != null && !cmb.Text.Equals(""))
                    {
                        innitilaKey = int.Parse(cmb.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }
            moveKey += innitilaKey;
            bool UP = false;

            for (int k = 0; k < first_data.Length; k++)
            {
         
                UP = false;
                if (Char.IsUpper(first_data[k]))
                {
                    first_data[k] = Char.ToLower(first_data[k]);
                    UP = true;
                }

                for (int i = 0; i < rus.Length; i++)
                {
                    if (first_data[k] == rus[i])
                    {
                        first_data[k] = alberti_rus[(i + moveKey)% 33];
                        //сдвигаем внутренний круг на один 
                        moveKey += 1;
                        goto Find;
                    }

                }
                for (int i = 0; i < eng.Length; i++)
                {
                    if (first_data[k] == eng[i])
                    {
                        first_data[k] = alberti_eng[(i + moveKey)% 26];
                        //сдвигаем внутренний круг на один 
                        moveKey += 1;
                        goto Find;
                    }


                }

            Find:
                if (UP)
                {
                    first_data[k] = Char.ToUpper(first_data[k]);
                }
            

            }
            textBox2.Text = new string(first_data);


        

        }

        public void deAlberti_s_disk()
        {
            //ДЕШИФРОВКА
            char[] first_data = textBox1.Text.ToCharArray();
            int innitilaKey = 0, moveKey = 0;
            //считать ключ
            foreach (Control ctrl in controls)// подписываем каждый элемент списка на 
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    TextBox cmb = (TextBox)ctrl;
                    if (cmb.Text != null && !cmb.Text.Equals(""))
                    {
                        innitilaKey = int.Parse(cmb.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }
            moveKey += innitilaKey;
            bool UP = false;
            // char smb = ' ';
            for (int k = 0; k < first_data.Length; k++)
            {
                //smb = first_data[k];
                UP = false;
                if (Char.IsUpper(first_data[k]))
                {
                    first_data[k] = Char.ToLower(first_data[k]);
                    UP = true;
                }

                for (int i = 0; i < rus.Length; i++)
                {
                    if (first_data[k] == alberti_rus[i])
                    {
                        first_data[k] = rus[Math.Abs(i - moveKey) % 33];
                        //сдвигаем внутренний круг на один 
                        moveKey += 1;
                        goto Find;
                    }

                }
                for (int i = 0; i < eng.Length; i++)
                {
                    if (first_data[k] == alberti_eng[i])
                    {
                        first_data[k] = eng[Math.Abs(i - moveKey) % 26];
                        //сдвигаем внутренний круг на один 
                        moveKey += 1;
                        goto Find;
                    }


                }

            Find:
                if (UP)
                {
                    first_data[k] = Char.ToUpper(first_data[k]);
                }


            }
            textBox2.Text = new string(first_data);




        }
    }

}

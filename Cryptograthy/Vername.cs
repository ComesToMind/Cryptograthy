using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cryptograthy
{
    partial class Kazakevich
    {
        public void Vername()
        {
            //функция шифрования и расшифрования
            char[] first_data = textBox1.Text.ToCharArray();
            char[] flagInit = null;
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    TextBox cmb = (TextBox)ctrl;
                    if (cmb.Text != null && !cmb.Text.Equals(""))
                    {
                        flagInit = cmb.Text.ToCharArray();
                        if (flagInit.Length != first_data.Length)
                        {
                            MessageBox.Show("Размер ключа не подходит размеру текста", "Некорректные данные");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }
            for (int i = 0; i < first_data.Length; i++)
            {
                int rus_sym = rus.IndexOf(Char.ToLower(first_data[i]));
                int rus_fl = rus.IndexOf(Char.ToLower(flagInit[i]));
                int eng_sym = eng.IndexOf(Char.ToLower(first_data[i]));
                int eng_fl = eng.IndexOf(Char.ToLower(flagInit[i]));
                if (rus_sym != -1 && rus_fl != -1)
                {
                    first_data[i] = rus[(rus_sym^rus_fl)%rus.Length]; //XOR 
                }
                else
                {
                    if (eng_sym != -1 && eng_fl != -1)
                    {
                        first_data[i] = eng[(eng_sym ^ eng_fl) % eng.Length];//XOR
                    }
                    else
                    {
                        MessageBox.Show("Несовпадение букв ключа и текста", "Некорректные данные");
                        return;
                    }
                }
                
               
            }

            textBox2.Text = new string(first_data);

        }
    }
}

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
        TextBox cmb;
        //функция шифрования
        public void RichelieuEncrypt()
        {

            char[] first_data = textBox1.Text.ToCharArray();
            string flag = null;
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    cmb = (TextBox)ctrl;
                    if (cmb.Text != null && !cmb.Text.Equals(""))
                    {
                        //функция проверки на ключ 
                        flag = cmb.Text.ToString();
                        flag = flag.Replace(" ", "");
                    }
                    else
                    {
                        MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }

            List<int[]> Key = new List<int[]>();
            if (!CreateKey(first_data.Length, flag, ref Key))
            {
                return;
            }
            char[] second_data = new char[first_data.Length];
            Array.Copy(first_data, second_data, first_data.Length);
            int index = 0, offset = 0;
            foreach (var a in Key)
            {
                foreach (var b in a)
                {
                    second_data[index] = first_data[b-1+offset];
                    index++;
                }
                offset = index;
            }
            textBox2.Text = new string(second_data);
        }
        //функция расшифрования
        public void RichelieuDecrypt()
        {
            char[] first_data = textBox1.Text.ToCharArray();
            string flag = null;
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    TextBox cmb = (TextBox)ctrl;
                    if (cmb.Text != null && !cmb.Text.Equals(""))
                    {
                        //функция проверки на ключ 
                        flag = cmb.Text.ToString();
                        flag = flag.Replace(" ", "");
                    }
                    else
                    {
                        MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }
            }
            List<int[]> Key = new List<int[]>();
            if (!CreateKey(first_data.Length, flag, ref Key))
            {
                return;
            }
            char[] second_data = new char[first_data.Length];
            Array.Copy(first_data, second_data, first_data.Length);
            int index = 0, offset = 0;
            foreach (var a in Key)
            {
                foreach (var b in a)
                {
                    second_data[b - 1 + offset] = first_data[index];
                    index++;
                }
                offset = index;
            }
            textBox2.Text = new string(second_data);

        }

        //формируем ключ
        private bool CreateKey(int Text_Len, string Key, ref List<int[]> New_Key)
        {
            //простейщая проверка на формат "(... ... ...)"
            if (Key.First() != '(')
            {
                MessageBox.Show("Ключь должен начинаться с символа \"(\"!", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Key.Last() != ')')
            {
                MessageBox.Show("Ключь должен заканчиваться символом \")\"!", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int control_len = 0;
            for (int i = 0; i < Key.Length; i++)
            {
                int index = 0;
                switch (Key[i])
                {
                    case '(':
                        i++;
                        if (!Char.IsDigit(Key[i]))
                        {
                            MessageBox.Show("Неверно задан ключ!", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        int[] innitialMass = new int[1];
                        while (Key[i] != ')')
                        {
                            string temp = null;
                            while (Char.IsDigit(Key[i]))
                            {
                                //формируем цифры ключа, потом переведм в int 
                                temp += Key[i];
                                i++;
                            }
                            // ,) or ..()
                            if ((Key[i] == ',' && (Key[i + 1] == ')' || Key[i + 1] == '(')) || (Key[i] == '('))
                            {
                                MessageBox.Show("Неверно задан ключ!", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            innitialMass[index] = int.Parse(temp);
                            control_len++;
                            if (Key[i] == ')')
                            {
                                break;
                            }
                            else
                            {
                                i++;
                                if (Key[i] == '(')
                                {
                                    MessageBox.Show("Неверно задан ключ!", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                                index++;
                                Array.Resize(ref innitialMass, innitialMass.Length + 1);
                            }
                        }

                        if (control_len > Text_Len)
                        {
                            MessageBox.Show("Неверно задан ключ! Слишком большая длина ключа.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        int[] checkMass = new int[innitialMass.Length];
                        innitialMass.CopyTo(checkMass, 0);
                        if (!Check(checkMass))
                        {
                            return false;
                        }
                        else
                        {
                            New_Key.Add(innitialMass);
                        }
                        break;
                    default:
                        MessageBox.Show("Неверно задан ключ!", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                }
            }
            return true;
        }
        //вспомогательаня функция
        //на проверку уже самих чисел в ключе
        private bool Check(int[] Mass)
        {
            Array.Sort(Mass);
            if (Mass.First() == 0 || Mass.First() != 1 || Mass.Last() != Mass.Length || Mass.Length < Mass.Last())
            {
                MessageBox.Show("Неверно задан ключ!", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 1; i <= Mass.Length; i++)
            {
                int check = 0;
                for (int j = 0; j < Mass.Length; j++)
                {
                    //првоеряем, есть ли цифра от 1 до длины ключа в нём самом, если нет или их больше
                    //то ключ неверный
                    if (Mass[j] == i)
                    {
                        check++;
                    }
                }
                if (check == 0 || check > 1)
                {
                    MessageBox.Show("Неверно задан ключ!", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

    }
}

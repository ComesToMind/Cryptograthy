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
        public void Polybius()
        {
            char[] first_data = textBox1.Text.ToCharArray();
            char[] r = rus.ToCharArray();
            char[] e = eng.ToCharArray();
            //функция добавления флага в алфавит
            FlagAlphabet(ref r, ref e);
            bool UP = false;
            char smb = ' ';
            for (int k = 0; k < first_data.Length; k++)
            {
                smb = first_data[k];
                UP = false;
                if (Char.IsUpper(first_data[k]))
                {
                    first_data[k] = Char.ToLower(first_data[k]);
                    UP = true;
                }

                for (int i = 0; i < r.Length; i++)
                {
                    if (first_data[k] == r[i])
                    {
                        if (i < 27)
                        {
                            smb = r[i + 6];
                            goto Find;
                        }
                        else
                        {
                            smb = r[0 + i % 6];
                            goto Find;
                        }
                    }


                }
                for (int i = 0; i < eng.Length; i++)
                {
                    if (first_data[k] == e[i])
                    {
                        if (i < 20)
                        {
                            smb = e[i + 6];
                            goto Find;
                        }
                        else
                        {
                            smb = e[0 + i % 6];
                            goto Find;
                        }
                    }


                }

            Find:
                if (UP)
                {
                    first_data[k] = Char.ToUpper(smb);
                }
                else
                {
                    first_data[k] = smb;
                }


            }
            textBox2.Text = new string(first_data);


        }
        public void dePolybius()
        {
            char[] first_data = textBox1.Text.ToCharArray();
            char[] r = rus.ToCharArray();
            char[] e = eng.ToCharArray();
            //функция добавления флага в алфавит
            FlagAlphabet(ref r, ref e);
            bool UP = false;
            char smb = ' ';
            for (int k = 0; k < first_data.Length; k++)
            {
                smb = first_data[k];
                UP = false;
                if (Char.IsUpper(first_data[k]))
                {
                    first_data[k] = Char.ToLower(first_data[k]);
                    UP = true;
                }

                for (int i = 0; i < r.Length; i++)
                {
                    if (first_data[k] == r[i])
                    {
                        if (i >= 6)
                        {
                            smb = r[i - 6];
                            goto Find;
                        }
                        else
                        {
                            if (i >= 0 && i < 3)
                            {
                                //буквы АБВ
                                smb = r[30 + i];
                                goto Find;
                            }
                            else if (i >= 3 && i < 6)
                            {
                                smb = r[24 + i];
                                goto Find;
                            }
                        }
                    }


                }
                for (int i = 0; i < e.Length; i++)
                {
                    if (first_data[k] == e[i])
                    {
                        if (i >= 6)
                        {
                            smb = e[i - 6];
                            goto Find;
                        }
                        else
                        {
                            if (i >= 0 && i < 2)
                            {
                                smb = e[24 + i];
                                goto Find;
                            }
                            else if (i >= 2 && i < 6)
                            {
                                smb = e[18 + i];
                                goto Find;

                            }
                        }
                    }


                }

            Find:
                if (UP)
                {
                    first_data[k] = Char.ToUpper(smb);
                }
                else
                {
                    first_data[k] = smb;
                }


            }
            textBox2.Text = new string(first_data);
        }

        public void FlagAlphabet(ref char[] r, ref char[] e)
        {
            char[] flagInit = null;
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    TextBox cmb = (TextBox)ctrl;
                    if (cmb.Text != null && !cmb.Text.Equals(""))
                    {
                        flagInit = cmb.Text.ToCharArray();
                    }
                    else
                    {
                        //MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }
            List<char> flagList = new List<char>();


            bool findSymb;
            for (int i = 0; i < flagInit.Length; i++)
            {
                findSymb = false;
                foreach (char var in flagList)
                {
                    if (var == flagInit[i])
                    {
                        findSymb = true;
                    }
                }
                if (!findSymb)
                {
                    flagList.Add(flagInit[i]);
                }
            }
            char[] flag = flagList.ToArray();

            int r_counter = 0, e_counter = 0; //количество добавленных букв в начало алфавита
            for (int k = 0; k < flag.Length; k++)
            {

                if (Char.IsUpper(flag[k]))
                {
                    flag[k] = Char.ToLower(flag[k]);
                }

                for (int i = 0; i < rus.Length; i++)
                {
                    if (flag[k] == rus[i])
                    {
                        r[r_counter] = flag[k];
                        r_counter++;
                        break;

                    }
                }
                for (int i = 0; i < eng.Length; i++)
                {
                    if (flag[k] == eng[i])
                    {
                        e[e_counter] = flag[k];
                        e_counter++;
                        break;
                    }
                }
            }

            int counter = r_counter;
            bool fl;
            foreach (char var in rus)
            {
                fl = false;
                for (int i = 0; i < r_counter; i++)
                {
                    if (r[i] == var)//буква алфавита есть в ключе, то 
                    {
                        fl = true; //
                        break;
                    }

                }
                if (!fl)
                {
                    r[counter] = var;
                    counter++;
                }

            }
            counter = e_counter;
            foreach (char var in eng)
            {
                fl = false;
                for (int i = 0; i < e_counter; i++)
                {
                    if (e[i] == var)
                    {
                        fl = true;
                        break;
                    }

                }
                if (!fl)
                {
                    e[counter] = var;
                    counter++;
                }

            }

        }
    }
}

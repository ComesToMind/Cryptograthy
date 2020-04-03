using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptograthy
{
    partial class Kazakevich
    {
        public void Atbash()
        {
            char[] first_data = textBox1.Text.ToCharArray();
            bool keyLow, keyUp;
            for (int i = 0; i < first_data.Length; i++)
            {
                keyLow = keyUp = true;
                if (char.IsUpper(first_data[i]))
                {
                    for (int j = 0; (j < 33); j++)
                    {
                        if (first_data[i] == RUS[j])
                        {
                            first_data[i] = RUS[32 - j];
                            keyUp = false;
                            break;
                        }

                    }
                    if (keyUp)
                    {
                        for (int j = 0; (j < 26); j++)
                        {
                            if (first_data[i] == ENG[j])
                            {
                                first_data[i] = ENG[25 - j];
                                keyLow = false;
                                break;
                            }

                        }
                    }

                }

                if (keyUp)
                {
                    for (int j = 0; j < 26; j++)
                    {
                        if (first_data[i] == eng[j])
                        {
                            first_data[i] = eng[25 - j];
                            keyLow = false;
                            break;
                        }

                    }
                    if (keyLow)
                    {
                        for (int j = 0; j < 33; j++)
                        {
                            if (first_data[i] == rus[j])
                            {
                                first_data[i] = rus[32 - j];
                                break;
                            }

                        }
                    }


                }
            }

            textBox2.Text = new string(first_data);

        }

    }
}

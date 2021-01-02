using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;


namespace Cryptograthy
{
    public partial class StateStandard : Form
    {
        public StateStandard()
        {
            InitializeComponent();
            crypt_file_button.Enabled = false;
            decrypt_file_button.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            usual_mode_butt.Select();
        }
        static string synchr = "DESkey28";
        byte[] CO_CBC = Encoding.ASCII.GetBytes(synchr); //синхропосылка 

        int[,] S_Box = { { 12, 4, 6, 2, 10, 5, 11, 9, 14, 8, 13, 7, 0, 3, 15, 1 },
                         { 6, 8, 2, 3, 9, 10, 5, 12, 1, 14, 4, 7, 11, 13, 0, 15 },
                         { 11, 3, 5, 8, 2, 15, 10, 13, 14, 1, 7, 4, 12, 9, 6, 0 },
                         { 12, 8, 2, 1, 13, 4, 15, 6, 7, 0, 10, 5, 3, 14, 9, 11 },
                         { 7, 15, 5, 10, 8, 1, 6, 13, 0, 9, 3, 14, 11, 4, 2, 12 },
                         { 5, 13, 15, 6, 9, 2, 12, 10, 11, 7, 8, 1, 4, 3, 14, 0 },
                         { 8, 14, 2, 5, 6, 9, 1, 12, 15, 4, 11, 0, 13, 10, 3, 7 },
                         { 1, 7, 14, 13, 0, 5, 8, 3, 4, 15, 10, 6, 9, 12, 11, 2 } };

        ///РЕАЛИЗОВАТЬ РЕЖИМ ПРОСТОЙ ЗАМЕНЫ И ГАММИРОВАНИЕ С ОБРАТНОЙ СВЯЗЬЮ 
        ///---------------------------
        //сразу перменная под 16 раундовых ключей
        BitArray[] Keys = new BitArray[16];
        //BitArray Key;
        LinkedList<byte> textB2Helper;
        byte[][] Key = new byte[8][];

        //C0 для CBC 
        //string strkey = "DESkey2";


        //BitArray Key = new BitArray(Encoding.ASCII.GetBytes(strkey.ToCharArray()));
        //static string strkey = "DESkey2";
        //static int[] myInts = new int[2] { 2147455533, 2132343564 };

        public void SetEnable(bool f)
        {
            crypt_file_button.Enabled = decrypt_file_button.Enabled = button1.Enabled =
                button2.Enabled = button3.Enabled = groupBox1.Enabled = generate_key_button.Enabled = paste_key_button.Enabled = write_key_button.Enabled = read_key_button.Enabled = f;
        }

        private async void crypt_file_button_Click(object sender, EventArgs e)
        {
            //зашифрованный текст по  битам храним в листе
            LinkedList<byte> EncryptedData;
            OpenFileDialog read = new OpenFileDialog();
            //читаем бинарно файл
            bool flagBad = false;
            if (read.ShowDialog() == DialogResult.OK)
            {


                label1.Text = "";
                label1.Update();
                FileInfo InfFile = new FileInfo(read.FileName);

                pb.Maximum = Convert.ToInt32(InfFile.Length / 8) + 8;
                pb.Value = 0;


                BinaryReader reader = new BinaryReader(File.Open(read.FileName, FileMode.Open),
                                                                                Encoding.Default);
                byte[] OTextL = new byte[4];
                byte[] OTextR = new byte[4];
                byte[] EncryptText = new byte[8];

                EncryptedData = new LinkedList<byte>();
                SetEnable(false);

                CO_CBC = Encoding.ASCII.GetBytes(synchr); //синхропосылка 
                await Task.Run(() =>
                {
                    try
                    {
                        //можно попробовать считывать сразу по 4ре байта и проверить
                        // как это скажется на взаимодействии
                        for (long block = 0; block < (InfFile.Length / 8); block++)
                        {

                            OTextL = reader.ReadBytes(4);
                            OTextR = reader.ReadBytes(4);
                            if (usual_mode_butt.Checked)
                                EncryptText = Feistel(OTextL, OTextR);
                            else
                                EncryptText = CFB(OTextL, OTextR, 'E');
                            for (int i = 0; i < 8; i++)
                            {
                                EncryptedData.AddLast(EncryptText[i]);
                            }
                            this.Invoke(new Action(() => pb.Value++));

                        }
                        LinkedList<byte> LastBlock = new LinkedList<byte>();
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            LastBlock.AddLast(reader.ReadByte());
                        }
                        LastBlock.AddLast(0x80);
                        while (LastBlock.Count != 8)
                        {
                            LastBlock.AddLast(0x00);
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            OTextL[i] = LastBlock.ElementAt(i);
                            OTextR[i] = LastBlock.ElementAt(i + 4);
                        }
                        LastBlock.Clear();

                        if (usual_mode_butt.Checked)
                            EncryptText = Feistel(OTextL, OTextR);
                        else
                            EncryptText = CFB(OTextL, OTextR, 'E');

                        for (int i = 0; i < 8; i++)
                        {
                            EncryptedData.AddLast(EncryptText[i]);
                        }
                        this.Invoke(new Action(() => pb.Value++));
                    }
                    catch (Exception ex)
                    {

                        flagBad = true;
                    }


                });
                SetEnable(true);
                reader.Close();
                label1.Text = "Готово";
                pb.Value = 0;
                if (flagBad)
                    return;

                SaveFileDialog Save = new SaveFileDialog();
                if (Save.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = "Идёт запись в файл";
                    label1.Update();
                    pb.Value = 0;
                    pb.Maximum = EncryptedData.Count;
                    BinaryWriter writer = new BinaryWriter(File.Open(Save.FileName, FileMode.Create), Encoding.Default);
                    SetEnable(false);

                    await Task.Run(() =>
                    {
                        try
                        {
                            writer.Write(EncryptedData.ToArray(), 0, EncryptedData.Count);
                        }
                        catch (Exception ex)
                        {

                        }
                    });
                    SetEnable(true);
                    writer.Close();
                    pb.Value = 0;
                    label1.Text = "Готово";

                }
            }
        }

        private async void decrypt_file_button_Click(object sender, EventArgs e)
        {
            //зашифрованный текст по  битам храним в листе
            LinkedList<byte> DecryptedData = new LinkedList<byte>();
            //читаем бинарно файл
            OpenFileDialog read = new OpenFileDialog();
            //FileInfo InfFile = new FileInfo(read.FileName);
            if (read.ShowDialog() == DialogResult.OK)
            {
                label1.Text = "";
                label1.Update();
                FileInfo InfFile = new FileInfo(read.FileName);

                pb.Maximum = Convert.ToInt32(InfFile.Length / 8) + 1;
                pb.Value = 0;
                BinaryReader reader = new BinaryReader(File.Open(read.FileName, FileMode.Open),
                                                                          Encoding.Default);
                byte[] EncryptTextL = new byte[4];
                byte[] EncryptTextR = new byte[4];
                byte[] DecryptDataBlock = new byte[8]; //64 бита
                bool flagBad = false;
                SetEnable(false);
                CO_CBC = Encoding.ASCII.GetBytes(synchr); //синхропосылка 
                await Task.Run(() =>
                {
                    try
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            EncryptTextL = reader.ReadBytes(4);
                            EncryptTextR = reader.ReadBytes(4);
                            if (usual_mode_butt.Checked)
                                DecryptDataBlock = ReverseFeistel(EncryptTextL, EncryptTextR);
                            else
                                DecryptDataBlock = CFB(EncryptTextL, EncryptTextR, 'D');

                            for (int i = 0; i < 8; i++)
                            {
                                DecryptedData.AddLast(DecryptDataBlock[i]);
                            }
                            this.Invoke(new Action(() => pb.Value++));

                        }

                        for (int i = 0; i < 8; i++)
                        {
                            if (DecryptedData.Last() == 0x80)
                            {
                                DecryptedData.RemoveLast();
                                break;
                            }
                            if (DecryptedData.Last() == 0x00)
                            {
                                DecryptedData.RemoveLast();
                                continue;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        flagBad = true;
                    }
                });
                label1.Text = "Готово";
                reader.Close();
                pb.Value = 0;
                if (flagBad)
                    return;
                SetEnable(true);

                SaveFileDialog Save = new SaveFileDialog();
                if (Save.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = "";
                    label1.Update();
                    pb.Value = 0;
                    pb.Maximum = DecryptedData.Count;
                    BinaryWriter writer = new BinaryWriter(File.Open(Save.FileName, FileMode.Create), Encoding.Default);
                    SetEnable(false);

                    await Task.Run(() =>
                    {
                        try
                        {
                            writer.Write(DecryptedData.ToArray(), 0, DecryptedData.Count);

                        }
                        catch (Exception ex)
                        {

                        }

                    });
                    SetEnable(true);

                    writer.Close();
                    pb.Value = 0;
                    label1.Text = "Готово";
                }
            }

        }

        private byte[] CFB(byte[] L0, byte[] R0, char mode)
        {
            if (mode == 'E')
            {
                //шифруем вектор инициализации
                byte[] CO_CBC1 = new byte[] { CO_CBC[0], CO_CBC[1], CO_CBC[2], CO_CBC[3] };
                byte[] CO_CBC2 = new byte[] { CO_CBC[4], CO_CBC[5], CO_CBC[6], CO_CBC[7] };
                var EncryptedDataBlock = Feistel(CO_CBC1, CO_CBC2);
                //скалдываем зашифр вектр с откр текстом
                for (int i = 0; i < 4; i++)
                {
                    EncryptedDataBlock[i] ^= L0[i];
                    EncryptedDataBlock[i+4] ^= R0[i];

                }
                Array.Copy(EncryptedDataBlock, CO_CBC, 8);
                return EncryptedDataBlock;
            }
            else
            {
                byte[] CO_CBC1 = new byte[] { CO_CBC[0], CO_CBC[1], CO_CBC[2], CO_CBC[3] };
                byte[] CO_CBC2 = new byte[] { CO_CBC[4], CO_CBC[5], CO_CBC[6], CO_CBC[7] };
                var EncryptedDataBlock = Feistel(CO_CBC1, CO_CBC2);
                //скалдываем зашифр вектр с откр текстом
                for (int i = 0; i < 4; i++)
                {
                    EncryptedDataBlock[i] ^= L0[i];
                    EncryptedDataBlock[i + 4] ^= R0[i];
                }
                Array.Copy(L0, 0, CO_CBC, 0, 4);
                Array.Copy(R0, 0, CO_CBC, 4, 4);
                return EncryptedDataBlock;
            }
        }

private byte[] Convert_Bits_To_Bites(BitArray IBitDataBlock)
        {
            //переводим обратно в LittleEndian для BitArray
            BitArray FinalCryptBitArray = new BitArray(64);
            int index = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    FinalCryptBitArray[index] = IBitDataBlock[i * 8 + j];
                    index++;
                }
            }
            byte[] bytes = new byte[8];
            FinalCryptBitArray.CopyTo(bytes, 0);
            return bytes;
        }
        private byte[] Feistel(byte[] L0, byte[] R0)
        {
            byte[] Li = new byte[4];
            byte[] Ri = new byte[4];
            byte[] Temp;


            for (int iteration = 0; iteration < 24; iteration++)
            {
                Temp = f(R0, (iteration % 8));
                for (int i = 0; i < 4; i++)
                {
                    Ri[i] = Convert.ToByte(L0[i] ^ Temp[i]);
                }//Ri = L0.Xor(f(ref R0, (iteration % 8)));
                R0.CopyTo(Li, 0);
                Li.CopyTo(L0, 0);
                Ri.CopyTo(R0, 0);
            }

            for (int iteration = 24; iteration < 31; iteration++)
            {
                Temp = f(R0, (31 - iteration));
                for (int i = 0; i < 4; i++)
                {
                    Ri[i] = Convert.ToByte(L0[i] ^ Temp[i]);
                }//Ri = L0.Xor(f(ref R0, (31 - iteration)));
                R0.CopyTo(Li, 0);
                Li.CopyTo(L0, 0);
                Ri.CopyTo(R0, 0);
            }

            R0.CopyTo(Ri, 0);
            Temp = f(R0, 0);
            for (int i = 0; i < 4; i++)
            {
                Li[i] = Convert.ToByte(L0[i] ^ Temp[i]);
            }//Li = L0.Xor(f(ref R0, 0));

            byte[] Result = new byte[8];
            for (int i = 0; i < 4; i++)
            {
                Result[i] = Li[i];
                Result[i + 4] = Ri[i];
            }
            return Result;
        }


        private byte[] ReverseFeistel(byte[] L32, byte[] R32)
        {
            byte[] Li = new byte[4];
            byte[] Ri = new byte[4];
            byte[] Temp;

            for (int iteration = 0; iteration < 8; iteration++)
            {
                Temp = f(R32, iteration);
                for (int i = 0; i < 4; i++)
                {
                    Ri[i] = Convert.ToByte(L32[i] ^ Temp[i]);
                }//Ri = L32.Xor(f(ref R32, iteration));
                R32.CopyTo(Li, 0);
                Li.CopyTo(L32, 0);
                Ri.CopyTo(R32, 0);
            }

            for (int iteration = 8; iteration < 31; iteration++)
            {
                Temp = f(R32, ((31 - iteration) % 8));
                for (int i = 0; i < 4; i++)
                {
                    Ri[i] = Convert.ToByte(L32[i] ^ Temp[i]);
                }//Ri = L32.Xor(f(ref R32, ((31 - iteration) % 8)));
                R32.CopyTo(Li, 0);
                Li.CopyTo(L32, 0);
                Ri.CopyTo(R32, 0);
            }

            R32.CopyTo(Ri, 0);
            Temp = f(R32, 0);
            for (int i = 0; i < 4; i++)
            {
                Li[i] = Convert.ToByte(L32[i] ^ Temp[i]);
            }//Li = L32.Xor(f(ref R32, 0));

            byte[] Result = new byte[8];
            for (int i = 0; i < 4; i++)
            {
                Result[i] = Li[i];
                Result[i + 4] = Ri[i];
            }
            return Result;
        }




        private byte[] f(byte[] R0, int number)
        {
            uint A = BitConverter.ToUInt32(R0.Reverse().ToArray(), 0);
            A += BitConverter.ToUInt32(Key[number].Reverse().ToArray(), 0);
            R0 = BitConverter.GetBytes(A);
            R0 = R0.Reverse().ToArray();

            BitArray Block_Bits = new BitArray(R0);
            BitArray New_Block_Bits = new BitArray(32);
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    New_Block_Bits[index] = Block_Bits[i * 8 + j];
                    index++;
                }
            }
            Block_Bits.SetAll(false);

            for (int cycle = 0; cycle < 8; cycle++)
            {
                string temp = null;
                for (int i = 0; i < 4; i++)
                {
                    temp += Convert.ToInt32(New_Block_Bits[cycle * 4 + i]);
                }
                int column = Convert_String_To_Int(temp);
                byte[] Binary_S_Box = Convert_Int_To_Bites(S_Box[cycle, column]);
                for (int i = 0; i < 4; i++)
                {
                    if (Binary_S_Box[i] == 1)
                    {
                        Block_Bits[cycle * 4 + i] = true;
                    }
                }
            }

            for (int cycle = 0; cycle < 11; cycle++)
            {
                bool temp = Block_Bits[0];
                for (int i = 0; i < 31; i++)
                {
                    Block_Bits[i] = Block_Bits[i + 1];
                }
                Block_Bits[31] = temp;
            }

            byte[] Out = Convert_BitArray_To_Byts(Block_Bits);
            return Out;
        }



        private static byte[] Convert_Int_To_Bites(int A)
        {
            byte[] binary = new byte[4];
            int index = 3;
            while (A > 0)
            {
                binary[index] = Convert.ToByte(A % 2);
                A /= 2;
                index--;
            }
            return binary;
        }


        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void write_key_button_Click(object sender, EventArgs e)
        {
            string pattern = @"[0-9A-F]{14}";
            if (Regex.IsMatch(keyTextBox.Text, pattern))
            {
                byte[] bytes = StringToByteArray(keyTextBox.Text);
                SaveFileDialog Save = new SaveFileDialog();
                if (Save.ShowDialog() == DialogResult.OK)
                {

                    BinaryWriter writer = new BinaryWriter(File.Open(Save.FileName, FileMode.Create), Encoding.Default);
                    foreach (var b in bytes)
                    {
                        writer.Write(b);
                    }
                    writer.Close();
                    label1.Text = "Готово";

                }

            }
            else
            {
                MessageBox.Show("Неправильный формат ключа", "Некорректные данные");
                return;
            }

        }


        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Скорость шифрования 31448 байт/с (Файл 1 Гб будет шифроваться 9 часов на процессоре i5-6200U 8Gb RAM!!!)\n" +
                            "2) Реализована асинхронность: Есть возможность свернуть программу в процессе шифрования\n" +
                            "3) При наведении на некоторые UI элементы есть подсказки!!!\n" +
                            "4) На конце убираются добавочные нули после дешифровки. Word открывается штатно!",
                "Руководство пользователя");

        }
        private static int Convert_String_To_Int(string bites)
        {
            int degree = bites.Length - 1;
            int result = 0;
            for (int i = 0; i < bites.Length; i++)
            {
                if (bites[i] == '1')
                {
                    result += Convert.ToInt32(Math.Pow(2, degree));
                }
                degree--;
            }

            return result;
        }

        private static byte[] Convert_BitArray_To_Byts(BitArray bits)
        {
            byte[] Result = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                int degree = 7;
                int sum = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (bits[i * 4 + j] == true)
                    {
                        sum += Convert.ToInt32(Math.Pow(2, degree));
                    }
                    degree--;
                }
                Result[i] = Convert.ToByte(sum);
            }
            return Result;
        }

        private void generate_key_button_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTimeOffset.Now.Millisecond);

            for (int i = 0; i < 8; i++)
            {
                Key[i] = new byte[4];
                rand.NextBytes(Key[i]);
            }
            keyTextBox.Clear();
            string KeyText = null;
            for (int i = 0; i < 8; i++)
            {

                keyTextBox.Text += BitConverter.ToString(Key[i]).Replace("-", "");
                
            }
            SetEnable(true);


        }

        private void paste_key_button_Click(object sender, EventArgs e)
        {
            if (keyTextBox.Text != null && !keyTextBox.Text.Equals(""))
            {
                if (keyTextBox.TextLength != 64)
                {
                    MessageBox.Show("Размер ключа должен быть равен 32", "Некорректные данные");
                    return;
                }
                string pattern = @"[0-9A-F]{64}";
                if (Regex.IsMatch(keyTextBox.Text, pattern))
                {
                    byte[] bytes = StringToByteArray(keyTextBox.Text);
                    for (int i = 0; i < 8; i++)
                    {
                        Key[i] = new byte[4];

                        for (int j = 0; j < 4; j++)
                        {
                            Key[i][j] = bytes[i * 4 + j];
                        }
                    }
                    SetEnable(true);
                }
                else
                {
                    MessageBox.Show("Неправильный формат ключа", "Некорректные данные");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                return;
            }

        }

        private void read_key_button_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                BinaryReader reader = new BinaryReader(File.Open(open.FileName, FileMode.Open),
                                                                          Encoding.Default);
                try
                {
                    for (int i = 0; i < 8; i++)
                    {
                        Key[i] = reader.ReadBytes(4);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ключ слишком корокткий или файл не существует", " Ошибка чтения ключа");
                    reader.Close();
                    return;
                }
                reader.Close();
                keyTextBox.Clear();
                for (int i = 0; i < 8; i++)
                {

                    keyTextBox.Text += BitConverter.ToString(Key[i]).Replace("-", "");

                }
                SetEnable(true);

            }
        }

        private void write_key_button_Click_1(object sender, EventArgs e)
        {
            string pattern = @"[0-9A-F]{64}";
            if (Regex.IsMatch(keyTextBox.Text, pattern))
            {
                byte[] bytes = StringToByteArray(keyTextBox.Text);
                SaveFileDialog Save = new SaveFileDialog();
                if (Save.ShowDialog() == DialogResult.OK)
                {

                    BinaryWriter writer = new BinaryWriter(File.Open(Save.FileName, FileMode.Create), Encoding.Default);
                    foreach (var b in bytes)
                    {
                        writer.Write(b);
                    }
                    writer.Close();
                    label1.Text = "Готово";

                }

            }
            else
            {
                MessageBox.Show("Неправильный формат ключа", "Некорректные данные");
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LinkedList<byte> EncryptedData = new LinkedList<byte>();

            char[] first_data = textBox1.Text.ToCharArray();
            byte[] bytes;
            if (first_data.Length % 8 != 0)
            {
                bytes = new byte[first_data.Length + (8 - first_data.Length % 8)];
                Array.Copy(Encoding.Default.GetBytes(first_data), bytes, first_data.Length);
            }
            else
            {
                bytes = Encoding.Default.GetBytes(first_data);
            }


            int place = 0;
            byte[] OpenTextL = new byte[4];
            byte[] OpenTextR = new byte[4];
            byte[] EncryptText = new byte[8];

            CO_CBC = Encoding.ASCII.GetBytes("DESkey28");
            while (place < bytes.Length)
            {
                Array.Copy(bytes, place, OpenTextL, 0, 4);
                place += 4;
                Array.Copy(bytes, place, OpenTextR, 0, 4);
                place += 4;

                if (usual_mode_butt.Checked)
                    EncryptText = Feistel(OpenTextL, OpenTextR);
                else
                    EncryptText = CFB(OpenTextL, OpenTextR, 'E');
                foreach (var b in EncryptText)
                {
                    EncryptedData.AddLast(b);
                }
            }


            char[] symbols = Encoding.Default.GetChars(EncryptedData.ToArray());
            textBox2.Clear();
            foreach (var v in symbols)
            {
                textBox2.Text += v;
            }
            textBox2.Update();
            textB2Helper = EncryptedData;
            button3.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LinkedList<byte> EncryptedData = new LinkedList<byte>();

            char[] first_data = textBox2.Text.ToCharArray();
            byte[] bytes;
            if (first_data.Length % 8 != 0)
            {
                bytes = new byte[first_data.Length + (8 - first_data.Length % 8)];
                Array.Copy(Encoding.Default.GetBytes(first_data), bytes, first_data.Length);
            }
            else
            {
                bytes = Encoding.Default.GetBytes(first_data);
            }


            int place = 0;
            byte[] OpenTextL = new byte[4];
            byte[] OpenTextR = new byte[4];
            byte[] EncryptText = new byte[8];

            CO_CBC = Encoding.ASCII.GetBytes("DESkey28");
            while (place < bytes.Length)
            {
                Array.Copy(bytes, place, OpenTextL, 0, 4);
                place += 4;
                Array.Copy(bytes, place, OpenTextR, 0, 4);
                place += 4;

                if (usual_mode_butt.Checked)
                    EncryptText = ReverseFeistel(OpenTextL, OpenTextR);
                else
                    EncryptText = CFB(OpenTextL, OpenTextR, 'D');
                foreach (var b in EncryptText)
                {
                    EncryptedData.AddLast(b);
                }
            }

            char[] symbols = Encoding.Default.GetChars(EncryptedData.ToArray());
            textBox2.Clear();
            foreach (var v in symbols)
            {
                textBox2.Text += v;
            }
            textBox2.Update();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox2.TextLength != 0 && textB2Helper.Count != 0)
            {
                SaveFileDialog Save = new SaveFileDialog();
                if (Save.ShowDialog() == DialogResult.OK)
                {

                    BinaryWriter writer = new BinaryWriter(File.Open(Save.FileName, FileMode.Create), Encoding.Default);
                    foreach (var b in textB2Helper)
                    {
                        writer.Write(b);
                    }
                    writer.Close();

                    label1.Text = "Готово";

                }
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("1) Скорость шифрования 31448 байт/с (Файл 1 Гб будет шифроваться 9 часов на процессоре i5-6200U 8Gb RAM!!!)\n" +
                "2) Реализована асинхронность: Есть возможность свернуть программу в процессе шифрования\n" +
                "3) При наведении на некоторые UI элементы есть подсказки!!!\n" +
                "4) На конце убираются добавочные нули после дешифровки. Word открывается штатно!",
    "Руководство пользователя");
        }
    }


}

    


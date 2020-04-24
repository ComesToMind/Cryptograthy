using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Cryptograthy
{
    public partial class Kazakevich
    {
        ///---------------------------
        ///
          
        
        int[,] IP = { { 58, 50, 42, 34, 26, 18, 10, 2 },
                      { 60, 52, 44, 36, 28, 20, 12, 4 },
                      { 62, 54, 46, 38, 30, 22, 14, 6 },
                      { 64, 56, 48, 40, 32, 24, 16, 8 },
                      { 57, 49, 41, 33, 25, 17, 9, 1 },
                      { 59, 51, 43, 35, 27, 19, 11, 3 },
                      { 61, 53, 45, 37, 29, 21, 13, 5 },
                      { 63, 55, 47, 39, 31, 23, 15, 7 } };

        int[] IP_1 = { 40, 8, 48, 16, 56, 24, 64, 32 ,
                        39, 7, 47, 15, 55, 23, 63, 31 ,
                        38, 6, 46, 14, 54, 22, 62, 30 ,
                        37, 5, 45, 13, 53, 21, 61, 29 ,
                        36, 4, 44, 12, 52, 20, 60, 28 ,
                        35, 3, 43, 11, 51, 19, 59, 27 ,
                        34, 2, 42, 10, 50, 18, 58, 26 ,
                        33, 1, 41, 9, 49, 17, 57, 25  };
        ///---------------------------
        int[] E = {  32, 1, 2, 3, 4, 5,
                     4, 5, 6, 7, 8, 9,
                     8, 9, 10, 11, 12, 13,
                     12, 13, 14, 15, 16, 17 ,
                     16, 17, 18, 19, 20, 21 ,
                     20, 21, 22, 23, 24, 25 ,
                     24, 25, 26, 27, 28, 29,
                     28, 29, 30, 31, 32, 1 };
                       
        int[] P = {  16, 7, 20, 21 ,
                      29, 12, 28, 17 ,
                      1, 15, 23, 26 ,
                      5, 18, 31, 10 ,
                      2, 8, 24, 14 ,
                      32, 27, 3, 9 ,
                      19, 13, 30, 6 ,
                      22, 11, 4, 25 };

        int[] G = { 57, 49, 41, 33, 25, 17, 9 ,
                    1, 58, 50, 42, 34, 26, 18 ,
                    10, 2, 59, 51, 43, 35, 27 ,
                    19, 11, 3, 60, 52, 44, 36 ,
                    63, 55, 47, 39, 31, 23, 15,
                    7, 62, 54, 46, 38, 30, 22 ,
                    14, 6, 61, 53, 45, 37, 29 ,
                    21, 13, 5, 28, 20, 12, 4 };

        int[] H = {   14, 17, 11, 24, 1, 5,
                      3, 28, 15, 6, 21, 10,
                      23, 19, 12, 4, 26, 8,
                      16, 7, 27, 20, 13, 2,
                      41, 52, 31, 37, 47, 55,
                      30, 40, 51, 45, 33, 48,
                      44, 49, 39, 56, 34, 53,
                      46, 42, 50, 36, 29, 32 };

        int[] Iteration = { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };

        ///---------------------------
        int[,] S1 = { { 14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7 },
                      { 0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8 },
                      { 4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0 },
                      { 15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13 } };

        int[,] S2 = { { 15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10 },
                      { 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5 },
                      { 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15 },
                      { 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9 } };

        int[,] S3 = { { 10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8 },
                      { 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1 },
                      { 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7 },//
					  { 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12 } };

        int[,] S4 = { { 7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15 },
                      { 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9 },
                      { 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4 },
                      { 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14 } };

        int[,] S5 = { { 2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9 },
                      { 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6 },
                      { 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14 },
                      { 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3 } };

        int[,] S6 = { { 12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11 },
                      { 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8 },
                      { 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6 },
                      { 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13 } };

        int[,] S7 = { { 4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1 },
                      { 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6 },
                      { 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2 },
                      { 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 } };

        int[,] S8 = { { 13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7 },
                      { 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2 },
                      { 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8 },
                      { 2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 } };
        ///---------------------------
        //сразу перменная под 16 раундовых ключей
        BitArray[] Keys = new BitArray[16];
        BitArray Key;
        //BitArray Key = new BitArray(Encoding.ASCII.GetBytes(strkey.ToCharArray()));
        //static string strkey = "DESkey2";
        //static int[] myInts = new int[2] { 2147455533, 2132343564 };
        
        public void DesFileEncrypt(object sender, EventArgs e)
        {
            //зашифрованный текст по  битам храним в листе
            LinkedList<byte> EncryptedData = new LinkedList<byte>();

            //читаем бинарно файл
            OpenFileDialog read = new OpenFileDialog();
            //FileInfo InfFile = new FileInfo(read.FileName);
            
            BinaryReader reader = new BinaryReader(File.Open(read.FileName, FileMode.Open),
                                                                          Encoding.Default);
            byte[] InitDataBlock = new byte[8]; //64 бита
            byte[] EncryptDataBlock = new byte[8]; //64 бита

            while (reader.PeekChar() > -1)
            {
                for (int i = 0; i < 8; i++)
                {
                    if(reader.PeekChar() == -1)
                    {
                        InitDataBlock[i] = 0x80;
                        i++;
                        while (i < 8)
                        {
                            InitDataBlock[i] = 0x00;
                            i++;
                        }
                        break;
                    }
                    InitDataBlock[i] = reader.ReadByte();//добавить возможность чтения по 8 байт сразу     
                }
                CryptDes(InitDataBlock, ref EncryptDataBlock, 'E');
                foreach(var b in EncryptDataBlock)
                {
                    EncryptedData.AddLast(b);
                }
                
            }

            reader.Close();
            SaveFileDialog Save = new SaveFileDialog();
            if (Save.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter writer = new BinaryWriter(File.Open(Save.FileName, FileMode.OpenOrCreate), Encoding.Default);
                foreach (var b in EncryptedData)
                {
                    writer.Write(b);
                }
                writer.Close();
            }



        }

        public void DesFileDecrypt(object sender, EventArgs e)
        {
            //зашифрованный текст по  битам храним в листе
            LinkedList<byte> EncryptedData = new LinkedList<byte>();

            //читаем бинарно файл

            OpenFileDialog read = new OpenFileDialog();
            //FileInfo InfFile = new FileInfo(read.FileName);
            if (read.ShowDialog() == DialogResult.OK)
            {
                BinaryReader reader = new BinaryReader(File.Open(read.FileName, FileMode.Open),
                                                                          Encoding.Default);
                byte[] InitDataBlock = new byte[8]; //64 бита
                byte[] EncryptDataBlock = new byte[8]; //64 бита

                while (reader.PeekChar() > -1)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (reader.PeekChar() == -1)
                        {
                            InitDataBlock[i] = 0x00;
                            i++;
                            while (i < 8)
                            {
                                InitDataBlock[i] = 0x00;
                                i++;
                            }
                            break;
                        }
                        InitDataBlock[i] = reader.ReadByte();//добавить возможность чтения по 8 байт сразу     
                    }
                    CryptDes(InitDataBlock, ref EncryptDataBlock, 'D');
                    foreach (var b in EncryptDataBlock)
                    {
                        EncryptedData.AddLast(b);
                    }

                }

                reader.Close();
            }
                
            SaveFileDialog Save = new SaveFileDialog();
            if (Save.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter writer = new BinaryWriter(File.Open(Save.FileName, FileMode.OpenOrCreate), Encoding.Default);
                foreach (var b in EncryptedData)
                {
                    writer.Write(b);
                }
                writer.Close();
            }
        }

        public void CryptDes(byte[] InitDataBlock, ref byte[] EncryptDataBlock, char mode)
        {
            //преобразуем байты в биты 
            BitArray tempBitInitBlock = new BitArray(InitDataBlock);
            BitArray IBitDataBlock = new BitArray(tempBitInitBlock.Count);
            //байты расположены в их порядке скармливания конструктору, а вот биты от младщих к старшим, надо инвертировать
            // у нас 6 = 110
            // в BitArray = 011
            //иначе DES вообще откажется работать))
            int index = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    IBitDataBlock[index] = tempBitInitBlock[i * 8 + j];//как можно упростить? 
                    index++;
                }
            }

            //делим на две части по 32 бита
            //и сразу деалем начлаьную перестановку
            BitArray L0 = new BitArray(32);
            index = 0;
            for (int i = 0; i < IP.GetLength(0) / 2; i++)
            {
                for (int j = 0; j < IP.GetLength(1); j++)
                {
                    L0[index] = IBitDataBlock[IP[i, j] - 1];
                    index++;
                }
            }
            BitArray R0 = new BitArray(32);
            index = 0;
            for (int i = IP.GetLength(0) / 2; i < IP.GetLength(0); i++)
            {
                for (int j = 0; j < IP.GetLength(1); j++)
                {
                    R0[index] = IBitDataBlock[IP[i, j] - 1];
                    index++;
                }
            }
            if (mode == 'E')
                Feistel(ref L0, ref R0);
            else
                ReverseFeistel(ref L0, ref R0);
            //скрепляем R0 and L0            
            for (int i = 0; i < 32; i++)
            {
                IBitDataBlock[i] = L0[i];
                IBitDataBlock[i + 32] = R0[i];

            }
            //финальная перестановка
            for (int i = 0; i < 64; i++)
            {
                tempBitInitBlock[i] = IBitDataBlock[IP_1[i]-1];
            }
            

            EncryptDataBlock = Convert_Bits_To_Bites(tempBitInitBlock);
        }
        //выполняем перестановочную функцию фейстеля 
        private byte[] Convert_Bits_To_Bites(BitArray IBitDataBlock)
        {
            //переводим обратно в LittleEndian для BitArray
            BitArray FinalCryptBitArray = new BitArray(64);
            int index = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    FinalCryptBitArray[index] = IBitDataBlock[i * 8 + j];//как можно упростить? 
                    index++;
                }
            }
            byte[] bytes = new byte[8];
             FinalCryptBitArray.CopyTo(bytes, 0);
            return bytes;
        }
        private void Feistel(ref BitArray L0, ref BitArray R0)
        {
            BitArray Li = new BitArray(32);
            BitArray Ri = new BitArray(32);
            for (int round = 0; round < 16; round++)
            {
                Li = R0;
                Ri = L0.Xor(f(R0,round));
                R0 = Ri;
                L0 = Li;

            }
        }
        private void ReverseFeistel(ref BitArray L16, ref BitArray R16)
        {
            BitArray Li = new BitArray(32);
            BitArray Ri = new BitArray(32);
            for (int round = 15; round >=0; round--)
            {
                Ri = L16;
                Li = R16.Xor(f(L16,round));
                R16 = Ri;
                L16 = Li;
            }
        }
        private BitArray f(BitArray R0, int round)
        {
            //расширяем
            BitArray E_R0 = new BitArray(48);
            for (int i = 0; i < 48; i++)
            {
                E_R0[i] = R0[E[i] - 1];
            }
            //складываем с ключом по модулю 
            E_R0.Xor(Keys[round]);
            //S-преобразования для сжатия 8 по 6 бит в 8 по 4

            //здесь возможна медленная работа программы, 
            int iteration = 1, TempResIndex = 0;
            int[] bit6_to_bit4 = null;
            BitArray TempResult = new BitArray(32);

            for(int i = 0; i < 48;i+=6)
            {
                //последний и первый
                int a = (E_R0[i] ? 1 : 0) *2
                      + (E_R0[i+5] ? 1 : 0);
                //четыре посредине
                int b =   (E_R0[i + 1] ? 1 : 0) *8
                        + (E_R0[i + 2] ? 1 : 0) *4
                        + (E_R0[i + 3] ? 1 : 0) *2
                        + (E_R0[i + 4] ? 1 : 0);

                switch (iteration)
                {
                    
                    case 1:
                        bit6_to_bit4 = Convert_Int_To_Bites(S1[a,b]);
                        break; 
                    case 2:
                        bit6_to_bit4 = Convert_Int_To_Bites(S2[a, b]);
                        break;
                    case 3:
                        bit6_to_bit4 = Convert_Int_To_Bites(S3[a, b]);
                        break;
                    case 4:
                        bit6_to_bit4 = Convert_Int_To_Bites(S4[a, b]);
                        break;
                    case 5:
                        bit6_to_bit4 = Convert_Int_To_Bites(S5[a, b]);
                        break;
                    case 6:
                        bit6_to_bit4 = Convert_Int_To_Bites(S6[a, b]);
                        break;
                    case 7:
                        bit6_to_bit4 = Convert_Int_To_Bites(S7[a, b]);
                        break;
                    case 8:
                        bit6_to_bit4 = Convert_Int_To_Bites(S8[a, b]);
                        break;
                }
                for (int j = 0; j < 4; j++)
                {
                    if (bit6_to_bit4[j] == 1)
                        TempResult[TempResIndex] = true;
                    TempResIndex++;

                }
                iteration++;
            }
            BitArray FinalResult = new BitArray(32);
            for (int i = 0; i < 32; i++)
            {
                FinalResult[i] = TempResult[P[i]-1];
            }
            return FinalResult;
        }

        private static int[] Convert_Int_To_Bites(int amount)
        {
            int[] binary = new int[4];
            int index = 3;
            while (amount > 0)
            {
                binary[index] = amount % 2;
                amount /= 2;
                index--;
            }
            return binary;
        }

        //функция генерации раундовых ключей 
        public void DesGenerate_Each_Round_Keys(/*object sender, EventArgs e*/)
        {
            BitArray BigEndianKey = new BitArray(64);
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 6; j >= 0; j--)
                {
                    BigEndianKey[index] = Key[i * 8 + j];
                    index++;
                }
                BigEndianKey[index] = false;//добавить здесь parity bit в будущем
                index++;
            }
            //начинаем перестановку
            BitArray C0D0 = new BitArray(56);
            for (int i = 0; i < 56; i++)
            {
                C0D0[i] = BigEndianKey[G[i] - 1];
            }
            //далее раундовые преобразования 
            for (int round = 0; round < 16; round++)
            {
                //Ki ключ
                Keys[round] = new BitArray(48);
                //циклический сдвиг влево 
                for (int cyc = 0; cyc < Iteration[round]; cyc++)
                {
                    bool temp_C = C0D0[0];
                    bool temp_D = C0D0[28];
                    for (int i = 0; i < 27; i++)
                    {
                        C0D0[i] = C0D0[i + 1];
                    }
                    for (int i = 28; i < 55; i++)
                    {
                        C0D0[i] = C0D0[i + 1];
                    }
                    C0D0[27] = temp_C;
                    C0D0[55] = temp_D;
                }
                //конечная перестановка
                for (int i = 0; i < 48; i++)
                {
                    Keys[round][i] = C0D0[H[i] - 1];
                }
            }

        }
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public void DesReadKey(object sender, EventArgs e)
        { 
            foreach (Control ctrl in controls)
            {
                if (ctrl.TabIndex == 6)
                {
                    TextBox cmb = (TextBox)ctrl;
                    if (cmb.Text != null && !cmb.Text.Equals(""))
                    {
                        if (cmb.TextLength != 14)
                        {
                            MessageBox.Show("Размер ключа должен быть равен 7", "Некорректные данные");
                            return;
                        }
                        string pattern = @"[0-9A-F]{14}";
                        if (Regex.IsMatch(cmb.Text, pattern))
                        {
                            byte[] bytes = StringToByteArray(cmb.Text);
                            Key = new BitArray(bytes);
                            DesGenerate_Each_Round_Keys();
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
                    break;

                }

            }

        }

        private void DesGenerate_Innit_Key(object sender, EventArgs e)
        {
            Random rand = new Random(DateTimeOffset.Now.Millisecond);
            byte[] KeyB = new byte[7];
            rand.NextBytes(KeyB);
            //сразу можно шифровать
            //не забыть активировать кнопки
            Key = new BitArray(KeyB);
            DesGenerate_Each_Round_Keys();
            //вывести на экран 
            foreach (Control ctrl in controls)
            {
                if (ctrl.TabIndex == 6)
                {
                    TextBox cmb = (TextBox)ctrl;
                    cmb.Text = BitConverter.ToString(KeyB).Replace("-","");
                    //cmb.Text = Encoding.ASCII.GetString(KeyB);


                }
            }
        }

    }
}
